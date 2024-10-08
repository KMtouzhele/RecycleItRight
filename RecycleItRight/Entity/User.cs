using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SecondaryEmail { get; set; }
        public User(string userId, string username, string firstName, string lastName, string email, string password, string secondaryEmail) {
            UserId = userId;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            SecondaryEmail = secondaryEmail;
        }
    }
}