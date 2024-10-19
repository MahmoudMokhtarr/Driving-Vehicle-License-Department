namespace DVLD
{
    partial class ManageInternationalLicenseApplication
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
            this.DTVInternationalDrivingApplication = new System.Windows.Forms.DataGridView();
            this.lblinternationalDrivingApplication = new System.Windows.Forms.Label();
            this.btnAddNewLocalDrivingLicense = new System.Windows.Forms.Button();
            this.IntLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuInternationalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTVInternationalDrivingApplication)).BeginInit();
            this.MenuInternationalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTVInternationalDrivingApplication
            // 
            this.DTVInternationalDrivingApplication.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DTVInternationalDrivingApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVInternationalDrivingApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntLicenseID,
            this.ApplicationID,
            this.DriverID,
            this.LLicenseID,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
            this.DTVInternationalDrivingApplication.ContextMenuStrip = this.MenuInternationalLicense;
            this.DTVInternationalDrivingApplication.Location = new System.Drawing.Point(31, 133);
            this.DTVInternationalDrivingApplication.Name = "DTVInternationalDrivingApplication";
            this.DTVInternationalDrivingApplication.RowHeadersWidth = 51;
            this.DTVInternationalDrivingApplication.RowTemplate.Height = 24;
            this.DTVInternationalDrivingApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTVInternationalDrivingApplication.Size = new System.Drawing.Size(1490, 697);
            this.DTVInternationalDrivingApplication.TabIndex = 7;
            // 
            // lblinternationalDrivingApplication
            // 
            this.lblinternationalDrivingApplication.AutoSize = true;
            this.lblinternationalDrivingApplication.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblinternationalDrivingApplication.Location = new System.Drawing.Point(368, 35);
            this.lblinternationalDrivingApplication.Name = "lblinternationalDrivingApplication";
            this.lblinternationalDrivingApplication.Size = new System.Drawing.Size(682, 38);
            this.lblinternationalDrivingApplication.TabIndex = 6;
            this.lblinternationalDrivingApplication.Text = "International Driving License Application";
            // 
            // btnAddNewLocalDrivingLicense
            // 
            this.btnAddNewLocalDrivingLicense.BackgroundImage = global::DVLD.Properties.Resources.Add_New_Licanse;
            this.btnAddNewLocalDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewLocalDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLocalDrivingLicense.Location = new System.Drawing.Point(1214, 5);
            this.btnAddNewLocalDrivingLicense.Name = "btnAddNewLocalDrivingLicense";
            this.btnAddNewLocalDrivingLicense.Size = new System.Drawing.Size(195, 122);
            this.btnAddNewLocalDrivingLicense.TabIndex = 12;
            this.btnAddNewLocalDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // IntLicenseID
            // 
            this.IntLicenseID.HeaderText = "Int License ID";
            this.IntLicenseID.MinimumWidth = 6;
            this.IntLicenseID.Name = "IntLicenseID";
            this.IntLicenseID.Width = 125;
            // 
            // ApplicationID
            // 
            this.ApplicationID.HeaderText = "Application ID";
            this.ApplicationID.MinimumWidth = 6;
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Width = 200;
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.MinimumWidth = 6;
            this.DriverID.Name = "DriverID";
            this.DriverID.Width = 125;
            // 
            // LLicenseID
            // 
            this.LLicenseID.HeaderText = "L License ID";
            this.LLicenseID.MinimumWidth = 6;
            this.LLicenseID.Name = "LLicenseID";
            this.LLicenseID.Width = 200;
            // 
            // IssueDate
            // 
            this.IssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.MinimumWidth = 6;
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Width = 92;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Width = 117;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsActive.Width = 125;
            // 
            // MenuInternationalLicense
            // 
            this.MenuInternationalLicense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetails,
            this.showLicenseDetails,
            this.showPersonLicenseHistory});
            this.MenuInternationalLicense.Name = "Menu";
            this.MenuInternationalLicense.Size = new System.Drawing.Size(313, 242);
            // 
            // showPersonDetails
            // 
            this.showPersonDetails.Image = global::DVLD.Properties.Resources.Show_Application_Details;
            this.showPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetails.Name = "showPersonDetails";
            this.showPersonDetails.Size = new System.Drawing.Size(312, 70);
            this.showPersonDetails.Text = "Show Person Details";
            this.showPersonDetails.Click += new System.EventHandler(this.showPersonDetails_Click);
            // 
            // showLicenseDetails
            // 
            this.showLicenseDetails.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__3_;
            this.showLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetails.Name = "showLicenseDetails";
            this.showLicenseDetails.Size = new System.Drawing.Size(312, 70);
            this.showLicenseDetails.Text = "Show License Details";
            this.showLicenseDetails.Click += new System.EventHandler(this.showLicenseDetails_Click);
            // 
            // showPersonLicenseHistory
            // 
            this.showPersonLicenseHistory.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__7_;
            this.showPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistory.Name = "showPersonLicenseHistory";
            this.showPersonLicenseHistory.Size = new System.Drawing.Size(312, 70);
            this.showPersonLicenseHistory.Text = "Show Person License History";
            this.showPersonLicenseHistory.Click += new System.EventHandler(this.showPersonLicenseHistory_Click);
            // 
            // ManageInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1553, 889);
            this.Controls.Add(this.btnAddNewLocalDrivingLicense);
            this.Controls.Add(this.DTVInternationalDrivingApplication);
            this.Controls.Add(this.lblinternationalDrivingApplication);
            this.Name = "ManageInternationalLicenseApplication";
            this.Text = "ManageInternationalLicenseApplication";
            this.Load += new System.EventHandler(this.ManageInternationalLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTVInternationalDrivingApplication)).EndInit();
            this.MenuInternationalLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTVInternationalDrivingApplication;
        private System.Windows.Forms.Label lblinternationalDrivingApplication;
        private System.Windows.Forms.Button btnAddNewLocalDrivingLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.ContextMenuStrip MenuInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistory;
    }
}