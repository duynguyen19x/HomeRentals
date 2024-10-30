using BusinessObjects.Entities.Business;
using BusinessObjects.Entities.Systems;
using HomeRentals.Models.Business;
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

        public Result<UserModel> Authentication(LoginModel login)
        {
            var loginEntity = ObjectMapper.Map<LoginEntity>(login);
            var result = Factory.LoginDao.Authentication(loginEntity);

            return new Result<UserModel>()
            {
                Items = ObjectMapper.Map<UserModel>(result.Items),
                Message = result.Message,
                Success = result.Success,
            };
        }

        public Result<bool> ConnectDatabase(ConnectionModel connection)
        {
            var connectionEntity = ObjectMapper.Map<ConnectionEntity>(connection);
            return Factory.LoginDao.ConnectDatabase(connectionEntity);
        }
    }
}
