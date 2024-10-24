using BusinessObjects.Systems;
using HomeRentals.Models.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Systems
{
    public interface ILoginServices
    {
        Result<bool> Authentication(LoginModel login);
        Result<bool> ConnectDatabase(ConnectionModel connection);
    }
}
