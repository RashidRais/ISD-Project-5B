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




    }
}


