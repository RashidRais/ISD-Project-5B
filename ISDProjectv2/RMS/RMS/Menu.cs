using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class orderMenu : MaterialForm
    {
        MenuDLL md = new MenuDLL();
        static int count = 0;
        MenuDisplay menu = new MenuDisplay();
        double total = 0;
        static double totalbill = 0;

        private static orderMenu instance = null;
        public static orderMenu getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new orderMenu();
            }
            return instance;
        }
        private orderMenu()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
               Primary.Indigo400, Primary.Indigo600,
                Primary.Indigo400, Accent.Indigo400,
                TextShade.WHITE
            );

           // listOrder.Visible = false;
        }


        private void gViewMenu_DoubleClick(object sender, EventArgs e)
        {
            if (gViewMenu.CurrentRow.Index != -1)
            {
                //menuId = Convert.ToInt32(gViewMenu.CurrentRow.Cells[0].Value.ToString());
                //txtMenuId.Text = gViewMenu.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = gViewMenu.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = gViewMenu.CurrentRow.Cells[2].Value.ToString();
                //txtQty.Text = gViewMenu.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void gridBilling_DoubleClick(object sender, EventArgs e)
        {
            if (gridBilling.CurrentRow.Index != -1)
            {
                RemoveIndex.Text = "";
                //menuId = Convert.ToInt32(gViewMenu.CurrentRow.Cells[0].Value.ToString());
                //txtMenuId.Text = gViewMenu.CurrentRow.Cells[0].Value.ToString();
                int value = gridBilling.CurrentRow.Index;
                int indexvalue = value+1;
                RemoveIndex.Text = indexvalue.ToString();
                //txtPrice.Text = gViewMenu.CurrentRow.Cells[2].Value.ToString();
                //txtQty.Text = gViewMenu.CurrentRow.Cells[3].Value.ToString();
                
                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //if (txtQty.Text.Equals(string.Empty))
            //{
            //    txtQty.Text = 1.ToString();
            //}
            //double p = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(nupQty.Text);

            try {
                float p = float.Parse(txtPrice.Text) * float.Parse(nupQty.Text);
                NumAmnt.Text = p.ToString();

                gridBilling.Rows.Add(txtName.Text, txtPrice.Text, nupQty.Text, NumAmnt.Text);
                listOrder.Items.Add(txtName.Text.PadRight(30) + ";" + txtPrice.Text.PadRight(20) + ";" + nupQty.Text + ";");
                txtName.Text = txtPrice.Text = NumAmnt.Text = "";
                totalbill += Convert.ToDouble(gridBilling.Rows[count].Cells[3].Value.ToString());
                lblTotal.Text = totalbill.ToString();
                count++;
                nupQty.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            //txtQty.Text = "0";
        }
       

    //    public bool validateCash()
    //    {
    //        int a, b;
    //        if (!String.IsNullOrWhiteSpace(txtCash.Text))
    //        {
    //             a= Convert.ToInt32(txtCash.Text);
    //            b = Convert.ToInt32(lblTotal.Text);
    //            if (!txtCash.Text.All(char.IsDigit))
    //            {
    //                throw new Exception("Contact must be digits only!");
    //                return false;
    //            }
    //           if (a >= b) return true;
    //            return false;       
    //    }
    //        return false;
    //}


        private void btnTotal_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var list = new List<String>();
            //    for (int i = 0; i < gridBilling.Rows.Count - 1; i++)
            //    {
            //        list.Add(gridBilling.Rows[i].Cells[0].Value + "," + gridBilling.Rows[i].Cells[2].Value);
            //    }
            //    Chef chef = new Chef();
            //    chef.Show();
            //    chef.fillOrderTable(list);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
            //int a = int.Parse(txtCash.Text);
            //int b = int.Parse(NumAmnt.Text);
            try
                {
                
                
                    if (gridBilling.Rows.Count != 1)
                    {
                    
                    var list = new List<String>();
                    for (int i = 0; i < gridBilling.Rows.Count - 1; i++)
                    {
                        list.Add(gridBilling.Rows[i].Cells[0].Value + "," + gridBilling.Rows[i].Cells[2].Value);
                    }
                    Chef chef = new Chef();
                    chef.Show();
                    chef.fillOrderTable(list);
                    
                    //if (conditioncheck == 1)
                    //{
                    //    orderconfirm();
                    //}
                    //else
                    //{
                    //    throw new Exception("Invalid Order");
                    //}

                    }
                    else
                    {
                        throw new Exception("Empty Order could not be confirmed");
                    }
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((RemoveIndex.Text) != null|| (RemoveIndex.Text) != "0")
                {
                    totalbill = totalbill - Convert.ToDouble(gridBilling.Rows[((int.Parse(RemoveIndex.Text) - 1))].Cells[3].Value.ToString());
                    gridBilling.Rows.RemoveAt(int.Parse(RemoveIndex.Text) - 1);
                    listOrder.Items.RemoveAt(int.Parse(RemoveIndex.Text) - 1);
                    count--;
                    lblTotal.Text = totalbill.ToString();
                    RemoveIndex.Text = "";
                }else
                {
                    throw new Exception("No Value Entered for Removal");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStr_Click(object sender, EventArgs e)
        {

            gViewMenu.DataSource = menu.display("Fast Food");
            gViewMenu.Columns[0].Visible = false;

        }

        private void btnVegeta_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Chinese");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnSfood_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Rolls");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnSOrder_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Pakistani");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Dessert");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnTandori_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Extras");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = LoginForm.getInstance();
            form.Show();
            this.Close();
        }


        private void txtConfirm_Click(object sender, EventArgs e)
        {
          



}
        public void setChefMsg(string msg, int interval)
        {
            DateTime Time = DateTime.Now.AddMinutes(interval);
            lblChefMsg.Text = msg;
            lblChefMsg.Text = msg + " and will be deilvered by" + Time;
            
        }
        public void orderconfirm()
        {

            md.orderfood();
            //  string query = "insert into orderfood (orderdate) value(@date);";
            //    MySqlCommand sqlCmd = new MySqlCommand(query, DbConnection.getSqlConnection());
            //    sqlCmd.Parameters.AddWithValue("@date", DateTime.Now);
            //   sqlCmd.ExecuteNonQuery();

            total = 0;
            for (int i = 0; i < gridBilling.Rows.Count - 1; i++)
            {
                total += Convert.ToDouble(gridBilling.Rows[i].Cells[3].Value.ToString());
            }

            md.generateBill(total);
            // string query2 = "insert into bill (oid, billtotal) values ((select max(oid) as latestorder from orderfood),@total);";
            // sqlCmd = new MySqlCommand(query2, DbConnection.getSqlConnection());
            // sqlCmd.Parameters.AddWithValue("@total", total.ToString());
            // sqlCmd.ExecuteNonQuery();

            for (int i = 0; i < gridBilling.Rows.Count - 1; i++)
            {
                string name = gridBilling.Rows[i].Cells[0].Value.ToString();
                string qty = gridBilling.Rows[i].Cells[2].Value.ToString();
                string price = gridBilling.Rows[i].Cells[1].Value.ToString();
                md.generateOrder(name, qty, price);
                //string query3 = "insert into orderdetail (order_id, bid, Menu_Id, Name, qty, price) values ((select max(oid) as latestorder from orderfood),(select max(bid) as latestbill from bill),(select Menu_Id from Menu where name = @Name),@Name,@Qty,@Price);";
                //sqlCmd = new MySqlCommand(query3, DbConnection.getSqlConnection());
                //sqlCmd.Parameters.AddWithValue("@Name", gridBilling.Rows[i].Cells[0].Value);
                //sqlCmd.Parameters.AddWithValue("@Qty", gridBilling.Rows[i].Cells[2].Value);
                //sqlCmd.Parameters.AddWithValue("@Price", gridBilling.Rows[i].Cells[1].Value);
                // sqlCmd.ExecuteNonQuery();
            }

            gridBilling.Rows.Clear();

            MessageBox.Show("Order Confirmed");

            lblTotal.Text = "";
            // printData();

            totalbill = 0;
            count = 0;
            listOrder.Items.Clear();
        }

        private void orderMenu_Load(object sender, EventArgs e)
        {

        }
    }

}

