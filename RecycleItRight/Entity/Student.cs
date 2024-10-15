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
            Language preferredLanguage,
            Role role = Role.Student
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

        public void ChangeSecondaryEmail(string email) {
            SecondaryEmail = email;
            Console.WriteLine("Secondary email changed to " + email);
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
