using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Doctor : User
    {
        public int Id { get; set; }
        public string Specialty { get; set; }
        public List<Patient> Patients { get; } = new();

        public Doctor(string username, string password,
                      string name, int age, string gender,
                      string phone, string email,
                      string specialty)
          : base(username, password, name, age, gender, phone, email)
        {
            Specialty = specialty;
        }
    }
}
