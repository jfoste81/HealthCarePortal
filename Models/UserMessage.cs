using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePortal.Models
{
    public class UserMessage
    {
        public string Author { get; set; }
        public DateTime Timestamp { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public UserMessage(string author, string subject, string body)
        {
            Author = author;
            Subject = subject;
            Body = body;
            Timestamp = DateTime.Now;
        }
    }
}
