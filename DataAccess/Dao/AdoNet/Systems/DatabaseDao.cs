using Dapper;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Systems
{
    public class DatabaseDao : IDatabaseDao
    {
        public Result<bool> RestoreDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            var result = new Result<bool>();

            try
            {
                string connectionString = $"Server={server};Database=master;User Id={userName};Password={password};";

                var restoreQuery = $@"
                    USE master;
                    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE [{databaseName}] FROM DISK = N'{backupFilePath}' WITH REPLACE;
                    ALTER DATABASE [{databaseName}] SET MULTI_USER; ";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Execute(restoreQuery);
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<bool> BackupDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            var result = new Result<bool>();

            try
            {
                var databaseNameSave = databaseName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                string connectionString = $"Server={server};Database=master;User Id={userName};Password={password};";

                var backupQuery = $@"
                    BACKUP DATABASE [{databaseName}] 
                    TO DISK = N'{backupFilePath}' 
                    WITH FORMAT, 
                    MEDIANAME = 'SQLServerBackups', 
                    NAME = '{databaseNameSave}';";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Execute(backupQuery);
                    connection.Close();
                    connection.Dispose();
                }
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
