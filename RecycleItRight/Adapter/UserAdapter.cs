using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecycleItRight.Entity;

namespace RecycleItRight.Adapter
{
    public class UserAdapter
    {
        //This acts like a fake data table for users
        public List<User> users = new List<User>();

        public void SaveNewUser(User user) {
            DBConnection();
            users.Add(user);
            Console.WriteLine("User " + user.FirstName + " " + user.LastName + " saved to the database!");
        }
        public bool UpdateUser(User user) {
            DBConnection();
            foreach (User u in users)
            {
                if (u.UserId == user.UserId)
                {
                    u.Username = user.Username;
                    u.Email = user.Email;
                    u.Password = user.Password;
                    u.FirstName = user.FirstName;
                    u.LastName = user.LastName;
                    u.Phone = user.Phone;
                    u.SecondaryEmail = user.SecondaryEmail;
                    u.NotificationPreference = user.NotificationPreference;
                    u.Role = user.Role;
                    Console.WriteLine("User " + user.FirstName + " " + user.LastName + " updated in the database!");
                    return true;
                }
            }
            return false;
        }

        public User? FetchUserByUsername(string username) {
            DBConnection();
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    Console.WriteLine("User " + user.FirstName + " " + user.LastName + " fetched from the database!");
                    return user;
                }
            }
            Console.WriteLine("User not found in the database!");
            return null;
        }

        private void DBConnection()
        {
            Console.WriteLine("Connecting to the database...");
            Console.WriteLine("Connected to database -> users Table!");
        }
    }
}
