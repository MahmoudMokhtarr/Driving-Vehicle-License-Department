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
    public partial class UpdateApplicationType : Form
    {
        private int _ApplicationID = 0;
        public UpdateApplicationType(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }

        private void _FillApplicationInfo()
        {
            DVLD_Business_Layer.clsApplicationTypes ApplicationType = DVLD_Business_Layer.clsApplicationTypes.Find(_ApplicationID);

            if (ApplicationType != null)
            {
                lbliDForApplication.Text = ApplicationType.ID.ToString();
                txbTitel.Text = ApplicationType.Title;
                txbFees.Text = ApplicationType.Fees.ToString();

            }
        }

        private void _UpdateApplicationType()
        {
            DVLD_Business_Layer.clsApplicationTypes ApplicationTypes = new DVLD_Business_Layer.clsApplicationTypes();

            ApplicationTypes.Title = txbTitel.Text;
            ApplicationTypes.Fees = decimal.Parse(txbFees.Text);

            if (ApplicationTypes.UpdateUser(int.Parse(lbliDForApplication.Text))) 
            {
                MessageBox.Show("Update Application Succesefuly", "Update Application");
            }
        }
        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            _FillApplicationInfo();
        }


        private void btnSaveDate_Click(object sender, EventArgs e)
        {
            _UpdateApplicationType();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
