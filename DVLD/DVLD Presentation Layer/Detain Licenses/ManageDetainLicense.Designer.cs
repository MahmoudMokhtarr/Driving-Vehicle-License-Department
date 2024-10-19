namespace DVLD
{
    partial class ManageDetainLicense
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
            this.lblDetainLicenses = new System.Windows.Forms.Label();
            this.DTVManageDetainLicense = new System.Windows.Forms.DataGridView();
            this.MenuDetainLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFormReleaseLicenses = new System.Windows.Forms.PictureBox();
            this.OpenFormDetainLicenses = new System.Windows.Forms.PictureBox();
            this.cobFilterDetainLicense = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSearchByWord = new System.Windows.Forms.RichTextBox();
            this.DetainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReleased = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTVManageDetainLicense)).BeginInit();
            this.MenuDetainLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFormReleaseLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFormDetainLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetainLicenses
            // 
            this.lblDetainLicenses.AutoSize = true;
            this.lblDetainLicenses.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDetainLicenses.Location = new System.Drawing.Point(437, 41);
            this.lblDetainLicenses.Name = "lblDetainLicenses";
            this.lblDetainLicenses.Size = new System.Drawing.Size(473, 47);
            this.lblDetainLicenses.TabIndex = 54;
            this.lblDetainLicenses.Text = "Manage Detain License";
            // 
            // DTVManageDetainLicense
            // 
            this.DTVManageDetainLicense.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DTVManageDetainLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVManageDetainLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetainID,
            this.LicenseID,
            this.DetainDate,
            this.IsReleased,
            this.FineFees,
            this.ReleaseDate,
            this.NationalNo,
            this.FullName,
            this.ReleaseApplicationID});
            this.DTVManageDetainLicense.ContextMenuStrip = this.MenuDetainLicenses;
            this.DTVManageDetainLicense.Location = new System.Drawing.Point(12, 164);
            this.DTVManageDetainLicense.Name = "DTVManageDetainLicense";
            this.DTVManageDetainLicense.RowHeadersWidth = 51;
            this.DTVManageDetainLicense.RowTemplate.Height = 24;
            this.DTVManageDetainLicense.Size = new System.Drawing.Size(1477, 586);
            this.DTVManageDetainLicense.TabIndex = 55;
            this.DTVManageDetainLicense.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTVManageDetainLicense_CellEnter);
            // 
            // MenuDetainLicenses
            // 
            this.MenuDetainLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDetainLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetails,
            this.showLicenseDetails,
            this.showPersonLicenseHistory,
            this.ReleaseDetainedLicenses});
            this.MenuDetainLicenses.Name = "Menu";
            this.MenuDetainLicenses.Size = new System.Drawing.Size(313, 284);
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
            // ReleaseDetainedLicenses
            // 
            this.ReleaseDetainedLicenses.Enabled = false;
            this.ReleaseDetainedLicenses.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__15_;
            this.ReleaseDetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseDetainedLicenses.Name = "ReleaseDetainedLicenses";
            this.ReleaseDetainedLicenses.Size = new System.Drawing.Size(312, 70);
            this.ReleaseDetainedLicenses.Text = "Release Detained Licenses";
            this.ReleaseDetainedLicenses.Click += new System.EventHandler(this.ReleaseDetainedLicenses_Click);
            // 
            // OpenFormReleaseLicenses
            // 
            this.OpenFormReleaseLicenses.BackgroundImage = global::DVLD.Properties.Resources.detain_licenses1;
            this.OpenFormReleaseLicenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFormReleaseLicenses.Location = new System.Drawing.Point(1210, 41);
            this.OpenFormReleaseLicenses.Name = "OpenFormReleaseLicenses";
            this.OpenFormReleaseLicenses.Size = new System.Drawing.Size(106, 95);
            this.OpenFormReleaseLicenses.TabIndex = 57;
            this.OpenFormReleaseLicenses.TabStop = false;
            this.OpenFormReleaseLicenses.Click += new System.EventHandler(this.OpenFormReleaseLicenses_Click);
            // 
            // OpenFormDetainLicenses
            // 
            this.OpenFormDetainLicenses.BackgroundImage = global::DVLD.Properties.Resources.detain_licenses;
            this.OpenFormDetainLicenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFormDetainLicenses.Location = new System.Drawing.Point(1354, 41);
            this.OpenFormDetainLicenses.Name = "OpenFormDetainLicenses";
            this.OpenFormDetainLicenses.Size = new System.Drawing.Size(106, 95);
            this.OpenFormDetainLicenses.TabIndex = 56;
            this.OpenFormDetainLicenses.TabStop = false;
            this.OpenFormDetainLicenses.Click += new System.EventHandler(this.OpenFormDetainLicenses_Click);
            // 
            // cobFilterDetainLicense
            // 
            this.cobFilterDetainLicense.FormattingEnabled = true;
            this.cobFilterDetainLicense.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "IsReleased",
            "NationalNo",
            "FullName",
            "ReleaseApplicationID"});
            this.cobFilterDetainLicense.Location = new System.Drawing.Point(122, 44);
            this.cobFilterDetainLicense.Name = "cobFilterDetainLicense";
            this.cobFilterDetainLicense.Size = new System.Drawing.Size(136, 24);
            this.cobFilterDetainLicense.TabIndex = 58;
            this.cobFilterDetainLicense.SelectedIndexChanged += new System.EventHandler(this.cobFilterDetainLicense_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Filter By : ";
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(13, 80);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 60;
            this.txbSearchByWord.Text = "";
            this.txbSearchByWord.Visible = false;
            this.txbSearchByWord.TextChanged += new System.EventHandler(this.txbSearchByWord_TextChanged);
            // 
            // DetainID
            // 
            this.DetainID.HeaderText = "D ID";
            this.DetainID.MinimumWidth = 6;
            this.DetainID.Name = "DetainID";
            this.DetainID.Width = 90;
            // 
            // LicenseID
            // 
            this.LicenseID.HeaderText = "L ID";
            this.LicenseID.MinimumWidth = 6;
            this.LicenseID.Name = "LicenseID";
            this.LicenseID.Width = 90;
            // 
            // DetainDate
            // 
            this.DetainDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DetainDate.HeaderText = "D Date";
            this.DetainDate.MinimumWidth = 6;
            this.DetainDate.Name = "DetainDate";
            this.DetainDate.Width = 78;
            // 
            // IsReleased
            // 
            this.IsReleased.HeaderText = "IsReleased";
            this.IsReleased.MinimumWidth = 6;
            this.IsReleased.Name = "IsReleased";
            this.IsReleased.Width = 70;
            // 
            // FineFees
            // 
            this.FineFees.HeaderText = "FineFees";
            this.FineFees.MinimumWidth = 6;
            this.FineFees.Name = "FineFees";
            this.FineFees.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FineFees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FineFees.Width = 90;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReleaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ReleaseDate.Width = 125;
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "N No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NationalNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NationalNo.Width = 90;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 94;
            // 
            // ReleaseApplicationID
            // 
            this.ReleaseApplicationID.HeaderText = "ReleaseApp ID";
            this.ReleaseApplicationID.MinimumWidth = 6;
            this.ReleaseApplicationID.Name = "ReleaseApplicationID";
            this.ReleaseApplicationID.Width = 90;
            // 
            // ManageDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1501, 762);
            this.Controls.Add(this.txbSearchByWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cobFilterDetainLicense);
            this.Controls.Add(this.OpenFormReleaseLicenses);
            this.Controls.Add(this.OpenFormDetainLicenses);
            this.Controls.Add(this.DTVManageDetainLicense);
            this.Controls.Add(this.lblDetainLicenses);
            this.Name = "ManageDetainLicense";
            this.Text = "ManageDetainLicense";
            this.Load += new System.EventHandler(this.ManageDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTVManageDetainLicense)).EndInit();
            this.MenuDetainLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenFormReleaseLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFormDetainLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetainLicenses;
        private System.Windows.Forms.DataGridView DTVManageDetainLicense;
        private System.Windows.Forms.ContextMenuStrip MenuDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedLicenses;
        private System.Windows.Forms.PictureBox OpenFormDetainLicenses;
        private System.Windows.Forms.PictureBox OpenFormReleaseLicenses;
        private System.Windows.Forms.ComboBox cobFilterDetainLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txbSearchByWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetainDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseApplicationID;
    }
}