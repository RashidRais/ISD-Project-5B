using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class EditUserDLL : DbConnection
    {
        public void updateInsertUser(string btn, string name, string pass, string type, int uId)
        {

            
            if (btn == "Insert")
            {
                getSqlConnection();
                string query = "insert into login (uname,password,type)Values(@uname,@pass,@type);";
                MySqlCommand sqlCmd = new MySqlCommand(query, conn);
                sqlCmd.Parameters.AddWithValue("@uname", name);
                sqlCmd.Parameters.AddWithValue("@pass", pass);
                sqlCmd.Parameters.AddWithValue("@type", type);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                getSqlConnection();
                string query = "update login set uname=@uname, password=@pass,type=@type where uid= @uid";
                MySqlCommand sqlCmd = new MySqlCommand(query, conn);
                sqlCmd.Parameters.AddWithValue("@uid", uId);
                sqlCmd.Parameters.AddWithValue("@uname", name);
                sqlCmd.Parameters.AddWithValue("@pass", pass);
                sqlCmd.Parameters.AddWithValue("@type", type);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                throw new Exception("Updated successfully");

            }
        }

        public void deleteUser(int uId)
        {
            getSqlConnection();
            string query = "delete from login where uid = @uid";
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.Parameters.AddWithValue("@uid", uId);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable view()
        {
            getSqlConnection();
            string query = "select * from login ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable search(string search)
        {
            getSqlConnection();
            //"select * from tbl_Employee where FirstName like '"+txt_SearchName.Text+"%'  "
            string query = "select * from login where uname like '" + search + "%';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            //adapter.SelectCommand.Parameters.AddWithValue("@name",txtSearch.Text);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}
