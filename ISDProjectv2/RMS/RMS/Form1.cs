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
    public partial class LoginForm : MaterialForm
    {
        LoginVerify login = new LoginVerify();

        private static LoginForm instance = null;
        public static LoginForm getInstance()
        {
            if(instance == null || instance.IsDisposed)
        {

                instance = new LoginForm();
            }
            return instance;
        }

        private LoginForm()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals(""))
                {
                    MessageBox.Show("empty username");
                }else if (txtPass.Text.Equals(""))
                {
                    MessageBox.Show("empty password");
                }
                else if (login.validate(txtUser.Text, txtPass.Text) == 0)
                {
                    this.Hide();
                    MessageBox.Show("Welcome Admin");
                    Admin admin = new Admin();
                    admin.setMsg(login.getMsg());
                    admin.Show();

                }
                else if (login.validate(txtUser.Text, txtPass.Text) == 1)
                {
                    this.Hide();
                    orderMenu menu = orderMenu.getInstance();
                    MessageBox.Show("Welcome User");
                    menu.Show();

                }
            }
            catch (Exception f)
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
