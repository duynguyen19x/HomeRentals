using HomeRental.IViews.Systems;
using HomeRentals.Models.Systems;
using Services;
using Services.IServices.Systems;
using Services.Services.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using Utilities;

namespace HomeRental.Presenters.Systems
{
    public class ConnectionPresenter : BasePresenter<IConnectionView>
    {
        ILoginServices _loginServer;

        public ConnectionPresenter(IConnectionView view) : base(view)
        {
            _loginServer = new LoginServices();
        }

        public Result<bool> ConnectDatabase()
        {
            ConnectionModel connection = new ConnectionModel()
            {
                DatabaseName = View.DatabaseName,
                ServerName = View.ServerName,
                UserName = View.UserName,
                Password = View.Password
            };

            return _loginServer.ConnectDatabase(connection);
        }
    }
}
