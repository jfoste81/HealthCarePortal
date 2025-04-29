using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Illness
    {
        public DateTime DateContracted { get; set; }
        public string Name { get; set; }

        public Illness(string name)
        {
            Name = name;
            DateContracted = DateTime.Now;
        }
    }
}
