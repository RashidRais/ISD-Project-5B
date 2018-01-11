using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class ViewSalesDLL:DbConnection
    {
        public DataTable view()
        {
            getSqlConnection();
            string query = "select * from bill ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
