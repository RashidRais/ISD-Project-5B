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

        private void btnSave_Click(object sender, EventArgs e)
        { 

        }

        private void btnInsert_Click(object sender, EventArgs e)
        { }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }
    }
}
