using Insight.Database;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DBConnection
{
    public class DBbase
    {
        static DBbase()
        {
            SqlInsightDbProvider.RegisterProvider();
        }

        public static SqlConnection Connection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection.Database"].ConnectionString;

            SqlConnection conn;

            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return conn;
        }
    }
}
