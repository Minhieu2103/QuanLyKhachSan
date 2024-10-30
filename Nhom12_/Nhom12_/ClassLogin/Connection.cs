using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12_.ClassLogin
{
    internal class Connection
    {
        private static string stringConnection = "Data Source=ADMIN-PC\\MSSQLSERVER_VIP;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True;";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
