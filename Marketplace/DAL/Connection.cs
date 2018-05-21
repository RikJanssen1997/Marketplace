using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public SqlConnection conn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=marketplaces23.database.windows.net;" +
            "Initial Catalog=Marketplace;" +
            "User id=i345693;" +
            "Password=Blodbeipui8;";

            return conn;
        }
    }
}
