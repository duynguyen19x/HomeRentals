using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Business
{
    public interface ICustomerService
    {
        Result<IList<CustomerModel>> GetCustomers();
        Result<CustomerModel> Save(CustomerModel Customer);
        Result<CustomerModel> GetCustomerById(Guid id);
        Result<bool> DeleteCustomerById(Guid id);
    }
}
