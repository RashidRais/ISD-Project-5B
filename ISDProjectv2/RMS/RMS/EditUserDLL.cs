using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class EditUserDLL
    {
        public void updateInsertUser(string btn, string name, string pass, string type, int uId)
        {
            if (name == "" || pass == "" || type == "")
            {
                throw new Exception("Fill all Fields");
            }

            else if (btn == "Insert")
            {
                string query = "insert into login (uname,password,type)Values(@uname,@pass,@type);";
                MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
                sqlCmd.Parameters.AddWithValue("@uname", name);
                sqlCmd.Parameters.AddWithValue("@pass", pass);
                sqlCmd.Parameters.AddWithValue("@type", type);
                sqlCmd.ExecuteNonQuery();

            }
            else
            {
                string query = "update login set uname=@uname, password=@pass,type=@type where uid= @uid";
                MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
                sqlCmd.Parameters.AddWithValue("@uid", uId);
                sqlCmd.Parameters.AddWithValue("@uname", name);
                sqlCmd.Parameters.AddWithValue("@pass", pass);
                sqlCmd.Parameters.AddWithValue("@type", type);
                sqlCmd.ExecuteNonQuery();
                throw new Exception("Updated successfully");

            }
        }
        public void deleteUser(int uId)
        {
            if (uId == 0)
            {
                throw new Exception("Select User");
            }
            else
            {
                string query = "delete from login where uid = @uid";
                MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
                sqlCmd.Parameters.AddWithValue("@uid", uId);
                sqlCmd.ExecuteNonQuery();
            }
        }
        public DataTable view()
        {
            string query = "select * from login ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getSqlConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable search(string search)
        {
            //"select * from tbl_Employee where FirstName like '"+txt_SearchName.Text+"%'  "
            string query = "select * from login where uname like '" + search + "%';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getSqlConnection());
            //adapter.SelectCommand.Parameters.AddWithValue("@name",txtSearch.Text);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
