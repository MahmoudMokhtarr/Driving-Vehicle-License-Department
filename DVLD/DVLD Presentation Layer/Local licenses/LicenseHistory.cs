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
    public partial class LicenseHistory : Form
    {
        private int _PersonID = 0;
        public LicenseHistory(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
            FillFullData();
        }

        public void FillListLocalLicense()
        {
            ctrDriverLicenses1.ListLocalLicense(_PersonID);
            //ctrSearchPeronInfo1.txbSearchByWord.Text = _PersonID.ToString();
            //ctrSearchPeronInfo1.txbSearchByWord.Enabled = false;
            //ctrSearchPeronInfo1.SearchFunctionCall();

        }

        public void FillInternationalLicense()
        {
            ctrDriverLicenses1.ListInternationalLicense(_PersonID);
        }

        public void FillFullData()
        {
            FillListLocalLicense();
            FillInternationalLicense();
        }


    }
}
