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
    public partial class ctrSearchPeronInfo : UserControl
    {
        public int PersonID = 0;

        public ctrSearchPeronInfo()
        {
            InitializeComponent();
            cobFilterPeople.SelectedIndex = 0;
        }
        private void btnSearchForUser_Click(object sender, EventArgs e)
        {
            if (cobFilterPeople.Text == "PersonID")
            {

                ctrlPersonInformation1.LaodDataPerson(int.Parse(txbSearchByWord.Text));
                PersonID = int.Parse(txbSearchByWord.Text);
                return;
            }

            PersonID = DVLD_Business_Layer.clsPeople.GetPersonIDByNationalNo(txbSearchByWord.Text);
            ctrlPersonInformation1.LaodDataPerson(PersonID);

        }
         public void SearchFunctionCall()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            btnSearchForUser_Click(sender, e);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Add_Or_Edit_Person Add_Or_Edit_Person1 = new Add_Or_Edit_Person();
            Add_Or_Edit_Person1.ShowDialog();

            if (txbSearchByWord.Text == "")  
            {
                return;
            }

            txbSearchByWord.Text = Add_Or_Edit_Person1.lblNewPersonID.Text;
            txbSearchByWord.Enabled = false;
            SearchFunctionCall();

        }
    }
}
