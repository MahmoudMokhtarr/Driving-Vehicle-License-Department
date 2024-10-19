namespace DVLD
{
    partial class DetaineLicence
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
            this.ApplicationInfo = new System.Windows.Forms.GroupBox();
            this.txbApplicationFeesForApp = new System.Windows.Forms.TextBox();
            this.lblLRApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.iconCreatedBy = new System.Windows.Forms.PictureBox();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.iconFees = new System.Windows.Forms.PictureBox();
            this.iconApplicationDate = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLRApplicationIDForApp = new System.Windows.Forms.Label();
            this.lblApplicationDateForApp = new System.Windows.Forms.Label();
            this.iconILLicenseID = new System.Windows.Forms.PictureBox();
            this.iconLicenseID = new System.Windows.Forms.PictureBox();
            this.lblCreatedByForApp = new System.Windows.Forms.Label();
            this.lblReplacedLicenseIDForApp = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrSearchForLicenseInfoByID1 = new DVLD.ctrSearchForLicenseInfoByID();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblShowLicenseinfo = new System.Windows.Forms.LinkLabel();
            this.ApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconILLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetainLicenses
            // 
            this.lblDetainLicenses.AutoSize = true;
            this.lblDetainLicenses.Font = new System.Drawing.Font("Always Find Demo", 17.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDetainLicenses.Location = new System.Drawing.Point(659, 35);
            this.lblDetainLicenses.Name = "lblDetainLicenses";
            this.lblDetainLicenses.Size = new System.Drawing.Size(228, 33);
            this.lblDetainLicenses.TabIndex = 51;
            this.lblDetainLicenses.Text = "Detain Licenses";
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.Controls.Add(this.txbApplicationFeesForApp);
            this.ApplicationInfo.Controls.Add(this.lblLRApplicationID);
            this.ApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.ApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.ApplicationInfo.Controls.Add(this.iconCreatedBy);
            this.ApplicationInfo.Controls.Add(this.lblReplacedLicenseID);
            this.ApplicationInfo.Controls.Add(this.iconFees);
            this.ApplicationInfo.Controls.Add(this.iconApplicationDate);
            this.ApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.ApplicationInfo.Controls.Add(this.lblLRApplicationIDForApp);
            this.ApplicationInfo.Controls.Add(this.lblApplicationDateForApp);
            this.ApplicationInfo.Controls.Add(this.iconILLicenseID);
            this.ApplicationInfo.Controls.Add(this.iconLicenseID);
            this.ApplicationInfo.Controls.Add(this.lblCreatedByForApp);
            this.ApplicationInfo.Controls.Add(this.lblReplacedLicenseIDForApp);
            this.ApplicationInfo.Location = new System.Drawing.Point(12, 527);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Size = new System.Drawing.Size(1037, 183);
            this.ApplicationInfo.TabIndex = 55;
            this.ApplicationInfo.TabStop = false;
            this.ApplicationInfo.Text = "Application Info";
            // 
            // txbApplicationFeesForApp
            // 
            this.txbApplicationFeesForApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApplicationFeesForApp.Location = new System.Drawing.Point(279, 126);
            this.txbApplicationFeesForApp.Multiline = true;
            this.txbApplicationFeesForApp.Name = "txbApplicationFeesForApp";
            this.txbApplicationFeesForApp.Size = new System.Drawing.Size(95, 28);
            this.txbApplicationFeesForApp.TabIndex = 99;
            this.txbApplicationFeesForApp.Validating += new System.ComponentModel.CancelEventHandler(this.txbApplicationFeesForApp_Validating);
            // 
            // lblLRApplicationID
            // 
            this.lblLRApplicationID.AutoSize = true;
            this.lblLRApplicationID.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLRApplicationID.Location = new System.Drawing.Point(24, 33);
            this.lblLRApplicationID.Name = "lblLRApplicationID";
            this.lblLRApplicationID.Size = new System.Drawing.Size(92, 20);
            this.lblLRApplicationID.TabIndex = 11;
            this.lblLRApplicationID.Text = "Detain ID";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblApplicationDate.Location = new System.Drawing.Point(22, 80);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(113, 20);
            this.lblApplicationDate.TabIndex = 12;
            this.lblApplicationDate.Text = "Detain Date";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblApplicationFees.Location = new System.Drawing.Point(22, 126);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(89, 20);
            this.lblApplicationFees.TabIndex = 14;
            this.lblApplicationFees.Text = "Fine Fees";
            // 
            // iconCreatedBy
            // 
            this.iconCreatedBy.BackgroundImage = global::DVLD.Properties.Resources.Cretated_By;
            this.iconCreatedBy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconCreatedBy.Location = new System.Drawing.Point(765, 81);
            this.iconCreatedBy.Name = "iconCreatedBy";
            this.iconCreatedBy.Size = new System.Drawing.Size(32, 23);
            this.iconCreatedBy.TabIndex = 43;
            this.iconCreatedBy.TabStop = false;
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(582, 24);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(98, 20);
            this.lblReplacedLicenseID.TabIndex = 15;
            this.lblReplacedLicenseID.Text = "License ID";
            // 
            // iconFees
            // 
            this.iconFees.BackgroundImage = global::DVLD.Properties.Resources.Application_Fees;
            this.iconFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconFees.Location = new System.Drawing.Point(210, 123);
            this.iconFees.Name = "iconFees";
            this.iconFees.Size = new System.Drawing.Size(32, 23);
            this.iconFees.TabIndex = 41;
            this.iconFees.TabStop = false;
            // 
            // iconApplicationDate
            // 
            this.iconApplicationDate.BackgroundImage = global::DVLD.Properties.Resources.Date__1_;
            this.iconApplicationDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconApplicationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconApplicationDate.Location = new System.Drawing.Point(210, 71);
            this.iconApplicationDate.Name = "iconApplicationDate";
            this.iconApplicationDate.Size = new System.Drawing.Size(33, 35);
            this.iconApplicationDate.TabIndex = 40;
            this.iconApplicationDate.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCreatedBy.Location = new System.Drawing.Point(582, 80);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(107, 20);
            this.lblCreatedBy.TabIndex = 18;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblLRApplicationIDForApp
            // 
            this.lblLRApplicationIDForApp.AutoSize = true;
            this.lblLRApplicationIDForApp.Font = new System.Drawing.Font("Impact", 10F);
            this.lblLRApplicationIDForApp.Location = new System.Drawing.Point(275, 33);
            this.lblLRApplicationIDForApp.Name = "lblLRApplicationIDForApp";
            this.lblLRApplicationIDForApp.Size = new System.Drawing.Size(28, 21);
            this.lblLRApplicationIDForApp.TabIndex = 19;
            this.lblLRApplicationIDForApp.Text = "NA";
            // 
            // lblApplicationDateForApp
            // 
            this.lblApplicationDateForApp.AutoSize = true;
            this.lblApplicationDateForApp.Font = new System.Drawing.Font("Impact", 10F);
            this.lblApplicationDateForApp.Location = new System.Drawing.Point(275, 80);
            this.lblApplicationDateForApp.Name = "lblApplicationDateForApp";
            this.lblApplicationDateForApp.Size = new System.Drawing.Size(28, 21);
            this.lblApplicationDateForApp.TabIndex = 20;
            this.lblApplicationDateForApp.Text = "NA";
            // 
            // iconILLicenseID
            // 
            this.iconILLicenseID.BackgroundImage = global::DVLD.Properties.Resources.National;
            this.iconILLicenseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconILLicenseID.Location = new System.Drawing.Point(774, 21);
            this.iconILLicenseID.Name = "iconILLicenseID";
            this.iconILLicenseID.Size = new System.Drawing.Size(32, 23);
            this.iconILLicenseID.TabIndex = 31;
            this.iconILLicenseID.TabStop = false;
            // 
            // iconLicenseID
            // 
            this.iconLicenseID.BackgroundImage = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__23_;
            this.iconLicenseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconLicenseID.Location = new System.Drawing.Point(210, 24);
            this.iconLicenseID.Name = "iconLicenseID";
            this.iconLicenseID.Size = new System.Drawing.Size(33, 31);
            this.iconLicenseID.TabIndex = 30;
            this.iconLicenseID.TabStop = false;
            // 
            // lblCreatedByForApp
            // 
            this.lblCreatedByForApp.AutoSize = true;
            this.lblCreatedByForApp.Font = new System.Drawing.Font("Impact", 10F);
            this.lblCreatedByForApp.Location = new System.Drawing.Point(824, 80);
            this.lblCreatedByForApp.Name = "lblCreatedByForApp";
            this.lblCreatedByForApp.Size = new System.Drawing.Size(28, 21);
            this.lblCreatedByForApp.TabIndex = 26;
            this.lblCreatedByForApp.Text = "NA";
            // 
            // lblReplacedLicenseIDForApp
            // 
            this.lblReplacedLicenseIDForApp.AutoSize = true;
            this.lblReplacedLicenseIDForApp.Font = new System.Drawing.Font("Impact", 10F);
            this.lblReplacedLicenseIDForApp.Location = new System.Drawing.Point(824, 24);
            this.lblReplacedLicenseIDForApp.Name = "lblReplacedLicenseIDForApp";
            this.lblReplacedLicenseIDForApp.Size = new System.Drawing.Size(28, 21);
            this.lblReplacedLicenseIDForApp.TabIndex = 23;
            this.lblReplacedLicenseIDForApp.Text = "NA";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(598, 727);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 61);
            this.btnClose.TabIndex = 97;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDetain
            // 
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDetain.Location = new System.Drawing.Point(802, 727);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(151, 61);
            this.btnDetain.TabIndex = 98;
            this.btnDetain.Text = "        Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ctrSearchForLicenseInfoByID1
            // 
            this.ctrSearchForLicenseInfoByID1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrSearchForLicenseInfoByID1.Location = new System.Drawing.Point(12, 2);
            this.ctrSearchForLicenseInfoByID1.Name = "ctrSearchForLicenseInfoByID1";
            this.ctrSearchForLicenseInfoByID1.Size = new System.Drawing.Size(1037, 519);
            this.ctrSearchForLicenseInfoByID1.TabIndex = 0;
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(36, 759);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(196, 20);
            this.lblShowLicenseHistory.TabIndex = 100;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // lblShowLicenseinfo
            // 
            this.lblShowLicenseinfo.AutoSize = true;
            this.lblShowLicenseinfo.Enabled = false;
            this.lblShowLicenseinfo.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblShowLicenseinfo.Location = new System.Drawing.Point(268, 759);
            this.lblShowLicenseinfo.Name = "lblShowLicenseinfo";
            this.lblShowLicenseinfo.Size = new System.Drawing.Size(171, 20);
            this.lblShowLicenseinfo.TabIndex = 99;
            this.lblShowLicenseinfo.TabStop = true;
            this.lblShowLicenseinfo.Text = "Show License info";
            this.lblShowLicenseinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseinfo_LinkClicked);
            // 
            // DetaineLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 819);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.lblShowLicenseinfo);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ApplicationInfo);
            this.Controls.Add(this.lblDetainLicenses);
            this.Controls.Add(this.ctrSearchForLicenseInfoByID1);
            this.Name = "DetaineLicence";
            this.Text = "DetaineLicence";
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconILLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrSearchForLicenseInfoByID ctrSearchForLicenseInfoByID1;
        private System.Windows.Forms.Label lblDetainLicenses;
        private System.Windows.Forms.GroupBox ApplicationInfo;
        private System.Windows.Forms.Label lblLRApplicationID;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.PictureBox iconCreatedBy;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.PictureBox iconFees;
        private System.Windows.Forms.PictureBox iconApplicationDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLRApplicationIDForApp;
        public System.Windows.Forms.Label lblApplicationDateForApp;
        private System.Windows.Forms.PictureBox iconILLicenseID;
        private System.Windows.Forms.PictureBox iconLicenseID;
        public System.Windows.Forms.Label lblCreatedByForApp;
        private System.Windows.Forms.Label lblReplacedLicenseIDForApp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.TextBox txbApplicationFeesForApp;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lblShowLicenseinfo;
    }
}