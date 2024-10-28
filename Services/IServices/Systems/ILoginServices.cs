using HomeRentals.Models.Systems;
using Utilities;

namespace Services.IServices.Systems
{
    public interface ILoginServices
    {
        Result<bool> Authentication(LoginModel login);
        Result<bool> ConnectDatabase(ConnectionModel connection);
    }
}
