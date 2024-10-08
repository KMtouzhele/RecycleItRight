using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Student : User
    {
        string StudentId { get; set; }
        Language PrefferedLanguage { get; set; }
        public Student(
            string userId,
            string username,
            string email,
            string password,
            string secondaryEmail,
            string studentId,
            string firstName,
            string lastName,
            Language preferredLanguage
            )
            : base(
                  userId,
                  username, 
                  firstName,
                  lastName,
                  email, 
                  password, 
                  secondaryEmail
                  )
        {
            StudentId = studentId;
            PrefferedLanguage = preferredLanguage;
        }

        public void ChangeLanguage(Language newLanguage)
        {
            PrefferedLanguage = newLanguage;
            Console.WriteLine("Language changed to " + newLanguage);
        }
    }
    public enum Language
    {
        English,
        Spanish,
        French,
        German,
        Italian,
        Dutch,
        Portuguese
    }
}
