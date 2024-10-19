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
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        public void ListApplicationTypes()
        {
            DataTable ApplicationType = DVLD_Business_Layer.clsApplicationTypes.ReturnApplicationTypesInfo();

            foreach (DataRow ApplicationTypes in ApplicationType.Rows)
            {
                dtViewApplicationTypes.Rows.Add(ApplicationTypes["ApplicationTypeID"], ApplicationTypes["ApplicationTypeTitle"], ApplicationTypes["ApplicationFees"]);
            }
            
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            ListApplicationTypes();
        }

        private void EditApplicationType_Click(object sender, EventArgs e)
        {
            UpdateApplicationType updateApplicationType = new UpdateApplicationType(int.Parse(dtViewApplicationTypes.CurrentRow.Cells[0].Value.ToString()));
            updateApplicationType.ShowDialog();

            dtViewApplicationTypes.Rows.Clear();
            ListApplicationTypes();
        }
    }
}
