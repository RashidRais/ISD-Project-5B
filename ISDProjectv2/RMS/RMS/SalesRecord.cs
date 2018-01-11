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
    public partial class SalesRecord : MaterialForm
    {

        MySqlDataAdapter adapter;
        MySqlCommandBuilder builder;
        DataTable table;
        public SalesRecord()
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
        SalesRecordDLL srd = new SalesRecordDLL();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {

                gvOrderDetail.DataSource = srd.view();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void SalesRecord_Load(object sender, EventArgs e)
        {
            gvOrderDetail.DataSource = srd.view();
        }
    }
}
