using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcarePortal.Models;
using HealthCarePortal.Models;

namespace HealthCarePortal
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

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // 1) Ask the Portal to authenticate
            User user = Portal.Instance.Authenticate(username, password);

            // 2) Check the result
            if (user is Patient patient)
            {
                //Open the patient dashboard, passing the Patient object
                var dash = new DashboardPatientForm(patient);
                dash.Show();
                this.Hide();
                Console.WriteLine("Patient logged in successfully."); // ************ UNCOMMENT ABOVE LINES ************
            }
            else if (user is Doctor doctor)
            {
                //var dash = new DashboardDoctorForm(doctor);
                //dash.Show();
                //this.Hide();
                Console.WriteLine("Doctor logged in successfully."); // ************ UNCOMMENT ABOVE LINES ************
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
