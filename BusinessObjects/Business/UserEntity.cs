using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Business
{
    public class UserEntity : Entity<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}
