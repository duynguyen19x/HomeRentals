﻿using BusinessObjects.Business;
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

        public Result<UserModel> Save(UserModel user)
        {
            var userEntity = ObjectMapper.Map<UserEntity>(user);
            var resultSave = Factory.UserDao.Save(userEntity);

            return new Result<UserModel>()
            {
                Success = resultSave.Success,
                Message = resultSave.Message,
                Items = ObjectMapper.Map<UserModel>(resultSave.Items)
            };
        }

        public Result<UserModel> GetUserById(Guid id)
        {
            var result = Factory.UserDao.GetUserById(id);

            return new Result<UserModel>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<UserModel>(result.Items)
            };
        }
    }
}