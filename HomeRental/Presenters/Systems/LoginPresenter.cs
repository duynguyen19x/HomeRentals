using HomeRental.IViews.Systems;
using HomeRentals.Models.Systems;
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
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        ILoginServices _loginServer;

        public LoginPresenter(ILoginView view) : base(view)
        {
            _loginServer = new LoginServices();
        }

        public Result<bool> Authentication()
        {
            var login = new LoginModel()
            {
                UserName = View.UserName,
                Password = View.Password,
            };

            return _loginServer.Authentication(login);
        }

        public Result<bool> ConnectDatabase(string serverName, string databaseName, string userName, string password)
        {
            ConnectionModel connection = new ConnectionModel()
            {
                ServerName = serverName,
                DatabaseName = databaseName,
                UserName = userName,
                Password = password
            };

            return _loginServer.ConnectDatabase(connection);
        }
    }
}
