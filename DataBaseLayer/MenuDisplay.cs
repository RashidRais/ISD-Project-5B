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
    class MenuDisplay : DbConnection
    {
        static orderMenu menu = orderMenu.getInstance();

        public DataTable display(string category)
        {
            getSqlConnection();
            string query = "select Menu_Id,name as Name,sellprice AS Price from menu where Category like @category";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@category", category);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;

        }

        public void order()
        {
            getSqlConnection();
            string query = "insert into orderfood (orderdate) value(@date);";
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.Parameters.AddWithValue("@date", DateTime.Now);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        public void order1(double total)
        {
            getSqlConnection();
            string query2 = "insert into bill (oid, billtotal) values ((select max(oid) as latestorder from orderfood),@total);";
            MySqlCommand sqlCmd = new MySqlCommand(query2, conn);
            sqlCmd.Parameters.AddWithValue("@total", total.ToString());
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        public void order2(string g1,string g2,string g3)
        {
            getSqlConnection();
            string query3 = "insert into orderdetail (order_id, bid, Menu_Id, Name, qty, price) values ((select max(oid) as latestorder from orderfood),(select max(bid) as latestbill from bill),(select Menu_Id from Menu where name = @Name),@Name,@Qty,@Price);";
           MySqlCommand sqlCmd = new MySqlCommand(query3, conn);
            sqlCmd.Parameters.AddWithValue("@Name", g1);
            sqlCmd.Parameters.AddWithValue("@Qty", g2);
            sqlCmd.Parameters.AddWithValue("@Price", g3);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
