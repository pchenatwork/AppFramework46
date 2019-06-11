using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Framework.Core.DataAccess    
{
    public sealed class SqlConnectionFactory 
    {
        private SqlConnectionFactory()
        {  }

        public static SqlConnectionFactory Instance { get; } = new SqlConnectionFactory();

        public SqlConnection Create(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
