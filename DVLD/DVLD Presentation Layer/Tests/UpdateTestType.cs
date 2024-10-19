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
    public partial class UpdateTestType : Form
    {
        private int _TestTypeID;

        public UpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void _FillApplicationInfo()
        {
            DVLD_Business_Layer.clsTestTypes TestTypes = DVLD_Business_Layer.clsTestTypes.Find(_TestTypeID);

            lbliDForTestType.Text = TestTypes.ID.ToString();
            txbTitel.Text = TestTypes.Title;
            txbDescription.Text = TestTypes.Description;
            txbFees.Text = TestTypes.Fees.ToString();

        }

        private void _UpdateTestType()
        {
            DVLD_Business_Layer.clsTestTypes testTypes = new DVLD_Business_Layer.clsTestTypes();

            testTypes.ID = int.Parse(lbliDForTestType.Text);
            testTypes.Title = txbTitel.Text;
            testTypes.Description = txbDescription.Text;
            testTypes.Fees = decimal.Parse(txbFees.Text);

            if (testTypes.UpdateTestType(int.Parse(lbliDForTestType.Text)))
            {
                MessageBox.Show("Update Test Type Succesefuly", "Update Application");

            }

        }

        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            _FillApplicationInfo();
        }

        private void btnSaveDate_Click(object sender, EventArgs e)
        {
            _UpdateTestType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
