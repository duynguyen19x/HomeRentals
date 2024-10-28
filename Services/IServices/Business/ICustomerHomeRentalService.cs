using BusinessObjects.Dtos.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Business
{
    public interface ICustomerHomeRentalService
    {
        Result<IList<CustomerHomeRentalDto>> GetCustomerHomeRentalByRenteds();
        Result<IList<CustomerHomeRentalDto>> GetCustomerHomeRentalByNotRenteds();
    }
}
