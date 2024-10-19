using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;
using DVLD;
using System.Web.UI.WebControls;

namespace DVLD
{
    public partial class PeopleScreen : Form
    {
        private int _PersonID = 0;
        public void ListPerson()
        {
            DataTable Person = clsPeople.GetAllPersonsInfo();

            foreach (DataRow Row in Person.Rows)
            {

                DtView.Rows.Add(Row["PersonID"], Row["NationalNo"], Row["FirstName"], Row["SecondName"], Row["ThirdName"],
                 Row["LastName"], Row["Gendor"], Row["DateOfBirth"], Row["Address"], Row["Phone"], Row["Email"], Row["ImagePath"]);
                
            }
        }

        public PeopleScreen()
        {
            InitializeComponent();
            ListPerson();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
                DVLD.Add_Or_Edit_Person.Mode = DVLD.Add_Or_Edit_Person.enMode.AddNew;

                Add_Or_Edit_Person Frm = new Add_Or_Edit_Person();

            Frm.ShowDialog();
            DtView.Rows.Clear();
            ListPerson();

        }

        private void PeopleScreen_Load(object sender, EventArgs e)
        {
            cobFilterPeople.SelectedIndex = 0;
        }

        private void txbSearchByWord_TextChanged(object sender, EventArgs e)
        {
            
            if (txbSearchByWord.Text == "")
            {
                ListPerson();
                return;
            }

            DataTable Person = clsPeople.SearchByWord(cobFilterPeople.Text, txbSearchByWord.Text);

            if (!Person.HasErrors)
            {
                DtView.Rows.Clear();
            }

            foreach (DataRow Row in Person.Rows)
            {
                DtView.Rows.Clear();
                DtView.Rows.Add(Row["PersonID"], Row["NationalNo"], Row["FirstName"], Row["SecondName"], Row["ThirdName"],
                Row["LastName"], Row["Gendor"], Row["DateOfBirth"], Row["Address"], Row["Phone"], Row["Email"]);
            }

        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            Form Frm = new PersonDetails(int.Parse(DtView.CurrentRow.Cells[0].Value.ToString()));
            Frm.Show();

        }

        public void EditPerson_Click(object sender, EventArgs e)
        {
            DVLD.Add_Or_Edit_Person.Mode = DVLD.Add_Or_Edit_Person.enMode.Update;

            ModeIsUpdete(int.Parse(DtView.CurrentRow.Cells[0].Value.ToString()));

            DtView.Rows.Clear();
            ListPerson();

        }

        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
            DtView.Rows.Clear();
            ListPerson();

        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
           if( clsPeople.DeletePerson(int.Parse(DtView.CurrentRow.Cells[0].Value.ToString())))
            {
                MessageBox.Show("Done Deleted successfully !", "Deleted Person");
                DtView.Rows.Clear();
                ListPerson();
            }
            else
            {
                MessageBox.Show("The Person Was Not Found !");
            }
        }

       public void ModeIsUpdete(int PersonID)
        {
            Add_Or_Edit_Person Frm1 = new Add_Or_Edit_Person(PersonID);
            DVLD.Add_Or_Edit_Person.Mode = DVLD.Add_Or_Edit_Person.enMode.Update;
            Frm1.ModeAddOrEditPersonNow("Edit Person");
            Frm1.ShowDialog();

        }

    }
}
