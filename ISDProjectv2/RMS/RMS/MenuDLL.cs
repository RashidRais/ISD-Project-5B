using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class MenuDLL:DbConnection
    {
        MySqlCommand sqlCmd;
        public void orderfood()
        {
            getSqlConnection();
            string query = "insert into orderfood (orderdate) value(@date);";
            sqlCmd = new MySqlCommand(query,conn );
            sqlCmd.Parameters.AddWithValue("@date", DateTime.Now);
            sqlCmd.ExecuteNonQuery();
        }
        
        public void generateBill(double total)
        {
            getSqlConnection();
            string query2 = "insert into bill (oid, billtotal) values ((select max(oid) as latestorder from orderfood),@total);";
            sqlCmd = new MySqlCommand(query2,conn);
            sqlCmd.Parameters.AddWithValue("@total", total.ToString());
            sqlCmd.ExecuteNonQuery();
        }

        public void generateOrder(string name, string qty, string price)
        {
            getSqlConnection();
            string query3 = "insert into orderdetail (order_id, bid, Menu_Id, Name, qty, price) values ((select max(oid) as latestorder from orderfood),(select max(bid) as latestbill from bill),(select Menu_Id from Menu where name = @Name),@Name,@Qty,@Price);";
            sqlCmd = new MySqlCommand(query3,conn);
            sqlCmd.Parameters.AddWithValue("@Name", name);
            sqlCmd.Parameters.AddWithValue("@Qty", qty);
            sqlCmd.Parameters.AddWithValue("@Price", price);
            sqlCmd.ExecuteNonQuery();
        }
    }
}
