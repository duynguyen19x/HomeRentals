using BusinessObjects.Systems;
using DataAccess.Dao;
using DataAccess.Dao.AdoNet;
using DataAccess.IDao;
using HomeRentals.Models.Systems;
using Services.IServices.Systems;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var loginEntity = new LoginEntity()
            {
                UserName = login.UserName,
                Password = login.Password,
            };

            return Factory.LoginDao.Authentication(loginEntity);
        }

        public Result<bool> ConnectDatabase(ConnectionModel connection)
        {
            var connectionEntity = new ConnectionEntity()
            {
                ServerName = connection.ServerName,
                DatabaseName = connection.DatabaseName,
                UserName = connection.UserName,
                Password = connection.Password,
            };

            return Factory.LoginDao.ConnectDatabase(connectionEntity);
        }
    }
}
