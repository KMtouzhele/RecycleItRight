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
        public void Register(User newUser)
        {
            Console.WriteLine("--------------------Registering---------------------");
            Console.WriteLine("Registering a new user named " + newUser.FirstName + newUser.LastName);
            Console.WriteLine("His password is " + newUser.Password);
            Console.WriteLine("--------------------Register Complete---------------------\n");
        }

        public void Login(User user)
        {
            Console.WriteLine("--------------------Loging In---------------------");
            Console.WriteLine("Logging in " + user.FirstName + user.LastName);
            Console.WriteLine("Welcome " + user.FirstName + user.LastName);
            Console.WriteLine("--------------------Registering---------------------\n");
        }
    }
}
