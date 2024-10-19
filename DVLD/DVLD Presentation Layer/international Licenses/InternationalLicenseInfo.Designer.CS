namespace DVLD
{
    partial class InternationalLicenseInfo
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
            this.lblMangeDrivers = new System.Windows.Forms.Label();
            this.ctrInternationalLicenseInfo1 = new DVLD.ctrInternationalLicenseInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMangeDrivers
            // 
            this.lblMangeDrivers.AutoSize = true;
            this.lblMangeDrivers.Font = new System.Drawing.Font("Always Find Demo", 17.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMangeDrivers.Location = new System.Drawing.Point(350, 9);
            this.lblMangeDrivers.Name = "lblMangeDrivers";
            this.lblMangeDrivers.Size = new System.Drawing.Size(481, 33);
            this.lblMangeDrivers.TabIndex = 93;
            this.lblMangeDrivers.Text = "Driver International License Info";
            // 
            // ctrInternationalLicenseInfo1
            // 
            this.ctrInternationalLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrInternationalLicenseInfo1.Location = new System.Drawing.Point(2, 317);
            this.ctrInternationalLicenseInfo1.Name = "ctrInternationalLicenseInfo1";
            this.ctrInternationalLicenseInfo1.Size = new System.Drawing.Size(1271, 350);
            this.ctrInternationalLicenseInfo1.TabIndex = 94;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD.Properties.Resources.icon_Driver_International_License_Info1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(416, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 211);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(1061, 670);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 61);
            this.btnClose.TabIndex = 96;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1275, 744);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrInternationalLicenseInfo1);
            this.Controls.Add(this.lblMangeDrivers);
            this.Name = "InternationalLicenseInfo";
            this.Text = "InternationalLicenseInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMangeDrivers;
        private ctrInternationalLicenseInfo ctrInternationalLicenseInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}