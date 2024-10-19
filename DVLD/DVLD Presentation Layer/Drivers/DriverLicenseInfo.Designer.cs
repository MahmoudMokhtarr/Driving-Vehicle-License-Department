namespace DVLD
{
    partial class DriverLicenseInfo
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
            this.lblLocalDrivingApplication = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(62, 207);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(1029, 530);
            this.ctrDriverLicenseInfo1.TabIndex = 0;
            // 
            // lblLocalDrivingApplication
            // 
            this.lblLocalDrivingApplication.AutoSize = true;
            this.lblLocalDrivingApplication.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLocalDrivingApplication.Location = new System.Drawing.Point(286, 76);
            this.lblLocalDrivingApplication.Name = "lblLocalDrivingApplication";
            this.lblLocalDrivingApplication.Size = new System.Drawing.Size(586, 38);
            this.lblLocalDrivingApplication.TabIndex = 5;
            this.lblLocalDrivingApplication.Text = "Driver                        License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD.Properties.Resources.driver_license_info;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(414, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 224);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(945, 743);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 61);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "     Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DriverLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1108, 811);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLocalDrivingApplication);
            this.Controls.Add(this.ctrDriverLicenseInfo1);
            this.Name = "DriverLicenseInfo";
            this.Text = "DriverLicenseInfo";
            this.Load += new System.EventHandler(this.DriverLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.Label lblLocalDrivingApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}