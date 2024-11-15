using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjectionExample
{
    internal interface IDatabaseConnection
    {
        SqlConnection GetConnection();
        SqlCommand CreateCommand(string query, SqlConnection connection);
    }

}
