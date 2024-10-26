using BusinessObjects.Business;
using DataAccess.Dao.AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface ICustomerDao
    {
        Result<IList<CustomerEntity>> GetCustomers();
        Result<CustomerEntity> Save(CustomerEntity customer);
        Result<bool> DeleteCustomerById(Guid id);

    }
}
