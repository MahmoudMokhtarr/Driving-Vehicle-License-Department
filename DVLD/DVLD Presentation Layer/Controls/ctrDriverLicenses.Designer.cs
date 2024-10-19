namespace DVLD
{
    partial class ctrDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.International = new System.Windows.Forms.TabControl();
            this.Local = new System.Windows.Forms.TabPage();
            this.DGVLocalLicenseHistory = new System.Windows.Forms.DataGridView();
            this.lblLocalLicenseHistory = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGViLicenseHistory = new System.Windows.Forms.DataGridView();
            this.lblInternationalLicenseHistory = new System.Windows.Forms.Label();
            this.IntLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intLLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.International.SuspendLayout();
            this.Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocalLicenseHistory)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViLicenseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // International
            // 
            this.International.Controls.Add(this.Local);
            this.International.Controls.Add(this.tabPage2);
            this.International.Location = new System.Drawing.Point(3, 3);
            this.International.Name = "International";
            this.International.SelectedIndex = 0;
            this.International.Size = new System.Drawing.Size(1000, 280);
            this.International.TabIndex = 0;
            // 
            // Local
            // 
            this.Local.Controls.Add(this.DGVLocalLicenseHistory);
            this.Local.Controls.Add(this.lblLocalLicenseHistory);
            this.Local.Location = new System.Drawing.Point(4, 25);
            this.Local.Name = "Local";
            this.Local.Padding = new System.Windows.Forms.Padding(3);
            this.Local.Size = new System.Drawing.Size(992, 251);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            // 
            // DGVLocalLicenseHistory
            // 
            this.DGVLocalLicenseHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVLocalLicenseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLocalLicenseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LicID,
            this.AppID,
            this.ClassName,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
            this.DGVLocalLicenseHistory.Location = new System.Drawing.Point(6, 53);
            this.DGVLocalLicenseHistory.Name = "DGVLocalLicenseHistory";
            this.DGVLocalLicenseHistory.RowHeadersWidth = 51;
            this.DGVLocalLicenseHistory.RowTemplate.Height = 24;
            this.DGVLocalLicenseHistory.Size = new System.Drawing.Size(980, 198);
            this.DGVLocalLicenseHistory.TabIndex = 9;
            // 
            // lblLocalLicenseHistory
            // 
            this.lblLocalLicenseHistory.AutoSize = true;
            this.lblLocalLicenseHistory.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLocalLicenseHistory.Location = new System.Drawing.Point(336, 15);
            this.lblLocalLicenseHistory.Name = "lblLocalLicenseHistory";
            this.lblLocalLicenseHistory.Size = new System.Drawing.Size(195, 20);
            this.lblLocalLicenseHistory.TabIndex = 6;
            this.lblLocalLicenseHistory.Text = "Local License History";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGViLicenseHistory);
            this.tabPage2.Controls.Add(this.lblInternationalLicenseHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGViLicenseHistory
            // 
            this.DGViLicenseHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGViLicenseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViLicenseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntLicenseID,
            this.intApplicationID,
            this.intLLicenseID,
            this.intIssueDate,
            this.intExpirationDate,
            this.intIsActive});
            this.DGViLicenseHistory.Location = new System.Drawing.Point(9, 41);
            this.DGViLicenseHistory.Name = "DGViLicenseHistory";
            this.DGViLicenseHistory.RowHeadersWidth = 51;
            this.DGViLicenseHistory.RowTemplate.Height = 24;
            this.DGViLicenseHistory.Size = new System.Drawing.Size(977, 204);
            this.DGViLicenseHistory.TabIndex = 8;
            // 
            // lblInternationalLicenseHistory
            // 
            this.lblInternationalLicenseHistory.AutoSize = true;
            this.lblInternationalLicenseHistory.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblInternationalLicenseHistory.Location = new System.Drawing.Point(322, 18);
            this.lblInternationalLicenseHistory.Name = "lblInternationalLicenseHistory";
            this.lblInternationalLicenseHistory.Size = new System.Drawing.Size(263, 20);
            this.lblInternationalLicenseHistory.TabIndex = 7;
            this.lblInternationalLicenseHistory.Text = "International License History";
            // 
            // IntLicenseID
            // 
            this.IntLicenseID.HeaderText = "Int License ID";
            this.IntLicenseID.MinimumWidth = 6;
            this.IntLicenseID.Name = "IntLicenseID";
            // 
            // intApplicationID
            // 
            this.intApplicationID.HeaderText = "Application ID";
            this.intApplicationID.MinimumWidth = 6;
            this.intApplicationID.Name = "intApplicationID";
            // 
            // intLLicenseID
            // 
            this.intLLicenseID.HeaderText = "L.License ID";
            this.intLLicenseID.MinimumWidth = 6;
            this.intLLicenseID.Name = "intLLicenseID";
            // 
            // intIssueDate
            // 
            this.intIssueDate.HeaderText = "Issue Date";
            this.intIssueDate.MinimumWidth = 6;
            this.intIssueDate.Name = "intIssueDate";
            this.intIssueDate.Width = 125;
            // 
            // intExpirationDate
            // 
            this.intExpirationDate.HeaderText = "Expiration Date";
            this.intExpirationDate.MinimumWidth = 6;
            this.intExpirationDate.Name = "intExpirationDate";
            this.intExpirationDate.Width = 125;
            // 
            // intIsActive
            // 
            this.intIsActive.HeaderText = "Is Active";
            this.intIsActive.MinimumWidth = 6;
            this.intIsActive.Name = "intIsActive";
            this.intIsActive.Width = 125;
            // 
            // LicID
            // 
            this.LicID.HeaderText = "Lic ID";
            this.LicID.MinimumWidth = 6;
            this.LicID.Name = "LicID";
            this.LicID.Width = 70;
            // 
            // AppID
            // 
            this.AppID.HeaderText = "App ID";
            this.AppID.MinimumWidth = 6;
            this.AppID.Name = "AppID";
            this.AppID.Width = 70;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 24;
            // 
            // IssueDate
            // 
            this.IssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.MinimumWidth = 6;
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Width = 24;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Width = 24;
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
            // ctrDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.International);
            this.Name = "ctrDriverLicenses";
            this.Size = new System.Drawing.Size(1006, 301);
            this.International.ResumeLayout(false);
            this.Local.ResumeLayout(false);
            this.Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocalLicenseHistory)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViLicenseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl International;
        private System.Windows.Forms.TabPage Local;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVLocalLicenseHistory;
        private System.Windows.Forms.Label lblLocalLicenseHistory;
        private System.Windows.Forms.DataGridView DGViLicenseHistory;
        private System.Windows.Forms.Label lblInternationalLicenseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn intApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn intLLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn intIsActive;
    }
}
