using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class EditMenuDLL
    {
        public void updateinsertFoof(string btn, string name, string price, string sprice, string type, string cat, int menuId)
        {
            if (name.Equals("") || price.Equals("") || sprice.Equals("") || type.Equals("") || cat.Equals("") || menuId.Equals(""))
            {
                throw new Exception("Fill all Fields");
            }

            else if (btn == "Insert")
            {
                string query = "insert into menu (Name, price,sellprice,type,category)Values(@name,@price,@sellprice,@type,@category);";
                MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
                sqlCmd.Parameters.AddWithValue("@Name", name);
                sqlCmd.Parameters.AddWithValue("@Price", price);
                sqlCmd.Parameters.AddWithValue("@sellPrice", sprice);
                sqlCmd.Parameters.AddWithValue("@Type", type);
                sqlCmd.Parameters.AddWithValue("@Category", cat);
                sqlCmd.ExecuteNonQuery();

            }
            else
            {
                string query = "update menu set Name=@name, price=@price,sellprice=@Sprice,type=@type,category=@category where menu_id= @menuid";
                MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
                sqlCmd.Parameters.AddWithValue("@menuid", menuId);
                sqlCmd.Parameters.AddWithValue("@Name", name);
                sqlCmd.Parameters.AddWithValue("@Price", price);
                sqlCmd.Parameters.AddWithValue("@Sprice", sprice);
                sqlCmd.Parameters.AddWithValue("@Type", type);
                sqlCmd.Parameters.AddWithValue("@Category", cat);
                sqlCmd.ExecuteNonQuery();
                throw new Exception("Updated successfully");

            }
        }
        public void delete(int menuId)
        {
            string query = "delete from menu where menu_id= @menuid";
            MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
            sqlCmd.Parameters.AddWithValue("@menuid", menuId);
            sqlCmd.ExecuteNonQuery();
        }
        public DataTable search(string search)
        {
            //"select * from tbl_Employee where FirstName like '"+txt_SearchName.Text+"%'  "
            string query = "select * from menu where name like '" + search + "%';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getSqlConnection());
            //adapter.SelectCommand.Parameters.AddWithValue("@name",txtSearch.Text);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable view()
        {
            string query = "select * from menu ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getSqlConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
