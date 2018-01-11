using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Admin : MaterialForm

    {
        public Admin()
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        
        public void setMsg(string msg)
        {
            lblMsg.Text = msg;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminmenu = new AdminMenu();
            adminmenu.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            LoginForm form = LoginForm.getInstance();
            form.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUser user = new EditUser();
            user.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSales user = new ViewSales();
            user.Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesRecord user = new SalesRecord();
            user.Show();

        }
    }
}
