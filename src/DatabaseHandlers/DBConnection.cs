using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_and_Maintenance_Management_System.src.DatabaseHandlers
{
    class DBConnection
    {
        private const string source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\AssetManagementSystem.mdf\";Integrated Security=True;Application Name=Asset-and-maintenance-management-system";

        public static SqlConnection establishConnection()
        {
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            return conn;
        }
    }
}
