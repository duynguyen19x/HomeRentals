using Services.IServices.Business;
using Services.IServices.Systems;
using Services.Services.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HomeRental.Presenters.Systems
{

    public class LogoutPresenter
    {
        ILogoutServices _logoutServer;

        public LogoutPresenter()
        {
            _logoutServer = new LogoutServices();
        }

        public Result<bool> CloseConnectDatabase()
        {
            return _logoutServer.CloseConnectDatabase();
        }
    }
}
