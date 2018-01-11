using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace RMS
{
    class LoginVerify : DbConnection
    {
        private string msg;

        public string getMsg()
        {
            return msg;
        }

        public int validate(string uname, string pword)
        {
            getSqlConnection();
            string query = "Select type from login where uname =@uname and password = @pword";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pword", pword);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            
            adapter.Fill(table);
            conn.Close();
            if (table.Rows[0][0].ToString().Equals("admin"))
            {
                //msg = "Welcome Admin";
                //MessageBox.Show("Database connection hogya or value hai");
                return 0;
            }
            else if (table.Rows[0][0].ToString().Equals("user"))
            {
                msg = "Welcome User";
                return 1;
            }
            
            return -1;
        }
    



    }
}
