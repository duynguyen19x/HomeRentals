using BusinessObjects.Entities.Systems;
using HomeRentals.Models.Systems;
using Services.IServices.Systems;
using Utilities;

namespace Services.Services.Systems
{
    public class LoginServices : BaseServices, ILoginServices
    {
        public LoginServices()
        {

        }

        public Result<bool> Authentication(LoginModel login)
        {
            var loginEntity = ObjectMapper.Map<LoginEntity>(login);
            return Factory.LoginDao.Authentication(loginEntity);
        }

        public Result<bool> ConnectDatabase(ConnectionModel connection)
        {
            var connectionEntity = ObjectMapper.Map<ConnectionEntity>(connection);
            return Factory.LoginDao.ConnectDatabase(connectionEntity);
        }
    }
}
