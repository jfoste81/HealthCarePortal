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
using HealthCarePortal.Helpers;

namespace HealthCarePortal.Forms
{
    public partial class PatientDetailForm : Form
    {
        private readonly Doctor _doctor;
        private readonly Patient _patient;

        public PatientDetailForm(Doctor doctor, Patient patient)
        {
            InitializeComponent();
            _doctor = doctor;
            _patient = patient;

            // Demographics
            labelName.Text = $"Name: {_patient.Name}";
            labelAgeGender.Text = $"Age/Gender: {_patient.Age} / {_patient.Gender}";
            labelPhone.Text = $"Phone: {_patient.Phone}";
            labelEmail.Text = $"Email: {_patient.Email}";

            // Close Button
            buttonClose.Click += (s, e) => Close();

            // Initial load
            LoadMedicalHistory();
            LoadPrescriptions();
        }

        private void LoadMedicalHistory()
        {
            listViewIllness.Items.Clear();
            foreach (var ill in _patient.MedicalHistory.OrderBy(i => i.DateContracted))
            {
                var item = new ListViewItem(ill.DateContracted.ToShortDateString());
                item.SubItems.Add(ill.Name);
                listViewIllness.Items.Add(item);
            }
            foreach (ColumnHeader col in listViewIllness.Columns)
                col.Width = -2;
        }

        private void LoadPrescriptions()
        {
            listViewPrescriptions.Items.Clear();
            foreach (var rx in _patient.Prescriptions)
            {
                var item = new ListViewItem(rx.Name);
                item.SubItems.Add(rx.Dosage);
                item.SubItems.Add(rx.Description);
                listViewPrescriptions.Items.Add(item);
            }
            foreach (ColumnHeader col in listViewPrescriptions.Columns)
                col.Width = -2;
        }

        // Illnesses Buttons 

        private void buttonNewDiagnosis_Click(object sender, EventArgs e)
        {
            string name = Prompt.ShowDialog("Enter diagnosis:", "Add Diagnosis");
            if (string.IsNullOrWhiteSpace(name)) return;

            var ill = new Illness(name);
            _patient.MedicalHistory.Add(ill);

            _patient.Notifications.Add(new Notification(
                "MedHistory",
                $"Dr. {_doctor.Name} added diagnosis '{name}'."
            ));

            LoadMedicalHistory();
        }

        private void buttonEditDiagnosis_Click(object sender, EventArgs e)
        {
            if (listViewIllness.SelectedIndices.Count == 0) return;
            var ill = _patient.MedicalHistory[listViewIllness.SelectedIndices[0]];

            string newName = Prompt.ShowDialog("Edit diagnosis:", "Edit Diagnosis", ill.Name);
            if (string.IsNullOrWhiteSpace(newName)) return;

            ill.Name = newName;
            LoadMedicalHistory();
        }

        private void buttonRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            if (listViewIllness.SelectedIndices.Count == 0) return;
            var ill = _patient.MedicalHistory[listViewIllness.SelectedIndices[0]];

            var res = MessageBox.Show(
                $"Remove diagnosis '{ill.Name}'?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (res != DialogResult.Yes) return;

            _patient.MedicalHistory.Remove(ill);
            _patient.Notifications.Add(new Notification(
                "MedHistory",
                $"Dr. {_doctor.Name} removed diagnosis '{ill.Name}'."
            ));
            LoadMedicalHistory();
        }

        // Prescription Buttons

        //private void buttonNewPrescription_Click(object sender, EventArgs e)
        //{
        //    using var form = new PrescriptionForm(
        //       prescriber: _doctor,
        //       patient: _patient
        //   );
        //    if (form.ShowDialog() == DialogResult.OK)
        //        LoadPrescriptions();
        //}

        //private void buttonEditPrescription_Click(object sender, EventArgs e)
        //{
        //    if (listViewPrescriptions.SelectedIndices.Count == 0) return;
        //    var rx = _patient.Prescriptions[listViewPrescriptions.SelectedIndices[0]];

        //    // Overload PrescriptionForm to accept an existing prescription for editing
        //    using var form = new PrescriptionForm(
        //        prescriber: _doctor,
        //        patient: _patient,
        //        prescription: rx
        //    );
        //    if (form.ShowDialog() == DialogResult.OK)
        //        LoadPrescriptions();
        //}

        private void buttonRemovePrescription_Click(object sender, EventArgs e)
        {
            if (listViewPrescriptions.SelectedIndices.Count == 0) return;
            var rx = _patient.Prescriptions[listViewPrescriptions.SelectedIndices[0]];

            var res = MessageBox.Show(
                $"Remove prescription '{rx.Name}'?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (res != DialogResult.Yes) return;

            _patient.Prescriptions.Remove(rx);
            _patient.Notifications.Add(new Notification(
                "Prescription",
                $"Dr. {_doctor.Name} removed prescription '{rx.Name}'."
            ));
            LoadPrescriptions();
        }
    }
}
