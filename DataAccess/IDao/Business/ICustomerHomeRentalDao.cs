using BusinessObjects.Dtos.Business;
using BusinessObjects.Entities.Business;
using DataAccess.Dao.AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface ICustomerHomeRentalDao
    {
        Result<IList<CustomerHomeRentalDto>> GetAlls(DateTime? fromDate, DateTime? toDate, bool isRented);
        Result<CustomerHomeRentalDto> GetById(Guid id);
        Result<Guid> Save(CustomerHomeRentalEntity customerHomeRental);
        Result<bool> DeleteById(Guid id);
    }
}
