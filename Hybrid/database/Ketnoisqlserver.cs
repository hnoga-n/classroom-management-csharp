using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hybrid.DAO
{
    public class Ketnoisqlserver
    {
        private static SqlConnection _connection;
        private static string _connectionString = @"Data Source=DESKTOP-OSKDV3G\SQLEXPRESS;Initial Catalog=hybrid;Integrated Security=True";

        private Ketnoisqlserver() { }

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }
            else
                if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }
            return _connection;
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
