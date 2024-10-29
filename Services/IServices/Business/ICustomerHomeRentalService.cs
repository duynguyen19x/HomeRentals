using BusinessObjects.Dtos.Business;
using BusinessObjects.Entities.Business;
using HomeRentals.Models.Business;
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
        Result<IList<CustomerHomeRentalModel>> GetAlls(DateTime? fromDate, DateTime? toDate, int rented, Guid? customerHomeRentalCurrentId);
        Result<Guid> Save(CustomerHomeRentalModel customerHomeRental);
        Result<CustomerHomeRentalModel> GetById(Guid id);
        Result<bool> DeleteById(Guid id);
    }
}
