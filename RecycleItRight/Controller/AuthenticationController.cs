using RecycleItRight.Adapter;
using RecycleItRight.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Controller
{
    public class AuthenticationController
    {
        public UserAdapter userAdapter;
        public AuthenticationController()
        {
            this.userAdapter = new UserAdapter();
        }
        public void Register(User newUser)
        {
            if (newUser.FirstName.Length > 0 && newUser.LastName.Length > 0) {
                userAdapter.SaveNewUser(newUser);
            }
            else
            {
                Console.WriteLine("Invalid User Info: First Name and Last Name are required!");
            }
        }

        public void Login(string username, string password)
        {
            User? user = userAdapter.FetchUserByUsername(username);
            if (user != null)
            {
                if (user.Password == password)
                {
                    Console.WriteLine("User " + user.FirstName + " " + user.LastName + " logged in!");
                }
                else
                {
                    Console.WriteLine("Wrong Password!");
                }
            }
            else
            {
                Console.WriteLine("Username Not Registered!");
            }
        }

    }
}
