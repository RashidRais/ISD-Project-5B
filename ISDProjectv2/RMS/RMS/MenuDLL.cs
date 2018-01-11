using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class MenuDLL
    {
        MySqlCommand sqlCmd;
        public void orderfood()
        {
            string query = "insert into orderfood (orderdate) value(@date);";
            sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
            sqlCmd.Parameters.AddWithValue("@date", DateTime.Now);
            sqlCmd.ExecuteNonQuery();
        }
        
        public void generateBill(double total)
        {
            string query2 = "insert into bill (oid, billtotal) values ((select max(oid) as latestorder from orderfood),@total);";
            sqlCmd = new MySqlCommand(query2, DbConnection.getSqlConnection());
            sqlCmd.Parameters.AddWithValue("@total", total.ToString());
            sqlCmd.ExecuteNonQuery();
        }

        public void generateOrder(string name, string qty, string price)
        {
            string query3 = "insert into orderdetail (order_id, bid, Menu_Id, Name, qty, price) values ((select max(oid) as latestorder from orderfood),(select max(bid) as latestbill from bill),(select Menu_Id from Menu where name = @Name),@Name,@Qty,@Price);";
            sqlCmd = new MySqlCommand(query3, DbConnection.getSqlConnection());
            sqlCmd.Parameters.AddWithValue("@Name", name);
            sqlCmd.Parameters.AddWithValue("@Qty", qty);
            sqlCmd.Parameters.AddWithValue("@Price", price);
            sqlCmd.ExecuteNonQuery();
        }
    }
}
