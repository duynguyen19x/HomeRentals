using BusinessObjects.Entities.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface ICustomerDao
    {
        Result<IList<CustomerEntity>> GetAlls();
        Result<Guid> Save(CustomerEntity customer);
        Result<bool> DeleteById(Guid id);
        Result<CustomerEntity> GetById(Guid id);
    }
}
