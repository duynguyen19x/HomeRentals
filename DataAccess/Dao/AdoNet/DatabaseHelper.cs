using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccess.Dao.AdoNet
{
    public class DatabaseHelper
    {
        public class DatabaseHelper
        {
            private readonly string _connectionString;

            private IDbConnection connection;

            public DatabaseHelper(string connectionString)
            {
                _connectionString = connectionString;
            }

            private IDbConnection CreateConnection()
            {
                return new SqlConnection(_connectionString);
            }

            // Hàm gọi Stored Procedure không trả về dữ liệu (INSERT, UPDATE, DELETE)
            public int ExecuteStoredProcedure<T>(string storedProcedureName, T parameters)
            {
                return connection.Execute(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }

            // Hàm gọi Stored Procedure trả về danh sách dữ liệu
            public IEnumerable<T> QueryStoredProcedure<T>(string storedProcedureName, object parameters = null)
            {
                return connection.Query<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }

            // Hàm gọi Stored Procedure trả về một dòng dữ liệu
            public T QuerySingleStoredProcedure<T>(string storedProcedureName, object parameters = null)
            {
                return connection.QuerySingleOrDefault<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
