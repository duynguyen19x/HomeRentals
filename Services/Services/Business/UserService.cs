using BusinessObjects.Entities.Business;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace Services.Services.Business
{
    public class UserService : BaseServices, IUserService
    {
        public Result<IList<UserModel>> GetAlls()
        {
            var users = Factory.UserDao.GetAlls();
            return new Result<IList<UserModel>>()
            {
                Items = ObjectMapper.Map<IList<UserModel>>(users.Items)
            };
        }

        public Result<Guid> Save(UserModel user)
        {
            var userEntity = ObjectMapper.Map<UserEntity>(user);
            return Factory.UserDao.Save(userEntity);
        }

        public Result<UserModel> GetById(Guid id)
        {
            var result = Factory.UserDao.GetById(id);

            return new Result<UserModel>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<UserModel>(result.Items)
            };
        }

        public Result<bool> DeleteById(Guid id)
        {
            return Factory.UserDao.DeleteById(id);
        }
    }
}
