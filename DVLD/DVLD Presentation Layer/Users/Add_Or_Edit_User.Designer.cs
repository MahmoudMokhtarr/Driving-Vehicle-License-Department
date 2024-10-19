namespace DVLD
{
    partial class Add_Or_Edit_User
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
            this.txbSearchByWord = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobFilterPeople = new System.Windows.Forms.ComboBox();
            this.lblModeUserNow = new System.Windows.Forms.Label();
            this.TcUserInfo = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonInformation1 = new DVLD.ctrlPersonInformation();
            this.btnSearchForUser = new System.Windows.Forms.Button();
            this.LoginInfo = new System.Windows.Forms.TabPage();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.rbIsActive = new System.Windows.Forms.CheckBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lblUserIDUser = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnSaveDate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TcUserInfo.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(18, 70);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 10;
            this.txbSearchByWord.Text = "";
            this.txbSearchByWord.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter By : ";
            // 
            // cobFilterPeople
            // 
            this.cobFilterPeople.FormattingEnabled = true;
            this.cobFilterPeople.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
            this.cobFilterPeople.Location = new System.Drawing.Point(138, 25);
            this.cobFilterPeople.Name = "cobFilterPeople";
            this.cobFilterPeople.Size = new System.Drawing.Size(136, 24);
            this.cobFilterPeople.TabIndex = 8;
            this.cobFilterPeople.SelectedValueChanged += new System.EventHandler(this.cobFilterPeople_SelectedValueChanged);
            // 
            // lblModeUserNow
            // 
            this.lblModeUserNow.AutoSize = true;
            this.lblModeUserNow.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblModeUserNow.Location = new System.Drawing.Point(314, 19);
            this.lblModeUserNow.Name = "lblModeUserNow";
            this.lblModeUserNow.Size = new System.Drawing.Size(243, 38);
            this.lblModeUserNow.TabIndex = 11;
            this.lblModeUserNow.Text = "Add New User";
            // 
            // TcUserInfo
            // 
            this.TcUserInfo.Controls.Add(this.PersonInfo);
            this.TcUserInfo.Controls.Add(this.LoginInfo);
            this.TcUserInfo.Location = new System.Drawing.Point(12, 60);
            this.TcUserInfo.Name = "TcUserInfo";
            this.TcUserInfo.SelectedIndex = 0;
            this.TcUserInfo.Size = new System.Drawing.Size(784, 591);
            this.TcUserInfo.TabIndex = 12;
            // 
            // PersonInfo
            // 
            this.PersonInfo.Controls.Add(this.btnAddPerson);
            this.PersonInfo.Controls.Add(this.btnNext);
            this.PersonInfo.Controls.Add(this.ctrlPersonInformation1);
            this.PersonInfo.Controls.Add(this.btnSearchForUser);
            this.PersonInfo.Controls.Add(this.txbSearchByWord);
            this.PersonInfo.Controls.Add(this.cobFilterPeople);
            this.PersonInfo.Controls.Add(this.label2);
            this.PersonInfo.Location = new System.Drawing.Point(4, 25);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfo.Size = new System.Drawing.Size(776, 562);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Person Info";
            this.PersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AutoSize = true;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPerson.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__27_;
            this.btnAddPerson.Location = new System.Drawing.Point(448, 37);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(82, 88);
            this.btnAddPerson.TabIndex = 24;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNext.Image = global::DVLD.Properties.Resources.icNext__3_;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.Location = new System.Drawing.Point(604, 480);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 72);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "                      Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(6, 134);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(744, 439);
            this.ctrlPersonInformation1.TabIndex = 0;
            // 
            // btnSearchForUser
            // 
            this.btnSearchForUser.BackgroundImage = global::DVLD.Properties.Resources.Serch_In_Users;
            this.btnSearchForUser.Location = new System.Drawing.Point(320, 31);
            this.btnSearchForUser.Name = "btnSearchForUser";
            this.btnSearchForUser.Size = new System.Drawing.Size(90, 86);
            this.btnSearchForUser.TabIndex = 2;
            this.btnSearchForUser.UseVisualStyleBackColor = true;
            this.btnSearchForUser.Click += new System.EventHandler(this.btnSearchForUser_Click);
            // 
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.lblIsActive);
            this.LoginInfo.Controls.Add(this.rbIsActive);
            this.LoginInfo.Controls.Add(this.txbConfirmPassword);
            this.LoginInfo.Controls.Add(this.txbPassword);
            this.LoginInfo.Controls.Add(this.txbUserName);
            this.LoginInfo.Controls.Add(this.lblUserIDUser);
            this.LoginInfo.Controls.Add(this.lblConfirmPassword);
            this.LoginInfo.Controls.Add(this.lblPassword);
            this.LoginInfo.Controls.Add(this.lblUserName);
            this.LoginInfo.Controls.Add(this.lblUserID);
            this.LoginInfo.Location = new System.Drawing.Point(4, 25);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfo.Size = new System.Drawing.Size(776, 562);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "Login Info";
            this.LoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Always Find Demo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(37, 332);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(90, 22);
            this.lblIsActive.TabIndex = 21;
            this.lblIsActive.Text = "Is Active";
            // 
            // rbIsActive
            // 
            this.rbIsActive.AutoSize = true;
            this.rbIsActive.Checked = true;
            this.rbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbIsActive.Location = new System.Drawing.Point(345, 332);
            this.rbIsActive.Name = "rbIsActive";
            this.rbIsActive.Size = new System.Drawing.Size(18, 17);
            this.rbIsActive.TabIndex = 20;
            this.rbIsActive.UseVisualStyleBackColor = true;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Location = new System.Drawing.Point(285, 242);
            this.txbConfirmPassword.Multiline = true;
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.PasswordChar = '*';
            this.txbConfirmPassword.Size = new System.Drawing.Size(178, 35);
            this.txbConfirmPassword.TabIndex = 19;
            this.txbConfirmPassword.TextChanged += new System.EventHandler(this.txbConfirmPassword_TextChanged);
            this.txbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbConfirmPassword_Validating);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(285, 168);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(178, 35);
            this.txbPassword.TabIndex = 18;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            this.txbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbPassword_Validating);
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(285, 102);
            this.txbUserName.Multiline = true;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(178, 35);
            this.txbUserName.TabIndex = 17;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            this.txbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txbUserName_Validating);
            // 
            // lblUserIDUser
            // 
            this.lblUserIDUser.AutoSize = true;
            this.lblUserIDUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDUser.Location = new System.Drawing.Point(341, 52);
            this.lblUserIDUser.Name = "lblUserIDUser";
            this.lblUserIDUser.Size = new System.Drawing.Size(22, 24);
            this.lblUserIDUser.TabIndex = 16;
            this.lblUserIDUser.Text = "?";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Always Find Demo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(37, 255);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(192, 22);
            this.lblConfirmPassword.TabIndex = 15;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Always Find Demo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(37, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 22);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Always Find Demo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(37, 115);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 22);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Always Find Demo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(37, 52);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(79, 22);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "User ID";
            // 
            // btnSaveDate
            // 
            this.btnSaveDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveDate.Enabled = false;
            this.btnSaveDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDate.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSaveDate.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__35_;
            this.btnSaveDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveDate.Location = new System.Drawing.Point(575, 664);
            this.btnSaveDate.Name = "btnSaveDate";
            this.btnSaveDate.Size = new System.Drawing.Size(146, 61);
            this.btnSaveDate.TabIndex = 29;
            this.btnSaveDate.Text = "       Save";
            this.btnSaveDate.UseVisualStyleBackColor = false;
            this.btnSaveDate.Click += new System.EventHandler(this.btnSaveDate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(400, 665);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 61);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "     Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Add_Or_Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(841, 738);
            this.Controls.Add(this.btnSaveDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TcUserInfo);
            this.Controls.Add(this.lblModeUserNow);
            this.Name = "Add_Or_Edit_User";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.TcUserInfo.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.PersonInfo.PerformLayout();
            this.LoginInfo.ResumeLayout(false);
            this.LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonInformation ctrlPersonInformation1;
        private System.Windows.Forms.Button btnSearchForUser;
        private System.Windows.Forms.RichTextBox txbSearchByWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobFilterPeople;
        private System.Windows.Forms.Label lblModeUserNow;
        private System.Windows.Forms.TabControl TcUserInfo;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.TabPage LoginInfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblUserIDUser;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.CheckBox rbIsActive;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnAddPerson;
    }
}