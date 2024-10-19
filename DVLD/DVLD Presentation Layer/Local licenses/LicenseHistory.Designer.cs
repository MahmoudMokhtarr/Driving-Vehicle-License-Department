namespace DVLD
{
    partial class LicenseHistory
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
            this.lblLicenseHistory = new System.Windows.Forms.Label();
            this.ctrDriverLicenses1 = new DVLD.ctrDriverLicenses();
            this.ctrSearchPeronInfo1 = new DVLD.ctrSearchPeronInfo();
            this.SuspendLayout();
            // 
            // lblLicenseHistory
            // 
            this.lblLicenseHistory.AutoSize = true;
            this.lblLicenseHistory.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLicenseHistory.Location = new System.Drawing.Point(294, 9);
            this.lblLicenseHistory.Name = "lblLicenseHistory";
            this.lblLicenseHistory.Size = new System.Drawing.Size(259, 38);
            this.lblLicenseHistory.TabIndex = 5;
            this.lblLicenseHistory.Text = "License History";
            // 
            // ctrDriverLicenses1
            // 
            this.ctrDriverLicenses1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDriverLicenses1.Location = new System.Drawing.Point(2, 574);
            this.ctrDriverLicenses1.Name = "ctrDriverLicenses1";
            this.ctrDriverLicenses1.Size = new System.Drawing.Size(1021, 286);
            this.ctrDriverLicenses1.TabIndex = 7;
            // 
            // ctrSearchPeronInfo1
            // 
            this.ctrSearchPeronInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrSearchPeronInfo1.Location = new System.Drawing.Point(12, 50);
            this.ctrSearchPeronInfo1.Name = "ctrSearchPeronInfo1";
            this.ctrSearchPeronInfo1.Size = new System.Drawing.Size(843, 541);
            this.ctrSearchPeronInfo1.TabIndex = 6;
            // 
            // LicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1045, 856);
            this.Controls.Add(this.ctrDriverLicenses1);
            this.Controls.Add(this.ctrSearchPeronInfo1);
            this.Controls.Add(this.lblLicenseHistory);
            this.Name = "LicenseHistory";
            this.Text = "LicenseHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLicenseHistory;
        private ctrSearchPeronInfo ctrSearchPeronInfo1;
        private ctrDriverLicenses ctrDriverLicenses1;
    }
}