using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class orderMenu : MaterialForm
    {
        MenuDisplay menu = new MenuDisplay();
        double total = 0;
        public orderMenu()
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
        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
           gViewMenu.DataSource = menu.display("Starters");
            gViewMenu.Columns[0].Visible = false;

        }

        private void btnVeg_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Vegetable");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnSea_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("SeaFood");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("SideOrders");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnTand_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Tandoori");
            gViewMenu.Columns[0].Visible = false;
        }

        private void btnDess_Click(object sender, EventArgs e)
        {
            gViewMenu.DataSource = menu.display("Dessert");
            gViewMenu.Columns[0].Visible = false;
        }

        private void gViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gViewMenu_DoubleClick(object sender, EventArgs e)
        {
            if (gViewMenu.CurrentRow.Index != -1)
            {
                //menuId = Convert.ToInt32(gViewMenu.CurrentRow.Cells[0].Value.ToString());
                txtName.Text = gViewMenu.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = gViewMenu.CurrentRow.Cells[2].Value.ToString();
                //txtQty.Text = gViewMenu.CurrentRow.Cells[3].Value.ToString();
                
               

            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(txtPrice.Text)* Convert.ToDouble(txtQty.Text);
            NumAmnt.Text = p.ToString();
            
        }

        

        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Equals(string.Empty))
            {
                txtQty.Text = 1.ToString();
            }
            gridBilling.Rows.Add(txtName.Text, txtPrice.Text, txtQty.Text, NumAmnt.Text);
            txtName.Text = txtPrice.Text  = NumAmnt.Text = "";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            total = 0;
            for (int i = 0; i < gridBilling.Rows.Count-1; i++)
            {
                total += Convert.ToDouble(gridBilling.Rows[i].Cells[3].Value.ToString());
            }
            lblTotal.Text = total.ToString();
        }
    }
}
