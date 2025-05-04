using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class Notification
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }

        public Notification(string type, string description)
        {
            Type = type;
            Description = description;
            Timestamp = DateTime.Now;
        }
    }
}
