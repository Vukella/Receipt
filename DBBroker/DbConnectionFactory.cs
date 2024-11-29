using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    internal class DbConnectionFactory
    {
        private static DbConnectionFactory instance;
        private SqlConnection connection;

        private DbConnectionFactory() 
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        }

        internal static DbConnectionFactory Instance
        {
            get
            {
                if (instance == null) instance = new DbConnectionFactory();
                return instance;
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
