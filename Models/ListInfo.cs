using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPage.Models
{
    public class User : IEquatable<User>
    {
        public string UserName { get; set; }

        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime RegTime { get; set; }

        public override string ToString()
        {
            return "Email: " + UserEmail + "   Name: " + UserName;
        }
        public bool Equals(User other)
        {
            if (other == null) return false;
            return (this.UserEmail.Equals(other.UserEmail));
        }
    }
}
