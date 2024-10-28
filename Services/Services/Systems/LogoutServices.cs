using Services.IServices.Business;
using Services.IServices.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.Services.Systems
{
    public class LogoutServices : BaseServices, ILogoutServices
    {
        public Result<bool> CloseConnectDatabase()
        {
            return Factory.LogoutDao.CloseConnectDatabase();
        }
    }
}
