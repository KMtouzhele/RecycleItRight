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
            string username,
            string email,
            string password,
            string firstName,
            string lastName,
            string secondaryEmail,
            string studentId,

            Language preferredLanguage,
            Role role = Role.Student
            )
            : base (
                  username,
                  email,
                  password,
                  firstName,
                  lastName
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
