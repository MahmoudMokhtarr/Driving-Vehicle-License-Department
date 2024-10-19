namespace DVLD
{
    partial class ShowApplicationDetails
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
            this.lblLocalDrivingApplication = new System.Windows.Forms.Label();
            this.ctrDrivingApplicationInfo1 = new DVLD.ctrDrivingApplicationInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalDrivingApplication
            // 
            this.lblLocalDrivingApplication.AutoSize = true;
            this.lblLocalDrivingApplication.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLocalDrivingApplication.Location = new System.Drawing.Point(297, 23);
            this.lblLocalDrivingApplication.Name = "lblLocalDrivingApplication";
            this.lblLocalDrivingApplication.Size = new System.Drawing.Size(421, 38);
            this.lblLocalDrivingApplication.TabIndex = 5;
            this.lblLocalDrivingApplication.Text = "Show Application Details";
            // 
            // ctrDrivingApplicationInfo1
            // 
            this.ctrDrivingApplicationInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDrivingApplicationInfo1.Location = new System.Drawing.Point(12, 90);
            this.ctrDrivingApplicationInfo1.Name = "ctrDrivingApplicationInfo1";
            this.ctrDrivingApplicationInfo1.Size = new System.Drawing.Size(1024, 376);
            this.ctrDrivingApplicationInfo1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(844, 472);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 61);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1048, 548);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrDrivingApplicationInfo1);
            this.Controls.Add(this.lblLocalDrivingApplication);
            this.Name = "ShowApplicationDetails";
            this.Text = "ShowApplicationDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalDrivingApplication;
        private ctrDrivingApplicationInfo ctrDrivingApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}