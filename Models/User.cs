using HealthCarePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcarePortal.Models
{
    public abstract class User
    {
        public string Username { get; }
        public string Password { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public List<Appointment> Appointments { get; } = new();
        public List<UserMessage> Inbox { get; } = new();
        public List<Notification> Notifications { get; } = new();

        protected User(string username, string password,
                       string name, int age, string gender,
                       string phone, string email)
        {
            Username = username;
            Password = password;
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
            Email = email;
        }
    }
}
