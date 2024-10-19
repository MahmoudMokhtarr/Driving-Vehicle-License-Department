namespace DVLD
{
    partial class PeopleScreen
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
            this.DtView = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManage = new System.Windows.Forms.Label();
            this.cobFilterPeople = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchByWord = new System.Windows.Forms.RichTextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.ManagePeoplePicture = new System.Windows.Forms.PictureBox();
            this.lblPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePeoplePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DtView
            // 
            this.DtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtView.BackgroundColor = System.Drawing.Color.Azure;
            this.DtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.NationalNo,
            this.FirstName,
            this.SecondName,
            this.ThirdName,
            this.LastName,
            this.Gendor,
            this.DateOfBirth,
            this.Nationality,
            this.Phone,
            this.Email,
            this.ImagePath});
            this.DtView.ContextMenuStrip = this.contextMenuStrip1;
            this.DtView.Location = new System.Drawing.Point(-1, 262);
            this.DtView.Name = "DtView";
            this.DtView.ReadOnly = true;
            this.DtView.RowHeadersWidth = 51;
            this.DtView.RowTemplate.Height = 24;
            this.DtView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtView.Size = new System.Drawing.Size(1389, 417);
            this.DtView.TabIndex = 0;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.MinimumWidth = 6;
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "SecondName";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // ThirdName
            // 
            this.ThirdName.HeaderText = "Third Name";
            this.ThirdName.MinimumWidth = 6;
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Gendor
            // 
            this.Gendor.HeaderText = "Gendor";
            this.Gendor.MinimumWidth = 6;
            this.Gendor.Name = "Gendor";
            this.Gendor.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.MinimumWidth = 6;
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // ImagePath
            // 
            this.ImagePath.HeaderText = "ImagePath";
            this.ImagePath.MinimumWidth = 6;
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails,
            this.EditPerson,
            this.AddNewPerson,
            this.DeletePerson});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 220);
            this.contextMenuStrip1.Text = "Show";
            // 
            // ShowDetails
            // 
            this.ShowDetails.Image = global::DVLD.Properties.Resources.Show_Details;
            this.ShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(219, 54);
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // EditPerson
            // 
            this.EditPerson.Image = global::DVLD.Properties.Resources.Edit_Person;
            this.EditPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditPerson.Name = "EditPerson";
            this.EditPerson.Size = new System.Drawing.Size(219, 54);
            this.EditPerson.Text = "Edit Person";
            this.EditPerson.Click += new System.EventHandler(this.EditPerson_Click);
            // 
            // AddNewPerson
            // 
            this.AddNewPerson.Image = global::DVLD.Properties.Resources.Add_Person;
            this.AddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPerson.Name = "AddNewPerson";
            this.AddNewPerson.Size = new System.Drawing.Size(219, 54);
            this.AddNewPerson.Text = "Add New Person";
            this.AddNewPerson.Click += new System.EventHandler(this.AddNewPerson_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePerson.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.DeletePerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeletePerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(219, 54);
            this.DeletePerson.Text = "Delete Person";
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblManage.Location = new System.Drawing.Point(278, 129);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(179, 47);
            this.lblManage.TabIndex = 3;
            this.lblManage.Text = "Manage";
            // 
            // cobFilterPeople
            // 
            this.cobFilterPeople.FormattingEnabled = true;
            this.cobFilterPeople.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cobFilterPeople.Location = new System.Drawing.Point(125, 43);
            this.cobFilterPeople.Name = "cobFilterPeople";
            this.cobFilterPeople.Size = new System.Drawing.Size(136, 24);
            this.cobFilterPeople.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By : ";
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(12, 99);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 7;
            this.txbSearchByWord.Text = "";
            this.txbSearchByWord.TextChanged += new System.EventHandler(this.txbSearchByWord_TextChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__27_;
            this.btnAddUser.Location = new System.Drawing.Point(1241, 62);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(109, 114);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // ManagePeoplePicture
            // 
            this.ManagePeoplePicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManagePeoplePicture.BackgroundImage = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__25_1;
            this.ManagePeoplePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManagePeoplePicture.Location = new System.Drawing.Point(460, 2);
            this.ManagePeoplePicture.Name = "ManagePeoplePicture";
            this.ManagePeoplePicture.Size = new System.Drawing.Size(550, 254);
            this.ManagePeoplePicture.TabIndex = 1;
            this.ManagePeoplePicture.TabStop = false;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPeople.Location = new System.Drawing.Point(1028, 129);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(151, 47);
            this.lblPeople.TabIndex = 8;
            this.lblPeople.Text = "People";
            // 
            // PeopleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1389, 679);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.txbSearchByWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobFilterPeople);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.ManagePeoplePicture);
            this.Controls.Add(this.DtView);
            this.DoubleBuffered = true;
            this.Name = "PeopleScreen";
            this.Text = "PeopleScreen";
            this.Load += new System.EventHandler(this.PeopleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagePeoplePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtView;
        private System.Windows.Forms.PictureBox ManagePeoplePicture;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.ComboBox cobFilterPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txbSearchByWord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.ToolStripMenuItem EditPerson;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem DeletePerson;
        private System.Windows.Forms.Label lblPeople;
    }
}