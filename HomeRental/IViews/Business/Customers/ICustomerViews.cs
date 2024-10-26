using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Business.Customers
{
    public interface ICustomerViews
    {
        IList<CustomerModel> Customers { get; set; }
    }
}
