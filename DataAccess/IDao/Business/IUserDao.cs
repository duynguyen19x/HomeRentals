using BusinessObjects.Entities.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface IUserDao
    {
        Result<IList<UserEntity>> GetAlls();
        Result<Guid> Save(UserEntity user);
        Result<UserEntity> GetById(Guid id);
        Result<bool> DeleteById(Guid id);
    }
}
