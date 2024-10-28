using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace Services.IServices.Business
{
    public interface IUserService
    {
        Result<IList<UserModel>> GetAlls();
        Result<Guid> Save(UserModel user);
        Result<UserModel> GetById(Guid id);
        Result<bool> DeleteById(Guid id);
    }
}
