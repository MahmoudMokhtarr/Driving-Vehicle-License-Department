namespace DVLD
{
    partial class UsersScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtViewUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.picMangeUsers = new System.Windows.Forms.PictureBox();
            this.ctrSearchInTableUsers1 = new DVLD.ctrSearchInTableUsers();
            ((System.ComponentModel.ISupportInitialize)(this.DtViewUsers)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMangeUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mange";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Users";
            // 
            // DtViewUsers
            // 
            this.DtViewUsers.AllowUserToAddRows = false;
            this.DtViewUsers.AllowUserToDeleteRows = false;
            this.DtViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.DtViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.PersonID,
            this.FullName,
            this.UserName,
            this.IsActive});
            this.DtViewUsers.ContextMenuStrip = this.contextMenuStrip;
            this.DtViewUsers.Location = new System.Drawing.Point(133, 316);
            this.DtViewUsers.MultiSelect = false;
            this.DtViewUsers.Name = "DtViewUsers";
            this.DtViewUsers.RowHeadersWidth = 51;
            this.DtViewUsers.RowTemplate.Height = 24;
            this.DtViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtViewUsers.Size = new System.Drawing.Size(950, 376);
            this.DtViewUsers.TabIndex = 4;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.Width = 112;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.MinimumWidth = 6;
            this.PersonID.Name = "PersonID";
            this.PersonID.Width = 112;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 200;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 115;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.Width = 115;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails,
            this.EditUser,
            this.AddNewUser,
            this.DeleteUser,
            this.ChangePassword});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(226, 274);
            this.contextMenuStrip.Text = "Show";
            // 
            // ShowDetails
            // 
            this.ShowDetails.Image = global::DVLD.Properties.Resources.Show_Details;
            this.ShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(225, 54);
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // EditUser
            // 
            this.EditUser.Image = global::DVLD.Properties.Resources.Edit_Person;
            this.EditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(225, 54);
            this.EditUser.Text = "Edit";
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // AddNewUser
            // 
            this.AddNewUser.Image = global::DVLD.Properties.Resources.Add_Person;
            this.AddNewUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(225, 54);
            this.AddNewUser.Text = "Add New User";
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteUser.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(225, 54);
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangePassword.Image = global::DVLD.Properties.Resources.ChangePassword;
            this.ChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(225, 54);
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.BackgroundImage = global::DVLD.Properties.Resources.iconAddUser;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(965, 174);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(118, 104);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // picMangeUsers
            // 
            this.picMangeUsers.BackgroundImage = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__37_;
            this.picMangeUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMangeUsers.Location = new System.Drawing.Point(500, 78);
            this.picMangeUsers.Name = "picMangeUsers";
            this.picMangeUsers.Size = new System.Drawing.Size(263, 222);
            this.picMangeUsers.TabIndex = 0;
            this.picMangeUsers.TabStop = false;
            // 
            // ctrSearchInTableUsers1
            // 
            this.ctrSearchInTableUsers1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrSearchInTableUsers1.Location = new System.Drawing.Point(12, 174);
            this.ctrSearchInTableUsers1.Name = "ctrSearchInTableUsers1";
            this.ctrSearchInTableUsers1.Size = new System.Drawing.Size(397, 111);
            this.ctrSearchInTableUsers1.TabIndex = 7;
            this.ctrSearchInTableUsers1.OneUserSelected += new System.Action<System.Data.DataTable>(this.ctrSearchInTableUsers1_OneUserSelected);
            // 
            // UsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1241, 771);
            this.Controls.Add(this.ctrSearchInTableUsers1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.DtViewUsers);
            this.Controls.Add(this.picMangeUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsersScreen";
            this.Text = "UsersScreen";
            this.Load += new System.EventHandler(this.UsersScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtViewUsers)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMangeUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMangeUsers;
        public System.Windows.Forms.DataGridView DtViewUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.ToolStripMenuItem EditUser;
        private System.Windows.Forms.ToolStripMenuItem AddNewUser;
        private System.Windows.Forms.ToolStripMenuItem DeleteUser;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private ctrSearchInTableUsers ctrSearchInTableUsers1;
    }
}