using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UsersScreen : Form
    {

        public UsersScreen()
        {
            InitializeComponent();

        }

        public void ListUsers()
        {
            DataTable User = DVLD_Business_Layer.clsUsers.ListUsers();

            string FullName = "";

            foreach (DataRow UserRow in User.Rows)
            {
                FullName = DVLD_Business_Layer.clsUsers.GetFullNameUser((int)UserRow["PersonID"]);
                DtViewUsers.Rows.Add(UserRow["UserID"], UserRow["PersonID"], FullName, UserRow["UserName"], UserRow["IsActive"]);
            }
        }

        private void UsersScreen_Load(object sender, EventArgs e)
        {
            ListUsers();
        }

        private void ctrSearchInTableUsers1_OneUserSelected(DataTable User)
        {
            if (!User.HasErrors)
            {
                DtViewUsers.Rows.Clear();
            }

            string FullName = "";

            foreach (DataRow UserRow in User.Rows)
            {
                FullName = DVLD_Business_Layer.clsUsers.GetFullNameUser((int)UserRow["PersonID"]);
                DtViewUsers.Rows.Add(UserRow["UserID"], UserRow["PersonID"], FullName, UserRow["UserName"], UserRow["IsActive"]);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            Add_Or_Edit_User FrmAddNewUser = new Add_Or_Edit_User();
            FrmAddNewUser.ShowDialog();
            DtViewUsers.Rows.Clear();
            ListUsers();

        }

        public void ModeIsUpdet(int PersonID , int UserID )
        {
            Add_Or_Edit_User Frm = new Add_Or_Edit_User(PersonID,UserID);
            DVLD.Add_Or_Edit_User.Mode = DVLD.Add_Or_Edit_User.enMode.Update;
            Frm.ModeTitleNow("Edit User");
            Frm.ShowDialog();
        }
        private void ShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(DtViewUsers.CurrentRow.Cells[1].Value.ToString());
            int UserID = int.Parse(DtViewUsers.CurrentRow.Cells[0].Value.ToString());

            UserInfo showDetailsUser = new UserInfo();
            showDetailsUser.LoadFullData( PersonID, UserID);
            showDetailsUser.ShowDialog();

        }
        private void EditUser_Click(object sender, EventArgs e)
        {
            int PersonID = 0, UserID = 0;

            DVLD.Add_Or_Edit_User.Mode = DVLD.Add_Or_Edit_User.enMode.Update;

            PersonID = int.Parse(DtViewUsers.CurrentRow.Cells[1].Value.ToString());
            UserID = int.Parse(DtViewUsers.CurrentRow.Cells[0].Value.ToString());

            ModeIsUpdet(PersonID, UserID);
            DtViewUsers.Rows.Clear();
            ListUsers();

        }
        private void AddNewUser_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {

            int UserID = int.Parse(DtViewUsers.CurrentRow.Cells[0].Value.ToString());

            if( DVLD_Business_Layer.clsUsers.DeleteUser(UserID))
            {
                MessageBox.Show("Delete User Successfully", "Delete User");
            }
            DtViewUsers.Rows.Clear();
            ListUsers();

        }
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword Form = new ChangePassword(int.Parse(DtViewUsers.CurrentRow.Cells[0].Value.ToString()));
            Form.ShowDialog();

        }
    }
}
