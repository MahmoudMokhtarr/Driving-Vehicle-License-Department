namespace DVLD
{
    partial class IssueDrivingLicenseFirstTime
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
            this.ctrDrivingApplicationInfo1 = new DVLD.ctrDrivingApplicationInfo();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueDrivingLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrDrivingApplicationInfo1
            // 
            this.ctrDrivingApplicationInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDrivingApplicationInfo1.Location = new System.Drawing.Point(29, 12);
            this.ctrDrivingApplicationInfo1.Name = "ctrDrivingApplicationInfo1";
            this.ctrDrivingApplicationInfo1.Size = new System.Drawing.Size(924, 376);
            this.ctrDrivingApplicationInfo1.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Always Find Demo", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNotes.Location = new System.Drawing.Point(12, 401);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(70, 25);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes";
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(76, 451);
            this.txbNotes.Multiline = true;
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(860, 116);
            this.txbNotes.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(334, 603);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 61);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueDrivingLicense
            // 
            this.btnIssueDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssueDrivingLicense.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIssueDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueDrivingLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueDrivingLicense.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__35_;
            this.btnIssueDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIssueDrivingLicense.Location = new System.Drawing.Point(525, 603);
            this.btnIssueDrivingLicense.Name = "btnIssueDrivingLicense";
            this.btnIssueDrivingLicense.Size = new System.Drawing.Size(146, 61);
            this.btnIssueDrivingLicense.TabIndex = 30;
            this.btnIssueDrivingLicense.Text = "       Issue ";
            this.btnIssueDrivingLicense.UseVisualStyleBackColor = true;
            this.btnIssueDrivingLicense.Click += new System.EventHandler(this.btnIssueDrivingLicense_Click);
            // 
            // IssueDrivingLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(974, 698);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueDrivingLicense);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.ctrDrivingApplicationInfo1);
            this.Name = "IssueDrivingLicenseFirstTime";
            this.Text = "Issue Driving License FirstTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrDrivingApplicationInfo ctrDrivingApplicationInfo1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnIssueDrivingLicense;
    }
}