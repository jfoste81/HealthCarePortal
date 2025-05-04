using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }

        public Appointment(int id, string patientName, string doctorName, DateTime when, string desc)
        {
            Id = id;
            PatientName = patientName;
            DoctorName = doctorName;
            Timestamp = when;
            Description = desc;
        }
    }
}
