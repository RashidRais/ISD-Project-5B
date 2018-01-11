using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class EditMenuDLL : DbConnection
    {
        public void updateinsertFoof(string btn, string name, string price, string sprice, string type, string cat, int menuId)
        {
            if (btn == "Insert")
            {
                getSqlConnection();
                string query = "insert into menu (Name, price,sellprice,type,category)Values(@name,@price,@sellprice,@type,@category);";
                MySqlCommand sqlCmd = new MySqlCommand(query, conn);
                sqlCmd.Parameters.AddWithValue("@Name", name);
                sqlCmd.Parameters.AddWithValue("@Price", price);
                sqlCmd.Parameters.AddWithValue("@sellPrice", sprice);
                sqlCmd.Parameters.AddWithValue("@Type", type);
                sqlCmd.Parameters.AddWithValue("@Category", cat);
                sqlCmd.ExecuteNonQuery();
                conn.Close();

            }
            else
            {
                getSqlConnection();
                string query = "update menu set Name=@name, price=@price,sellprice=@Sprice,type=@type,category=@category where menu_id= @menuid";
                MySqlCommand sqlCmd = new MySqlCommand(query, conn);
                sqlCmd.Parameters.AddWithValue("@menuid", menuId);
                sqlCmd.Parameters.AddWithValue("@Name", name);
                sqlCmd.Parameters.AddWithValue("@Price", price);
                sqlCmd.Parameters.AddWithValue("@Sprice", sprice);
                sqlCmd.Parameters.AddWithValue("@Type", type);
                sqlCmd.Parameters.AddWithValue("@Category", cat);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                throw new Exception("Updated successfully");
            }
        }
        public void delete(int menuId)
        {
            getSqlConnection();
            string query = "delete from menu where menu_id= @menuid";
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.Parameters.AddWithValue("@menuid", menuId);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable search(string search)
        {
            getSqlConnection();
            //"select * from tbl_Employee where FirstName like '"+txt_SearchName.Text+"%'  "
            string query = "select * from menu where name like '" + search + "%';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            //adapter.SelectCommand.Parameters.AddWithValue("@name",txtSearch.Text);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;

        }
        public DataTable view()
        {
            getSqlConnection();
            string query = "select * from menu ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}
