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

        // Patient scheduling an appointment
        public AppointmentForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            _isEdit = false;

            // populate doctor list
            comboBoxDoctor.Items.AddRange(
                Portal.Instance.Doctors.Select(d => d.Name).ToArray()
            );
            comboBoxDoctor.SelectedIndex = 0;

            // setup picker
            dateTimePickerDate.MinDate = DateTime.Today;

            // populate time slots and wire events
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.SelectedIndexChanged += (s, e) => PopulateTimeSlots();
            dateTimePickerDate.ValueChanged += (s, e) => PopulateTimeSlots();
            PopulateTimeSlots();

            buttonSave.Text = "Schedule";
        }

        // Doctor editing an appointment
        public AppointmentForm(Doctor doctor, Appointment appt)
        {
            InitializeComponent();
            _doctor = doctor;
            _appt = appt;
            _isEdit = true;

            // only this doctor
            comboBoxDoctor.Items.Add(_doctor.Name);
            comboBoxDoctor.SelectedIndex = 0;
            comboBoxDoctor.Enabled = false;

            // pre-fill values
            dateTimePickerDate.Value = _appt.Timestamp.Date;
            textBoxDescription.Text = _appt.Description;

            // populate time slots and wire events
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.SelectedIndexChanged += (s, e) => PopulateTimeSlots();
            dateTimePickerDate.ValueChanged += (s, e) => PopulateTimeSlots();
            PopulateTimeSlots();

            // select the existing time if present
            var timeStr = _appt.Timestamp.ToString("h:mm tt");
            var idx = comboBoxTime.Items.IndexOf(timeStr);
            if (idx >= 0)
                comboBoxTime.SelectedIndex = idx;

            buttonSave.Text = "Save";
        }

        private void PopulateTimeSlots()
        {
            comboBoxTime.Items.Clear();
            
            string docName = comboBoxDoctor.SelectedItem.ToString();
            var doctor = Portal.Instance.Doctors
                .First(d => d.Name == docName);

            DateTime date = dateTimePickerDate.Value.Date;
            var booked = new HashSet<TimeSpan>(
                doctor.Appointments
                      .Where(a => a.Timestamp.Date == date)
                      .Select(a => a.Timestamp.TimeOfDay)
            );

            for (int hour = 8; hour <= 17; hour++)
            {
                var slot = new TimeSpan(hour, 0, 0);
                if (!booked.Contains(slot))
                    comboBoxTime.Items.Add(date.Add(slot).ToString("h:mm tt"));
            }

            if (comboBoxTime.Items.Count > 0)
                comboBoxTime.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Gather inputs
            DateTime date = dateTimePickerDate.Value.Date;
            string timeString = comboBoxTime.SelectedItem.ToString();
            TimeSpan time = DateTime.Parse(timeString).TimeOfDay;
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
                // Prevent double-booking
                if (doctor.Appointments.Any(a => a.Timestamp == when))
                {
                    MessageBox.Show(
                        $"Dr. {doctor.Name} already has an appointment at {when:t}.",
                        "Time Conflict",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

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

                // Add to patient and doctor's schedule
                _patient.Appointments.Add(appt);
                doctor.Appointments.Add(appt);

                // Add patient to doctor only once
                if (!doctor.Patients.Contains(_patient))
                    doctor.Patients.Add(_patient);

                // Notify doctor
                doctor.Notifications.Add(new Notification("Appointment"));
            }
            else
            {
                // Editing existing
                _appt.Timestamp = when;
                _appt.Description = desc;

                // Notify of update
                var patientObj = Portal.Instance.Patients
                                  .First(p => p.Name == _appt.PatientName);
                patientObj.Notifications.Add(new Notification("Appointment"));
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
