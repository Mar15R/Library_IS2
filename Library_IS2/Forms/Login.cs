using Library_IS2.Lib;
using Library_IS2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
            //txt_Username.Text = "andrew.lee";
            //txt_Password.Text = "Passw0rd!20";
            txt_Username.Text = "alice.smith";
            txt_Password.Text = "Passw0rd!1";

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();


            if (userName != "" && password != "")
            {
                Security security = new Security();
                Result<User> user = security.AuthenticateUser(userName, password);
                if (user.IsSuccess)
                {
                    GlobalSettings.Instance.user = user.Data;
                    this.Hide();
                    switch (user.Data.Role)
                    {
                        case "Admin":
                            {
                                AdminMain adminMain = new AdminMain();
                                adminMain.Show();
                                break;
                            }
                        case "User":
                            {
                                UserMain userMain = new UserMain();
                                userMain.Show();
                                break;
                            }
                        default:
                            {
                                UserMain userMain = new UserMain();
                                userMain.Show();
                                break;
                            }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
