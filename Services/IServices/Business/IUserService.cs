using BusinessObjects.Business;
using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Business
{
    public interface IUserService
    {
        Result<IList<UserModel>> GetUsers();
        Result<UserModel> Save(UserModel user);
        Result<UserModel> GetUserById(Guid id);
        Result<bool> DeleteUserById(Guid id);
    }
}
