using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library_Management.src.configs
{
    class Connectdb
    {
        public static SqlConnection getConn()
        {
            String conStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            return new SqlConnection(conStr);
        }
    }
}
