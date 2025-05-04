using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Patient : User
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Illness> MedicalHistory { get; } = new();
        public float Balance { get; set; }
        public List<Prescription> Prescriptions { get; } = new();

        public Patient(string username, string password,
                       string name, int age, string gender,
                       string phone, string email,
                       string address)
          : base(username, password, name, age, gender, phone, email)
        {
            Address = address;
            Balance = 0f;
        }
    }
}
