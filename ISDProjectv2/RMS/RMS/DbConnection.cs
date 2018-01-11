using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace RMS
{
    class DbConnection
    {

        public static MySqlConnection getSqlConnection()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;Database=RMS;uid=root;pwd=admin;");
            connection.Open();
            return connection;
        }

    }
}
