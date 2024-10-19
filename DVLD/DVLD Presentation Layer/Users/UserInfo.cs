using System;
using DVLD_Business_Layer;
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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        public void LoadFullData(int PersonID, int UserID = 0)
        {
            FillPersonData(PersonID);

            if (UserID > 0)
            {
                FillUserData(UserID);
            }
        }

        public void FillPersonData(int PersonID)
        {
            ctrlPersonInformation1.LaodDataPerson(PersonID);
        }
        public void FillUserData(int UserID)
        {
            clsUsers User = clsUsers.Find(UserID);

            if (User != null)
            {
                ctrUserLoginInfo1.LaodDataUser(UserID);
            }
        }

    }
}
