using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    class MenuDisplay
    {
       static orderMenu menu = orderMenu.getInstance();
        public DataTable display(string category)
        {
                 
            string query = "select Menu_Id,name as Name,sellprice AS Price from menu where Category like @category";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getSqlConnection());
            cmd.Parameters.AddWithValue("@category", category);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            return table;

        }
    }
}
