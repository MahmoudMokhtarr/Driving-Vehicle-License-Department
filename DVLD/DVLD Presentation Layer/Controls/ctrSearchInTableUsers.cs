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
    public partial class ctrSearchInTableUsers : UserControl
    {
        public ctrSearchInTableUsers()
        {
            InitializeComponent();

            cobFilterUsers.SelectedIndex = 0;
            cobActiveUsers.SelectedIndex = 0;

        }

        public event Action<DataTable> OneUserSelected;

        public void ListUsers()
        {
            DataTable User = DVLD_Business_Layer.clsUsers.ListUsers();

            if (OneUserSelected != null)
            {
                OneUserSelected(User);
            }

        }

        private void txbSearchByWord_TextChanged(object sender, EventArgs e)
        {

            if (txbSearchByWord.Text == "")
            {
                ListUsers();
                return;
            }

            DataTable User = DVLD_Business_Layer.clsUsers.SearchByWord(cobFilterUsers.Text, txbSearchByWord.Text);

            if (OneUserSelected != null) 
            {
                OneUserSelected(User);
            }


        }

        private void cobFilterUsers_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cobFilterUsers.SelectedIndex == 0)
            {

                txbSearchByWord.Visible = false;
            }

            else
            {
                txbSearchByWord.Visible = true;
            }

            if (cobFilterUsers.SelectedIndex == 5)
            {
                txbSearchByWord.Visible = false;
                cobActiveUsers.Visible = true;
            }

        }

        private void cobActiveUsers_SelectedValueChanged(object sender, EventArgs e)
        {

            string Value = cobActiveUsers.GetItemText(cobActiveUsers.SelectedItem);

            DataTable Users = DVLD_Business_Layer.clsUsers.GetAListUsersWhereActivityStatus(Value);

            if (OneUserSelected != null)
            {
                OneUserSelected(Users);
            }


        }
    }
}
