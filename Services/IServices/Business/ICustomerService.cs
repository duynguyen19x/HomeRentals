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
        Result<IList<CustomerModel>> GetAlls();
        Result<Guid> Save(CustomerModel Customer);
        Result<CustomerModel> GetById(Guid id);
        Result<bool> DeleteById(Guid id);
    }
}
