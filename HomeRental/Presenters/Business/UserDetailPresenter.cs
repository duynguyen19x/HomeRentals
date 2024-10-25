using HomeRental.IViews.Business.User;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HomeRental.Presenters.Business
{
    public class UserDetailPresenter : BasePresenter<IUserDetailViews>
    {
        IUserService _userService;

        public UserDetailPresenter(IUserDetailViews view) : base(view)
        {
            _userService = new UserService();
        }

        public Result<UserModel> GetUserById(Guid id)
        {
            return _userService.GetUserById(id);
        }

        public Result<UserModel> Save()
        {
            return _userService.Save(new UserModel()
            {
                Id = View.Id,
                FirstName = View.FirstName,
                Address = View.Address,
                DOB = View.DOB,
                Gender = View.Gender,
                LastName = View.LastName,
                Password = View.Password,
                PhoneNumber = View.PhoneNumber,
                UserName = View.UserName
            });
        }
    }
}
