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
    public partial class EditUser : MaterialForm
    {
        EditUserDLL eud = new EditUserDLL();
        int uId;
        public EditUser()
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

        private void fillGridView()
        {

            gridUser.DataSource = eud.view();
            gridUser.Columns[0].Visible = false;
        }

        private void gridUser_DoubleClick(object sender, EventArgs e)
        {
            if (gridUser.CurrentRow.Index != -1)
            {
                uId = Convert.ToInt32(gridUser.CurrentRow.Cells[0].Value.ToString());
                txtName.Text = gridUser.CurrentRow.Cells[1].Value.ToString();
                txtPass.Text = gridUser.CurrentRow.Cells[2].Value.ToString();
                txtType.Text = gridUser.CurrentRow.Cells[3].Value.ToString();
                btnInsert.Text = "Update";
                btnDel.Enabled = true;

            }
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    eud.updateInsertUser(btnInsert.Text, txtName.Text, txtPass.Text, txtType.Text, uId);
                    MessageBox.Show("Saved successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                // Reset();
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                eud.deleteUser(uId);
                MessageBox.Show("Deleted successfully");
                //Reset();
                fillGridView();
                txtName.Text = "";
                txtPass.Text = "";
                txtType.Text = "";
                txtSearch.Text = "";
                btnInsert.Text = "Insert";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {

            gridUser.DataSource = eud.search(txtSearch.Text);
            gridUser.Columns[0].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
