using BusinessObjects.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface IUserDao
    {
        Result<IList<UserEntity>> GetUsers();
        Result<UserEntity> Save(UserEntity user);
        Result<UserEntity> GetUserById(Guid id);
    }
}
