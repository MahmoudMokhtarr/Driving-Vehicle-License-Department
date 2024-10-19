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
    public partial class DriverLicenseInfo : Form
    {
        public string ClassName, FullName, NationalNo;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        public DriverLicenseInfo(string ClassName, string FullName, string NationalNo)
        {
            InitializeComponent();

            this.ClassName = ClassName;
            this.FullName = FullName;
            this.NationalNo = NationalNo;

            ctrDriverLicenseInfo1.LoadData(ClassName, FullName, NationalNo);

        }


    }
}
