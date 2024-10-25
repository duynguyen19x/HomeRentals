using BusinessObjects.Business;
using DataAccess.IDao.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Business
{
    public class UserDao : IUserDao
    {
        public Result<IList<UserEntity>> GetUsers()
        {
            var result = new Result<IList<UserEntity>>();

            try
            {
                result.Items = DatabaseHelper.QueryStoredProcedure<UserEntity>("Proc_GetUsers").ToList();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<UserEntity> GetUserById(Guid id)
        {
            var result = new Result<UserEntity>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<UserEntity>("Proc_GetUserById");
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<UserEntity> Save(UserEntity user)
        {
            var result = new Result<UserEntity>();

            try
            {
                if (user.Id == null || user.Id == (Guid)default)
                    user.Id = Guid.NewGuid();

                var i = DatabaseHelper.ExecuteStoredProcedure("Proc_CreateOrEditUser", user);
                if (i > 0)
                    result.Items = DatabaseHelper.QuerySingleStoredProcedure<UserEntity>("Proc_GetUserById", new { Id = user.Id });
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }
    }
}
