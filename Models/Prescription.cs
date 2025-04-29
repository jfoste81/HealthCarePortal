using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Prescription
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Description { get; set; }

        public Prescription(string name, string dosage, string desc)
        {
            Name = name;
            Dosage = dosage;
            Description = desc;
        }
    }
}
