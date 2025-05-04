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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;
            string userType = comboBoxUserType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) 
                || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(userType))
            {
                MessageBox.Show("Please fill in username, password, and select a user type.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Authenticate by credentials
            User user = Portal.Instance.Authenticate(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Now verify the selected type matches the authenticated user
            if (userType == "Patient")
            {
                if (user is Patient patient)
                {
                    var dash = new DashboardPatientForm(patient);
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                      "These credentials belong to a doctor. Please select 'Doctor' or use a patient account.",
                      "Login Failed",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );
                }
            }
            else // userType == "Doctor"
            {
                if (user is Doctor doctor)
                {
                    var dash = new DashboardDoctorForm(doctor);
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                      "These credentials belong to a patient. Please select 'Patient' or use a doctor account.",
                      "Login Failed",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );
                }
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // Open the RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
