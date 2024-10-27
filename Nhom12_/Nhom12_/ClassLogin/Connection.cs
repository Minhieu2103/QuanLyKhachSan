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
        private static string stringConnection = "Data Source=NHOM12;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
