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
    public partial class PrescriptionForm : Form
    {
        private readonly Doctor _prescriber;
        private readonly Patient _patient;
        private readonly Prescription _existing;  // null in “new” mode
        private readonly bool _isEdit;

        // new prescription 
        public PrescriptionForm(Doctor prescriber, Patient patient)
        {
            InitializeComponent();
            _prescriber = prescriber;
            _patient = patient;
            _isEdit = false;

            buttonSave.Text = "Add";
        }

        // edit prescription 
        public PrescriptionForm(Doctor prescriber, Patient patient, Prescription existing)
        {
            InitializeComponent();
            _prescriber = prescriber;
            _patient = patient;
            _existing = existing;
            _isEdit = true;

            // prefill fields
            textBoxMedName.Text = existing.Name;
            textBoxDosage.Text = existing.Dosage;
            textBoxNotes.Text = existing.Description;

            buttonSave.Text = "Save";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // grab values from text boxes
            string name = textBoxMedName.Text.Trim();
            string dose = textBoxDosage.Text.Trim();
            string notes = textBoxNotes.Text.Trim();

            // input validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dose))
            {
                MessageBox.Show(
                  "Medication and dosage are required.",
                  "Missing Information",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );
                return;
            }

            if (_isEdit)
            {
                // update existing
                _existing.Name = name;
                _existing.Dosage = dose;
                _existing.Description = notes;

                // notify patient
                _patient.Notifications.Add(new Notification("Prescription"));
            }
            else
            {
                // create new
                var rx = new Prescription(name, dose, notes);
                _patient.Prescriptions.Add(rx);

                // notify patient
                _patient.Notifications.Add(new Notification("Prescription"));
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
