namespace DVLD
{
    partial class ctrSearchForLicenseInfoByID
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
            this.Filter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbLicenseID = new System.Windows.Forms.TextBox();
            this.lblLicenseHistory = new System.Windows.Forms.Label();
            this.ctrDriverLicenseInfo1 = new DVLD.ctrDriverLicenseInfo();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.btnSearch);
            this.Filter.Controls.Add(this.txbLicenseID);
            this.Filter.Controls.Add(this.lblLicenseHistory);
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(512, 89);
            this.Filter.TabIndex = 10;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.BackgroundImage = global::DVLD.Properties.Resources.Serch_In_Users;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(434, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 50);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbLicenseID
            // 
            this.txbLicenseID.Location = new System.Drawing.Point(135, 39);
            this.txbLicenseID.Multiline = true;
            this.txbLicenseID.Name = "txbLicenseID";
            this.txbLicenseID.Size = new System.Drawing.Size(274, 25);
            this.txbLicenseID.TabIndex = 7;
            // 
            // lblLicenseHistory
            // 
            this.lblLicenseHistory.AutoSize = true;
            this.lblLicenseHistory.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLicenseHistory.Location = new System.Drawing.Point(6, 40);
            this.lblLicenseHistory.Name = "lblLicenseHistory";
            this.lblLicenseHistory.Size = new System.Drawing.Size(104, 20);
            this.lblLicenseHistory.TabIndex = 6;
            this.lblLicenseHistory.Text = "License ID ";
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(3, 98);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(1031, 417);
            this.ctrDriverLicenseInfo1.TabIndex = 11;
            // 
            // ctrSearchForLicenseInfoByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ctrDriverLicenseInfo1);
            this.Controls.Add(this.Filter);
            this.Name = "ctrSearchForLicenseInfoByID";
            this.Size = new System.Drawing.Size(1037, 519);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLicenseHistory;
        public System.Windows.Forms.TextBox txbLicenseID;
    }
}
