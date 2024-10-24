using BusinessObjects.Business;
using BusinessObjects.Systems;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.Services.Business
{
    public class UserService : BaseServices, IUserService
    {
        public Result<IList<UserModel>> GetUsers()
        {
            var users = Factory.UserDao.GetUsers();
            return new Result<IList<UserModel>>()
            {
                Items = ObjectMapper.Map<IList<UserModel>>(users.Items)
            };
        }
    }
}
