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

        public void fillOrderTable(List<String> list)
        {

            foreach(var item in list)
            {
                string[] str = item.Split(',');
                gridDisplay.Rows.Add(str[0], str[1]);
            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTime.Text.Equals(""))
                {
                    throw new Exception("empty time field");
                }
                else
                {
                    string msg = "Order Confirmed";
                    int time = int.Parse(txtTime.Text);
                 //   int condition = 1;
                    orderMenu menu = orderMenu.getInstance();
                    menu.setChefMsg(msg, time);
                    menu.orderconfirm();
                    menu.Show();
                    gridDisplay.Rows.Clear();
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message.ToString());
            }
        }

        private void Chef_Load(object sender, EventArgs e)
        {

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Order Declined";
                gridDisplay.Rows.Clear();
                orderMenu menu = orderMenu.getInstance();
                menu.setChefMsgDec(msg);
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message.ToString());
            }
        }
    }
}
