using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD
{
    public partial class ctrUserLoginInfo : UserControl
    {
        public ctrUserLoginInfo()
        {
            InitializeComponent();
        }

        public  void LaodDataUser(int UserID)
        {
            clsUsers User1 = clsUsers.Find(UserID);

            lblUserIDForUser.Text = UserID.ToString();
            lblUserNameForUser.Text = User1.UserName;
            lblModeUserActiveForUser.Text = (User1.IsActive == true) ? lblModeUserActiveForUser.Text = "Yes" : "No";
        }



    }
}
