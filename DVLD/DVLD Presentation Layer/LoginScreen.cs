using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class LoginScreen : Form
    {

        public static int UserID = 0;
        public static bool IsLogin = false;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Login()
        {
            UserID = DVLD_Business_Layer.clsUsers.GetUserIDByUserName(txbUserName.Text);

            if (UserID == 0 )
            {
                IsLogin = false;
                errorProvider.SetError(txbUserName, "UserName Not Not Found");
                return;
            }

            DVLD_Business_Layer.clsUsers User1 = DVLD_Business_Layer.clsUsers.Find(UserID);

            if (txbUserName.Text == User1.UserName) 
            {
                if (txbPassword.Text == User1.Password) 
                {
                    if (User1.IsActive == true)
                    {
                        txbUserName.Text = null;
                        txbPassword.Text = null;
                        IsLogin = true;
                        GlobalSettings.User = User1;
                        this.Hide();
                        HomeScreen homeScreen = new HomeScreen(this);
                        homeScreen.ShowDialog();
                    }

                }

                else
                {
                    errorProvider.SetError(txbPassword, "Password Not Match");
                }
            }

            else
            {
                errorProvider.SetError(txbUserName, "UserName Not Not Found");

            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }




 

        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.Text = null;

        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Text = null;
            txbPassword.PasswordChar = '*'; 
        }

    }
}
