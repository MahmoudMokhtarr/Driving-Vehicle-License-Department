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
    public partial class ChangePassword : Form
    {
        private int _UserID;

        public ChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            ctrUserInfo1.LoadDataUser(UserID);

    }

        private bool CheckIsPasswordMatch(Control control)
        {
            if (txbNewPassword.Text != txbConfirmNewPassword.Text)
            {
                errorProvider.SetError(control, " Password IS Not Match ");
            }

            else
            {
                errorProvider.SetError(control, "");

            }


            return true;
        }

        private void txbCurentPassword_TextChanged(object sender, EventArgs e)
        {
            if (DVLD_Business_Layer.clsUsers.GetPasswordUserByUserID(_UserID) != txbCurentPassword.Text)
            {
                errorProvider.SetError(txbCurentPassword, "Password is incorrect");
            }
            else
            {
                errorProvider.SetError(txbCurentPassword, "");

            }

        }

        private void txbNewPassword_TextChanged(object sender, EventArgs e)
        {
            CheckIsPasswordMatch(txbNewPassword);
        }

        private void txbConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            CheckIsPasswordMatch(txbConfirmNewPassword);

        }
        private void btnSaveDate_Click(object sender, EventArgs e)
        {

            if (DVLD_Business_Layer.clsUsers.UpdatePasswordUser(_UserID, int.Parse(txbNewPassword.Text)))
            {
                MessageBox.Show("Change Password Succesfully", "ChangePassword");
            }
        }

    }
}
