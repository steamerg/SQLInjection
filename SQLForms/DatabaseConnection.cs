using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjectionExample
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private readonly string _connectionString;
        public SqlConnection Connection { get; private set; }

        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
            Connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public SqlCommand CreateCommand(string query, SqlConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return new SqlCommand(query, connection);
        }
    }
}
