using HomeRentals.Models.Business;
using HomeRentals.Models.Systems;
using Utilities;

namespace Services.IServices.Systems
{
    public interface ILoginServices
    {
        Result<UserModel> Authentication(LoginModel login);
        Result<bool> ConnectDatabase(ConnectionModel connection);
    }
}
