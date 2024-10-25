using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Business.User
{
    public interface IUserDetailViews
    {
        Guid? Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Address { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DOB { get; set; }
        int Gender { get; set; }
        string PhoneNumber { get; set; }
    }
}
