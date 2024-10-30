using BusinessObjects.Entities.Business;
using BusinessObjects.Entities.Systems;
using DataAccess.IDao.Systems;
using System;
using Utilities;

namespace DataAccess.Dao.AdoNet.Systems
{
    public class LoginDao : ILoginDao
    {
        public Result<UserEntity> Authentication(LoginEntity login)
        {
            var result = new Result<UserEntity>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<UserEntity>("Proc_GetUserByUserNameAndPasswords", login);
                if (result.Items == null)
                {
                    result.Success = false;
                    result.Message = "Tài khoản hoặc mật khẩu không đúng!";
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<bool> ConnectDatabase(ConnectionEntity connection)
        {
            var result = new Result<bool>();

            try
            {
                var connectionString = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = False; User ID = {2}; Password = {3}", connection.ServerName, connection.DatabaseName, connection.UserName, connection.Password);
                DatabaseHelper.CreateConnection(connectionString);
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
