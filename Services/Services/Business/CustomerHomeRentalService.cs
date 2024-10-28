using BusinessObjects.Dtos.Business;
using Services.IServices.Business;
using System.Collections.Generic;
using Utilities;

namespace Services.Services.Business
{
    public class CustomerHomeRentalService : ICustomerHomeRentalService
    {
        public CustomerHomeRentalService()
        {
        }

        public Result<IList<CustomerHomeRentalDto>> GetCustomerHomeRentalByRenteds()
        {
            var result = new Result<IList<CustomerHomeRentalDto>>();

            return result;
        }

        public Result<IList<CustomerHomeRentalDto>> GetCustomerHomeRentalByNotRenteds()
        {
            var result = new Result<IList<CustomerHomeRentalDto>>();

            return result;
        }
    }
}
