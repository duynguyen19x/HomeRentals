using Utilities;

namespace DataAccess.IDao.Systems
{
    public interface ILogoutDao
    {
        Result<bool> CloseConnectDatabase();
    }
}
