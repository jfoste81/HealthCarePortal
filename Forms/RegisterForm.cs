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
    public partial class RegisterForm: Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            comboBoxUserType.SelectedIndexChanged += ComboBoxUserType_SelectedIndexChanged;
            comboBoxUserType.SelectedIndex = 0;  // default to Patient

            comboBoxGender.SelectedIndex = 0; 
        }

        private void ComboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExtraFieldLabel();
            // Show the textbox only when “Other” is selected
            textBoxGenderCustom.Visible =
                comboBoxGender.SelectedItem?.ToString() == "Other";
        }

        private void UpdateExtraFieldLabel()
        {
            bool isPatient = comboBoxUserType.SelectedItem.ToString() == "Patient";
            labelExtraField.Text = isPatient ? "Address:" : "Specialty:";
            textBoxExtraField.Text = "";
        }

        private void ComboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show the “please specify” box only if they pick Other
            textBoxGenderCustom.Visible = comboBoxGender.SelectedItem.ToString() == "Other";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Gather common fields
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;
            string confirm = textBoxConfirmPassword.Text;
            string name = textBoxName.Text.Trim();
            int age = (int)numericUpDownAge.Value;
            string gender = comboBoxGender.SelectedItem.ToString() == "Other"
                                ? textBoxGenderCustom.Text.Trim()
                                : comboBoxGender.SelectedItem.ToString();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string userType = comboBoxUserType.SelectedItem.ToString();
            string extra = textBoxExtraField.Text.Trim();  // address or specialty

            // Basic validation
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                password != confirm ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) ||
                (comboBoxGender.SelectedItem.ToString() == "Other" && string.IsNullOrEmpty(textBoxGenderCustom.Text)) ||
                string.IsNullOrEmpty(extra))
            {
                MessageBox.Show(
                  "Please fill in all fields and ensure passwords match.",
                  "Missing or Invalid Information",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );
                return;
            }

            // Create and register the User 
            bool added;
            if (userType == "Patient")
            {
                var patient = new Patient(
                    username, password,
                    name, age, gender,
                    phone, email,
                    extra        // Address
                );
                added = Portal.Instance.AddPatient(patient);
            }
            else
            {
                var doctor = new Doctor(
                    username, password,
                    name, age, gender,
                    phone, email,
                    extra        // Specialty
                );
                added = Portal.Instance.AddDoctor(doctor);
            }

            if (!added)
            {
                MessageBox.Show(
                  $"Username '{username}' is already taken. Choose another.",
                  "Registration Failed",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
                return;
            }

            MessageBox.Show(
              $"{userType} '{username}' registered successfully!",
              "Registration Complete",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            );
            this.Close();  // return to LoginForm
        }
    }
}
