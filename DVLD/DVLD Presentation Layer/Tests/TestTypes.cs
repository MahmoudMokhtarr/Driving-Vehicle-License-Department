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
    public partial class TestTypes : Form
    {
        public TestTypes()
        {
            InitializeComponent();
        }

        private void ListTestTypes()
        {
            DataTable TestTypes = DVLD_Business_Layer.clsTestTypes.ReturnTestTypesInfo();

            foreach (DataRow testtypes in TestTypes.Rows)
            {
                dtViewTestTypes.Rows.Add(testtypes["TestTypeID"],
                    testtypes["TestTypeTitle"],
                    testtypes["TestTypeDescription"],
                    testtypes["TestTypeFees"]);
            }
        }

        private void TestTypes_Load(object sender, EventArgs e)
        {
            ListTestTypes();
        }

        private void EditApplicationType_Click(object sender, EventArgs e)
        {
            UpdateTestType updateTestType = new UpdateTestType(int.Parse(dtViewTestTypes.CurrentRow.Cells[0].Value.ToString()));
            updateTestType.ShowDialog();

            dtViewTestTypes.Rows.Clear();
            ListTestTypes();
        }
    }
}
