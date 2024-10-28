using BusinessObjects.Entities.Systems;
using Utilities;

namespace DataAccess.IDao.Systems
{
    public interface ILoginDao
    {
        Result<bool> Authentication(LoginEntity login);
        Result<bool> ConnectDatabase(ConnectionEntity connection);
    }
}
