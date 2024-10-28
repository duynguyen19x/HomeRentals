using BusinessObjects.Entities.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface IHomeRentalDao
    {
        Result<IList<HomeRentalEntity>> GetAlls();
        Result<HomeRentalEntity> GetById(Guid id);
        Result<Guid> Save(HomeRentalEntity customer);
        Result<bool> DeleteById(Guid id);
    }
}
