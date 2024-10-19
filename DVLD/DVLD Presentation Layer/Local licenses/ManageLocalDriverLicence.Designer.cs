namespace DVLD
{
    partial class ManageLocalDriverLicence
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
            this.lblLocalDrivingApplication = new System.Windows.Forms.Label();
            this.DTVLocalDrivingApplication = new System.Windows.Forms.DataGridView();
            this.LDLAppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbSearchByWord = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobFilterLicence = new System.Windows.Forms.ComboBox();
            this.btnAddNewLocalDrivingLicense = new System.Windows.Forms.Button();
            this.ShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.SechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLinse = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTVLocalDrivingApplication)).BeginInit();
            this.MenuApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocalDrivingApplication
            // 
            this.lblLocalDrivingApplication.AutoSize = true;
            this.lblLocalDrivingApplication.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLocalDrivingApplication.Location = new System.Drawing.Point(440, 102);
            this.lblLocalDrivingApplication.Name = "lblLocalDrivingApplication";
            this.lblLocalDrivingApplication.Size = new System.Drawing.Size(556, 38);
            this.lblLocalDrivingApplication.TabIndex = 4;
            this.lblLocalDrivingApplication.Text = "Local Driving License Application";
            // 
            // DTVLocalDrivingApplication
            // 
            this.DTVLocalDrivingApplication.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DTVLocalDrivingApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVLocalDrivingApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LDLAppID,
            this.DrivingClass,
            this.NationalNo,
            this.FullName,
            this.ApplicationDate,
            this.PassedTest,
            this.Status});
            this.DTVLocalDrivingApplication.ContextMenuStrip = this.MenuApplication;
            this.DTVLocalDrivingApplication.Location = new System.Drawing.Point(37, 253);
            this.DTVLocalDrivingApplication.Name = "DTVLocalDrivingApplication";
            this.DTVLocalDrivingApplication.RowHeadersWidth = 51;
            this.DTVLocalDrivingApplication.RowTemplate.Height = 24;
            this.DTVLocalDrivingApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTVLocalDrivingApplication.Size = new System.Drawing.Size(1490, 697);
            this.DTVLocalDrivingApplication.TabIndex = 5;
            this.DTVLocalDrivingApplication.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTVLocalDrivingApplication_CellEnter);
            // 
            // LDLAppID
            // 
            this.LDLAppID.HeaderText = "L.D.L.AppID";
            this.LDLAppID.MinimumWidth = 6;
            this.LDLAppID.Name = "LDLAppID";
            this.LDLAppID.Width = 125;
            // 
            // DrivingClass
            // 
            this.DrivingClass.HeaderText = "Driving Class";
            this.DrivingClass.MinimumWidth = 6;
            this.DrivingClass.Name = "DrivingClass";
            this.DrivingClass.Width = 200;
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 200;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.HeaderText = "Application Date";
            this.ApplicationDate.MinimumWidth = 6;
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.Width = 125;
            // 
            // PassedTest
            // 
            this.PassedTest.HeaderText = "Passed Test";
            this.PassedTest.MinimumWidth = 6;
            this.PassedTest.Name = "PassedTest";
            this.PassedTest.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // MenuApplication
            // 
            this.MenuApplication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowApplicationDetails,
            this.editApplication,
            this.DeleteApplication,
            this.cancelApplication,
            this.SechduleTests,
            this.issueDrivingLicense,
            this.ShowLinse,
            this.showPersonLicenseHistory});
            this.MenuApplication.Name = "MenuApplication";
            this.MenuApplication.Size = new System.Drawing.Size(294, 448);
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(37, 176);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 10;
            this.txbSearchByWord.Text = "";
            this.txbSearchByWord.TextChanged += new System.EventHandler(this.txbSearchByWord_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter By : ";
            // 
            // cobFilterLicence
            // 
            this.cobFilterLicence.FormattingEnabled = true;
            this.cobFilterLicence.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cobFilterLicence.Location = new System.Drawing.Point(150, 120);
            this.cobFilterLicence.Name = "cobFilterLicence";
            this.cobFilterLicence.Size = new System.Drawing.Size(136, 24);
            this.cobFilterLicence.TabIndex = 8;
            // 
            // btnAddNewLocalDrivingLicense
            // 
            this.btnAddNewLocalDrivingLicense.BackgroundImage = global::DVLD.Properties.Resources.Add_New_Licanse;
            this.btnAddNewLocalDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewLocalDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLocalDrivingLicense.Location = new System.Drawing.Point(1124, 70);
            this.btnAddNewLocalDrivingLicense.Name = "btnAddNewLocalDrivingLicense";
            this.btnAddNewLocalDrivingLicense.Size = new System.Drawing.Size(195, 122);
            this.btnAddNewLocalDrivingLicense.TabIndex = 11;
            this.btnAddNewLocalDrivingLicense.UseVisualStyleBackColor = true;
            this.btnAddNewLocalDrivingLicense.Click += new System.EventHandler(this.btnAddNewLocalDrivingLicense_Click);
            // 
            // ShowApplicationDetails
            // 
            this.ShowApplicationDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowApplicationDetails.Image = global::DVLD.Properties.Resources.Application_Edit;
            this.ShowApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowApplicationDetails.Name = "ShowApplicationDetails";
            this.ShowApplicationDetails.Size = new System.Drawing.Size(293, 52);
            this.ShowApplicationDetails.Text = "Show Application Details";
            this.ShowApplicationDetails.Click += new System.EventHandler(this.ShowApplicationDetails_Click);
            // 
            // editApplication
            // 
            this.editApplication.Image = global::DVLD.Properties.Resources.Show_Application_Details;
            this.editApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplication.Name = "editApplication";
            this.editApplication.Size = new System.Drawing.Size(293, 52);
            this.editApplication.Text = "Edit Application";
            this.editApplication.Click += new System.EventHandler(this.editApplication_Click);
            // 
            // DeleteApplication
            // 
            this.DeleteApplication.Image = global::DVLD.Properties.Resources.Delete_Application;
            this.DeleteApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteApplication.Name = "DeleteApplication";
            this.DeleteApplication.Size = new System.Drawing.Size(293, 52);
            this.DeleteApplication.Text = "Delete Application";
            this.DeleteApplication.Click += new System.EventHandler(this.DeleteApplication_Click);
            // 
            // cancelApplication
            // 
            this.cancelApplication.Image = global::DVLD.Properties.Resources.Cancel_Application;
            this.cancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplication.Name = "cancelApplication";
            this.cancelApplication.Size = new System.Drawing.Size(293, 52);
            this.cancelApplication.Text = "Cancel Application";
            this.cancelApplication.Click += new System.EventHandler(this.cancelApplication_Click);
            // 
            // SechduleTests
            // 
            this.SechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScheduleVisionTest,
            this.ScheduleWrittenTest,
            this.ScheduleStreetTest});
            this.SechduleTests.Image = global::DVLD.Properties.Resources.Sechdule_Tests;
            this.SechduleTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SechduleTests.Name = "SechduleTests";
            this.SechduleTests.Size = new System.Drawing.Size(293, 52);
            this.SechduleTests.Text = "Sechdule Tests";
            // 
            // ScheduleVisionTest
            // 
            this.ScheduleVisionTest.Image = global::DVLD.Properties.Resources.Schedule_Vision_Test;
            this.ScheduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleVisionTest.Name = "ScheduleVisionTest";
            this.ScheduleVisionTest.Size = new System.Drawing.Size(260, 52);
            this.ScheduleVisionTest.Text = "Schedule Vision Test";
            this.ScheduleVisionTest.Click += new System.EventHandler(this.ScheduleVisionTest_Click);
            // 
            // ScheduleWrittenTest
            // 
            this.ScheduleWrittenTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScheduleWrittenTest.Image = global::DVLD.Properties.Resources.Written_Test__1_;
            this.ScheduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleWrittenTest.Name = "ScheduleWrittenTest";
            this.ScheduleWrittenTest.Size = new System.Drawing.Size(260, 52);
            this.ScheduleWrittenTest.Text = "Schedule Written Test";
            this.ScheduleWrittenTest.Click += new System.EventHandler(this.ScheduleWrittenTest_Click);
            // 
            // ScheduleStreetTest
            // 
            this.ScheduleStreetTest.Image = global::DVLD.Properties.Resources.Street_Test;
            this.ScheduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleStreetTest.Name = "ScheduleStreetTest";
            this.ScheduleStreetTest.Size = new System.Drawing.Size(260, 52);
            this.ScheduleStreetTest.Text = "Schedule Street Test";
            this.ScheduleStreetTest.Click += new System.EventHandler(this.ScheduleStreetTest_Click);
            // 
            // issueDrivingLicense
            // 
            this.issueDrivingLicense.Image = global::DVLD.Properties.Resources.Issue_Driving_License_;
            this.issueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrivingLicense.Name = "issueDrivingLicense";
            this.issueDrivingLicense.Size = new System.Drawing.Size(293, 52);
            this.issueDrivingLicense.Text = "Issue Driving License ";
            this.issueDrivingLicense.Click += new System.EventHandler(this.issueDrivingLicense_Click);
            // 
            // ShowLinse
            // 
            this.ShowLinse.Image = global::DVLD.Properties.Resources.Show_License;
            this.ShowLinse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLinse.Name = "ShowLinse";
            this.ShowLinse.Size = new System.Drawing.Size(293, 52);
            this.ShowLinse.Text = "Show License";
            this.ShowLinse.Click += new System.EventHandler(this.ShowLinse_Click);
            // 
            // showPersonLicenseHistory
            // 
            this.showPersonLicenseHistory.Image = global::DVLD.Properties.Resources.Show_Person_License_History;
            this.showPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistory.Name = "showPersonLicenseHistory";
            this.showPersonLicenseHistory.Size = new System.Drawing.Size(293, 52);
            this.showPersonLicenseHistory.Text = "Show Person License History";
            this.showPersonLicenseHistory.Click += new System.EventHandler(this.showPersonLicenseHistory_Click);
            // 
            // LocalDriverLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1568, 962);
            this.Controls.Add(this.btnAddNewLocalDrivingLicense);
            this.Controls.Add(this.txbSearchByWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobFilterLicence);
            this.Controls.Add(this.DTVLocalDrivingApplication);
            this.Controls.Add(this.lblLocalDrivingApplication);
            this.Name = "LocalDriverLicence";
            this.Text = "Local Driver Licence";
            this.Load += new System.EventHandler(this.LocalDriverLicence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTVLocalDrivingApplication)).EndInit();
            this.MenuApplication.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalDrivingApplication;
        private System.Windows.Forms.DataGridView DTVLocalDrivingApplication;
        private System.Windows.Forms.ContextMenuStrip MenuApplication;
        private System.Windows.Forms.ToolStripMenuItem ShowApplicationDetails;
        private System.Windows.Forms.ToolStripMenuItem editApplication;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem cancelApplication;
        private System.Windows.Forms.ToolStripMenuItem SechduleTests;
        private System.Windows.Forms.ToolStripMenuItem ScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStreetTest;
        private System.Windows.Forms.RichTextBox txbSearchByWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobFilterLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDLAppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowLinse;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistory;
        private System.Windows.Forms.Button btnAddNewLocalDrivingLicense;
    }
}