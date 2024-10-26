using HomeRental.IViews.Business.User;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.Services.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace HomeRental.Presenters.Business.User
{
    public class UserPresenter : BasePresenter<IUserViews>
    {
        IUserService _userService;

        public UserPresenter(IUserViews view) : base(view)
        {
            _userService = new UserService();
        }

        public Result<IList<UserModel>> GetUsers()
        {
            return _userService.GetUsers();
        }

        public Result<bool> DeleteUserById(Guid id)
        {
            return _userService.DeleteUserById(id);
        }
    }
}
