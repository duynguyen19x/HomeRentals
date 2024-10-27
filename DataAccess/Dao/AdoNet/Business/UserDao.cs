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
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<UserEntity>("Proc_GetUserById", new { Id = id });
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<Guid> Save(UserEntity user)
        {
            var result = new Result<Guid>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<Guid>("Proc_CreateOrEditUser", user);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<bool> DeleteUserById(Guid id)
        {
            var result = new Result<bool>();

            try
            {
                result.Success = DatabaseHelper.ExecuteStoredProcedure("Proc_DeleteUserById", new { Id = id }) > 0;
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
