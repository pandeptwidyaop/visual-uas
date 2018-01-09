using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Latihan_UAS
{
    class Connection
    {
        public static SqlConnection Connect;
        private static string connectionAddress;
        
        public static void Open()
        {
            connectionAddress = @"Data Source=JARVIS\SQLEXPRESS;Initial Catalog=RENTAL;User ID=sa;Password=pandeptwidyaop";
            Connect = new SqlConnection(connectionAddress);
            if (Connect.State == System.Data.ConnectionState.Closed)
            {
                Connect.Open();
            }
        }

        public static void Close()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
            {
                Connect.Close();
            }
        }
    }
}
