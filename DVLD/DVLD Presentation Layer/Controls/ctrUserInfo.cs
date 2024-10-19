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
    public partial class ctrUserInfo : UserControl
    {
        public ctrUserInfo()
        {
            InitializeComponent();
        }
        private int _UserID;
        private void ctrUserInfo_Load(object sender, EventArgs e)
        {

        }


        public void LoadDataUser(int UserID)
        {
            _UserID = UserID;
            int PersonID = DVLD_Business_Layer.clsUsers.GetPersonIDUserByUserID(UserID);
            ctrlPersonInformation1.LaodDataPerson(PersonID);

            ctrUserLoginInfo1.LaodDataUser(_UserID);
        }
    }
}
