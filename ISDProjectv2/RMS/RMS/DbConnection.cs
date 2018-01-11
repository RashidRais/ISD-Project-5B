using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace RMS
{
    class DbConnection
    {

        public static MySqlConnection conn;

        public void getSqlConnection()
        {
            conn = new MySqlConnection("server=localhost;Database=RMS;uid=root;");
            conn.Open();
            
        }

    }
}
