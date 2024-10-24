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
    public static class DatabaseHelper
    {
        private static IDbConnection connection;

        public static void CreateConnection(string connectionString)
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(connectionString);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception ex)
            {
                connection = null;
                throw ex;
            }
        }

        // Hàm gọi Stored Procedure không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public static int ExecuteStoredProcedure<T>(string storedProcedureName, T parameters)
        {
            return connection.Execute(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        // Hàm gọi Stored Procedure trả về danh sách dữ liệu
        public static IEnumerable<T> QueryStoredProcedure<T>(string storedProcedureName, object parameters = null)
        {
            return connection.Query<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        // Hàm gọi Stored Procedure trả về một dòng dữ liệu
        public static T QuerySingleStoredProcedure<T>(string storedProcedureName, object parameters = null)
        {
            return connection.QuerySingleOrDefault<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
