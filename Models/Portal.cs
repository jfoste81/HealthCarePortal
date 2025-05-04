using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Portal
    {
        public List<Patient> Patients { get; } = new();
        public List<Doctor> Doctors { get; } = new();

        // singleton
        private static readonly Portal _instance = new();
        public static Portal Instance => _instance;

        private Portal() { }

        public bool AddPatient(Patient patient)
        {
            if (Patients.Any(x => x.Username == patient.Username)) return false;
            Patients.Add(patient);
            return true;
        }

        public bool AddDoctor(Doctor doctor)
        {
            if (Doctors.Any(x => x.Username == doctor.Username)) return false;
            Doctors.Add(doctor);
            return true;
        }

        public User? Authenticate(string username, string password)
        {
            return (User?)Patients
                        .FirstOrDefault(u => u.Username == username && u.Password == password)
                  ?? Doctors
                        .FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
