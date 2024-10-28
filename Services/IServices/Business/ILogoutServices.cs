using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Business
{
    public interface ILogoutServices
    {
        Result<bool> CloseConnectDatabase();
    }
}
