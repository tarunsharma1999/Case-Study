using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace Com.Truyum.Dao
{
    public static class Helper
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            }
        }
        public static SqlConnection getConnection()
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            return con;

        }
    }
}
