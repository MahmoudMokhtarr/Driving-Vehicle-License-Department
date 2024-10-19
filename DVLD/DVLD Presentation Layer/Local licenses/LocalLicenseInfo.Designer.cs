namespace DVLD
{
    partial class LocalLicenseInfo
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
            this.ctrDriverLicenseInfo1 = new DVLD.ctrDriverLicenseInfo();
            this.lblMangeDrivers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(28, 74);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(1029, 417);
            this.ctrDriverLicenseInfo1.TabIndex = 0;
            // 
            // lblMangeDrivers
            // 
            this.lblMangeDrivers.AutoSize = true;
            this.lblMangeDrivers.Font = new System.Drawing.Font("Always Find Demo", 17.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMangeDrivers.Location = new System.Drawing.Point(364, 19);
            this.lblMangeDrivers.Name = "lblMangeDrivers";
            this.lblMangeDrivers.Size = new System.Drawing.Size(288, 33);
            this.lblMangeDrivers.TabIndex = 94;
            this.lblMangeDrivers.Text = "Driver License Info";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(906, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 61);
            this.btnClose.TabIndex = 95;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LocalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 567);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMangeDrivers);
            this.Controls.Add(this.ctrDriverLicenseInfo1);
            this.Name = "LocalLicenseInfo";
            this.Text = "LocalLicenseInfo";
            this.Load += new System.EventHandler(this.LocalLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.Label lblMangeDrivers;
        private System.Windows.Forms.Button btnClose;
    }
}