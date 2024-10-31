using Dapper;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Systems
{
    public class DatabaseDao : IDatabaseDao
    {
        public Result<bool> CreateDatabase(string serverName, string databaseName, string userName, string password)
        {
            var result = new Result<bool>();

            try
            {
                // Connection string đến SQL Server, không cần tên database
                var connectionString = $"Server={serverName};Integrated Security=true;";

                // Tên database cần tạo
                if (string.IsNullOrEmpty(databaseName))
                {
                    databaseName = "HomeRentals";
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra database có tồn tại không, nếu chưa thì tạo mới
                    var checkDatabaseQuery = $"IF DB_ID('{databaseName}') IS NULL CREATE DATABASE [{databaseName}]";
                    connection.Execute(checkDatabaseQuery);

                    connection.Close();
                    connection.Dispose();
                }

                connectionString = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = False; User ID = {2}; Password = {3}", serverName, databaseName, userName, password);
                using (var connection = new SqlConnection(connectionString))
                {
                    // Tạo bảng
                    var path = string.Format(@"{0}{1}{2}{3}", AppDomain.CurrentDomain.BaseDirectory, @"Documents", @"\SQL", @"\Table");
                    var sqlFiles = Directory.GetFiles(path, "*.sql");
                    if (sqlFiles != null && sqlFiles.Count() > 0)
                    {
                        foreach (var sqlFile in sqlFiles)
                        {
                            // Đọc nội dung file SQL
                            var sqlScript = File.ReadAllText(sqlFile);

                            var sqlStatements = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                            foreach (var statement in sqlStatements)
                            {
                                if (!string.IsNullOrWhiteSpace(statement))
                                {
                                    // Thực thi câu lệnh SQL
                                    connection.Execute(statement);
                                }
                            }
                        }
                    }

                    // Tạo StoredProcedures
                    path = string.Format(@"{0}{1}{2}{3}", AppDomain.CurrentDomain.BaseDirectory, @"\Documents", @"\SQL", @"\StoredProcedures");
                    sqlFiles = Directory.GetFiles(path, "*.sql");
                    if (sqlFiles != null && sqlFiles.Count() > 0)
                    {
                        foreach (var sqlFile in sqlFiles)
                        {
                            // Đọc nội dung file SQL
                            var sqlScript = File.ReadAllText(sqlFile);
                            var sqlStatements = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                            foreach (var statement in sqlStatements)
                            {
                                if (!string.IsNullOrWhiteSpace(statement))
                                {
                                    // Thực thi câu lệnh SQL
                                    connection.Execute(statement);
                                }
                            }
                        }
                    }

                    // Tạo dữ liệu cho bảng người dùng đầu tiên Admin
                    path = string.Format(@"{0}{1}{2}{3}", AppDomain.CurrentDomain.BaseDirectory, @"\Documents", @"\SQL", @"\Datas");
                    sqlFiles = Directory.GetFiles(path, "*.sql");
                    if (sqlFiles != null && sqlFiles.Count() > 0)
                    {
                        foreach (var sqlFile in sqlFiles)
                        {
                            // Đọc nội dung file SQL
                            var sqlScript = File.ReadAllText(sqlFile);
                            var sqlStatements = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                            foreach (var statement in sqlStatements)
                            {
                                if (!string.IsNullOrWhiteSpace(statement))
                                {
                                    // Thực thi câu lệnh SQL
                                    connection.Execute(statement);
                                }
                            }
                        }
                    }

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

        public Result<bool> RestoreDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            var result = new Result<bool>();

            try
            {
                string connectionString = $"Server={server};Database=master;User Id={userName};Password={password};";

                //var restoreQuery = $@"
                //    USE master;
                //    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                //    RESTORE DATABASE [{databaseName}] FROM DISK = N'{backupFilePath}' WITH REPLACE;
                //    ALTER DATABASE [{databaseName}] SET MULTI_USER; ";

                //using (var connection = new SqlConnection(connectionString))
                //{
                //    connection.Open();
                //    connection.Execute(restoreQuery);
                //    connection.Close();
                //    connection.Dispose();
                //}

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    connection.Execute("USE master");
                    connection.Execute("ALTER DATABASE " + databaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    connection.Execute("RESTORE DATABASE " + databaseName + " FROM DISK = '" + backupFilePath + "' WITH  RECOVERY");
                    connection.Execute("ALTER DATABASE " + databaseName + " SET MULTI_USER");

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

                //var backupQuery = $@"
                //    BACKUP DATABASE [{databaseName}] 
                //    TO DISK = N'{backupFilePath}' 
                //    WITH FORMAT, 
                //    MEDIANAME = 'SQLServerBackups', 
                //    NAME = '{databaseNameSave}';";

                //using (var connection = new SqlConnection(connectionString))
                //{
                //    connection.Open();
                //    connection.Execute(backupQuery);
                //    connection.Close();
                //    connection.Dispose();
                //}

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    connection.Execute("USE master");
                    connection.Execute("ALTER DATABASE " + databaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    connection.Execute("BACKUP DATABASE " + databaseName + " TO DISK = '" + backupFilePath + "'");
                    connection.Execute("ALTER DATABASE " + databaseName + " SET MULTI_USER");

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
