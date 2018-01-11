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
    public partial class AdminMenu : MaterialForm
    {
        EditMenuDLL emd = new EditMenuDLL();
        MySqlDataAdapter adapter;
        MySqlCommandBuilder builder;
        DataTable table;
        int menuId;
        public AdminMenu()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
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

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                builder = new MySqlCommandBuilder(adapter);
                adapter.Update(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Entry Already Exist in Database");
            }

        }





        private void fillGridView()
        {

            gridMenu.DataSource = emd.view();
            gridMenu.Columns[0].Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    emd.updateinsertFoof(btnInsert.Text, txtName.Text, txtPrice.Text, txtSPrice.Text, txtType.Text, txtCat.Text, menuId);
                    MessageBox.Show("Saved successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                Reset();
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }




        void Reset()
        {
            txtName.Text = txtPrice.Text = txtSPrice.Text = txtType.Text = txtCat.Text = "";
            btnInsert.Text = "Insert";
            menuId = 0;
            btnDel.Enabled = false;
        }
        private void gridMenu_DoubleClick(object sender, EventArgs e)
        {
            if (gridMenu.CurrentRow.Index != -1)
            {
                menuId = Convert.ToInt32(gridMenu.CurrentRow.Cells[0].Value.ToString());
                txtName.Text = gridMenu.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = gridMenu.CurrentRow.Cells[2].Value.ToString();
                txtSPrice.Text = gridMenu.CurrentRow.Cells[3].Value.ToString();
                txtType.Text = gridMenu.CurrentRow.Cells[4].Value.ToString();
                txtCat.Text = gridMenu.CurrentRow.Cells[5].Value.ToString();
                btnInsert.Text = "Update";
                btnDel.Enabled = true;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                emd.delete(menuId);
                MessageBox.Show("Deleted successfully");
                Reset();
                fillGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            gridMenu.DataSource = emd.search(txtSearch.Text);
            gridMenu.Columns[0].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }
    }
}
