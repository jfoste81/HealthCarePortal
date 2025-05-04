using HealthCarePortal.Forms;
using HealthCarePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePortal
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            // *********************** DELETE THESE LINES AFTER TESTING ***************************

            var testPatient = new Patient(
                username: "joshua",
                password: "hi",
                name: "Joshua Foster",
                age: 25,
                gender: "Male",
                phone: "704",
                email: "patient@gmail.com",
                address: "42 Yellow Street"
                );
            Portal.Instance.AddPatient(testPatient);

            var testDoctor = new Doctor(
                username: "foster",
                password: "hi",
                name: "Foster Joshua",
                age: 25,
                gender: "Male",
                phone: "704",
                email: "doc@gmail.com",
                specialty: "PCP"
                );
            Portal.Instance.AddDoctor(testDoctor);

            // *********************** DELETE THESE LINES AFTER TESTING ***************************

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
