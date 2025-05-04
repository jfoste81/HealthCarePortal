using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCarePortal.Models;

namespace HealthCarePortal.Forms
{
    public partial class AppointmentForm : Form
    {
        private readonly Patient _patient;
        private readonly Doctor _doctor;
        private readonly Appointment _appt;
        private readonly bool _isEdit;
        private bool _snapping = false;

        // Constructor for a Patient creating a new appointment
        public AppointmentForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            _isEdit = false;

            // Populate doctor list
            comboBoxDoctor.Items.AddRange(
                Portal.Instance.Doctors.Select(d => d.Name).ToArray()
            );
            comboBoxDoctor.SelectedIndex = 0;

            // Setup pickers
            dateTimePickerDate.MinDate = DateTime.Today;
            dateTimePickerTime.ShowUpDown = true;

            buttonSave.Text = "Schedule";
        }

        // Constructor for a Doctor editing an appointment
        public AppointmentForm(Doctor doctor, Appointment appt)
        {
            InitializeComponent();
            _doctor = doctor;
            _appt = appt;
            _isEdit = true;

            // Only this doctor
            comboBoxDoctor.Items.Add(_doctor.Name);
            comboBoxDoctor.SelectedIndex = 0;
            comboBoxDoctor.Enabled = false;

            // Pre-fill values
            dateTimePickerDate.Value = _appt.Timestamp.Date;
            dateTimePickerTime.Value = _appt.Timestamp;
            textBoxDescription.Text = _appt.Description;

            buttonSave.Text = "Save";
        }

        private void DateTimePickerTime_ValueChanged(object sender, EventArgs e)
        {
            if (_snapping) return;
            _snapping = true;

            var dt = dateTimePickerTime.Value;
            int minutes = dt.Minute;
            // snap to nearest 0 or 30
            int snapped =
                minutes < 15 ? 0 :
                minutes < 45 ? 30 :
                               0;

            // if we’re past :45, roll over the hour
            if (minutes >= 45)
                dt = dt.AddHours(1).AddMinutes(-minutes);
            else
                dt = dt.AddMinutes(-minutes);

            dateTimePickerTime.Value = new DateTime(
                dt.Year, dt.Month, dt.Day,
                dt.Hour, snapped, 0
            );

            _snapping = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Gather inputs
            DateTime date = dateTimePickerDate.Value.Date;
            TimeSpan time = dateTimePickerTime.Value.TimeOfDay;
            DateTime when = date.Add(time);
            string desc = textBoxDescription.Text.Trim();
            string docName = comboBoxDoctor.SelectedItem.ToString();

            if (string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please enter a description.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Look up doctor object
            var doctor = Portal.Instance.Doctors
                             .First(d => d.Name == docName);

            if (!_isEdit)
            {
                // Create new appointment
                int newId = Portal.Instance.Patients
                              .SelectMany(p => p.Appointments)
                              .Select(a => a.Id)
                              .DefaultIfEmpty(0)
                              .Max() + 1;

                var appt = new Appointment(newId,
                               _patient.Name,
                               doctor.Name,
                               when,
                               desc);

                // Add to patient
                _patient.Appointments.Add(appt);

                // Add patient to doctor only once
                if (!doctor.Patients.Contains(_patient))
                    doctor.Patients.Add(_patient);

                // Notify each
                _patient.Notifications.Add(new Notification(
                    "Appointment",
                    $"Your appointment with Dr. {doctor.Name} is set for {when:g}."
                ));
                doctor.Notifications.Add(new Notification(
                    "Appointment",
                    $"New appointment with {_patient.Name} on {when:g}."
                ));
            }
            else
            {
                // Editing existing
                _appt.Timestamp = when;
                _appt.Description = desc;

                // Notify of update
                var patientObj = Portal.Instance.Patients
                                  .First(p => p.Name == _appt.PatientName);
                patientObj.Notifications.Add(new Notification(
                    "Appointment",
                    $"Your appointment on {when:g} with Dr. {doctor.Name} has been updated."
                ));
                doctor.Notifications.Add(new Notification(
                    "Appointment",
                    $"Appointment with {patientObj.Name} updated to {when:g}."
                ));
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
