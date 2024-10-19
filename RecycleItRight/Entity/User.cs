using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string SecondaryEmail { get; set; }
        public bool NotificationPreference { get; set; }
        public Role Role { get; set; }
        public User(string username, string email, string password, string firstName, string lastName)
        {
            Username = username;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Phone = "";
            SecondaryEmail = "";
            NotificationPreference = true;
        }
        public void UpdateProfile(string phone, string secondaryEmail, bool notificationPreference)
        {
            Phone = phone;
            SecondaryEmail = secondaryEmail;
            NotificationPreference = notificationPreference;
        }
    }

    public enum Role { 
        Staff,
        Student
    }
}