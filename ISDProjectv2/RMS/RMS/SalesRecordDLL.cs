using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class SalesRecordDLL
    {
        public DataTable view()
        {
            string query = "Select menu_id,name,sum(qty) as Qty, count(menu_id) as most from OrderDetail group by menu_id order by sum(qty) desc;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getSqlConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
