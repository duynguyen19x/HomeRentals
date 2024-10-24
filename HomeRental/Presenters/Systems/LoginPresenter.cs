using HomeRental.IViews.Systems;
using HomeRentals.Models.Systems;
using Services.IServices.Systems;
using Services.Services.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.Presenters.Systems
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        ILoginServices _loginServer;

        public LoginPresenter(ILoginView view) : base(view)
        {
            _loginServer = new LoginServices();
        }

        public void Authentication()
        {
            var login = new LoginModel()
            {
                UserName = Model.UserName,
                Password = Model.Password,
            };

            var ss = _loginServer.Authentication(login);
        }
    }
}
