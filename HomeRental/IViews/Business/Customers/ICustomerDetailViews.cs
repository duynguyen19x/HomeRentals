using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Business.Customers
{
    public interface ICustomerDetailViews
    {
        Guid? Id { get; set; }
        string CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }
        DateTime DOB { get; set; }
        int Gender { get; set; }
        string PhoneNumber { get; set; }
    }
}
