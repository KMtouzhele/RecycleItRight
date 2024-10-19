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
            string username,
            string email,
            string password,
            string firstName,
            string lastName,
            string secondaryEmail,
            string staffId,
            Role role = Role.Staff
            ) : base (
                username,
                email,
                password,
                firstName,
                lastName
                )
        {
            StaffId = staffId;
        }
    }
}
