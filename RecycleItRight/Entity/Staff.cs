using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Staff : User
    {
        public string StaffId { get; set; }
        public Staff(
            string userId,
            string username,
            string email,
            string password,
            string secondaryEmail,
            string firstName,
            string lastName,
            string staffId,
            Role role = Role.Staff
            ) : base (
                userId,
                username,
                firstName,
                lastName,
                email,
                password,
                secondaryEmail
                )
        {
            StaffId = staffId;
        }
    }
}
