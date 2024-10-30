using BusinessObjects.Entities.Business;
using BusinessObjects.Entities.Systems;
using Utilities;

namespace DataAccess.IDao.Systems
{
    public interface ILoginDao
    {
        Result<UserEntity> Authentication(LoginEntity login);
        Result<bool> ConnectDatabase(ConnectionEntity connection);
    }
}
