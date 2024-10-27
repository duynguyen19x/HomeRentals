using BusinessObjects.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface IUserDao
    {
        Result<IList<UserEntity>> GetUsers();
        Result<Guid> Save(UserEntity user);
        Result<UserEntity> GetUserById(Guid id);
        Result<bool> DeleteUserById(Guid id);
    }
}
