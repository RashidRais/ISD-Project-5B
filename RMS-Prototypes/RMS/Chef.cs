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
    public partial class Chef : MaterialForm
    {
        public Chef()
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

   
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
