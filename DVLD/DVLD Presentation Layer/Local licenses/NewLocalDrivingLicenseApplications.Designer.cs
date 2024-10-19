namespace DVLD
{
    partial class NewLocalDrivingLicenseApplications
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
            this.lblNewLocalDrivingLicenseApplications = new System.Windows.Forms.Label();
            this.TcNewLocalDrivingLicenseApplication = new System.Windows.Forms.TabControl();
            this.tapPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrPersonInfo = new DVLD.ctrSearchPeronInfo();
            this.tapApplication = new System.Windows.Forms.TabPage();
            this.iconCretatedBy = new System.Windows.Forms.PictureBox();
            this.iconApplicationFees = new System.Windows.Forms.PictureBox();
            this.iconApplicationDate = new System.Windows.Forms.PictureBox();
            this.iconLicanceClass = new System.Windows.Forms.PictureBox();
            this.iconDrivingLocalApplicationID = new System.Windows.Forms.PictureBox();
            this.cobLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblCretatedByForLicance = new System.Windows.Forms.Label();
            this.lblApplicationFeesForLicance = new System.Windows.Forms.Label();
            this.lblApplicationDateForLicance = new System.Windows.Forms.Label();
            this.lbllblDrivingLocalApplicationIDForPerson = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblCretatedBy = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblLicanceClass = new System.Windows.Forms.Label();
            this.lblDrivingLocalApplicationID = new System.Windows.Forms.Label();
            this.btnSaveDate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.TcNewLocalDrivingLicenseApplication.SuspendLayout();
            this.tapPersonInfo.SuspendLayout();
            this.tapApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCretatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLicanceClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDrivingLocalApplicationID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewLocalDrivingLicenseApplications
            // 
            this.lblNewLocalDrivingLicenseApplications.AutoSize = true;
            this.lblNewLocalDrivingLicenseApplications.Font = new System.Drawing.Font("Always Find Demo", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNewLocalDrivingLicenseApplications.Location = new System.Drawing.Point(246, 13);
            this.lblNewLocalDrivingLicenseApplications.Name = "lblNewLocalDrivingLicenseApplications";
            this.lblNewLocalDrivingLicenseApplications.Size = new System.Drawing.Size(621, 37);
            this.lblNewLocalDrivingLicenseApplications.TabIndex = 0;
            this.lblNewLocalDrivingLicenseApplications.Text = "New Local Driving License Applications";
            // 
            // TcNewLocalDrivingLicenseApplication
            // 
            this.TcNewLocalDrivingLicenseApplication.Controls.Add(this.tapPersonInfo);
            this.TcNewLocalDrivingLicenseApplication.Controls.Add(this.tapApplication);
            this.TcNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(12, 53);
            this.TcNewLocalDrivingLicenseApplication.Name = "TcNewLocalDrivingLicenseApplication";
            this.TcNewLocalDrivingLicenseApplication.SelectedIndex = 0;
            this.TcNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(972, 657);
            this.TcNewLocalDrivingLicenseApplication.TabIndex = 2;
            // 
            // tapPersonInfo
            // 
            this.tapPersonInfo.Controls.Add(this.btnNext);
            this.tapPersonInfo.Controls.Add(this.ctrPersonInfo);
            this.tapPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tapPersonInfo.Name = "tapPersonInfo";
            this.tapPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tapPersonInfo.Size = new System.Drawing.Size(964, 628);
            this.tapPersonInfo.TabIndex = 0;
            this.tapPersonInfo.Text = "Person Info";
            this.tapPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNext.Image = global::DVLD.Properties.Resources.icNext__3_;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.Location = new System.Drawing.Point(811, 548);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 72);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "                      Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrPersonInfo
            // 
            this.ctrPersonInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrPersonInfo.Location = new System.Drawing.Point(6, 6);
            this.ctrPersonInfo.Name = "ctrPersonInfo";
            this.ctrPersonInfo.Size = new System.Drawing.Size(792, 562);
            this.ctrPersonInfo.TabIndex = 1;
            // 
            // tapApplication
            // 
            this.tapApplication.Controls.Add(this.iconCretatedBy);
            this.tapApplication.Controls.Add(this.iconApplicationFees);
            this.tapApplication.Controls.Add(this.iconApplicationDate);
            this.tapApplication.Controls.Add(this.iconLicanceClass);
            this.tapApplication.Controls.Add(this.iconDrivingLocalApplicationID);
            this.tapApplication.Controls.Add(this.cobLicenseClass);
            this.tapApplication.Controls.Add(this.lblCretatedByForLicance);
            this.tapApplication.Controls.Add(this.lblApplicationFeesForLicance);
            this.tapApplication.Controls.Add(this.lblApplicationDateForLicance);
            this.tapApplication.Controls.Add(this.lbllblDrivingLocalApplicationIDForPerson);
            this.tapApplication.Controls.Add(this.lblApplicationFees);
            this.tapApplication.Controls.Add(this.lblCretatedBy);
            this.tapApplication.Controls.Add(this.lblApplicationDate);
            this.tapApplication.Controls.Add(this.lblLicanceClass);
            this.tapApplication.Controls.Add(this.lblDrivingLocalApplicationID);
            this.tapApplication.Location = new System.Drawing.Point(4, 25);
            this.tapApplication.Name = "tapApplication";
            this.tapApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tapApplication.Size = new System.Drawing.Size(964, 628);
            this.tapApplication.TabIndex = 1;
            this.tapApplication.Text = "Application Info";
            this.tapApplication.UseVisualStyleBackColor = true;
            // 
            // iconCretatedBy
            // 
            this.iconCretatedBy.BackgroundImage = global::DVLD.Properties.Resources.Cretated_By;
            this.iconCretatedBy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconCretatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconCretatedBy.Location = new System.Drawing.Point(237, 340);
            this.iconCretatedBy.Name = "iconCretatedBy";
            this.iconCretatedBy.Size = new System.Drawing.Size(51, 53);
            this.iconCretatedBy.TabIndex = 14;
            this.iconCretatedBy.TabStop = false;
            // 
            // iconApplicationFees
            // 
            this.iconApplicationFees.BackgroundImage = global::DVLD.Properties.Resources.Application_Fees;
            this.iconApplicationFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconApplicationFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconApplicationFees.Location = new System.Drawing.Point(237, 267);
            this.iconApplicationFees.Name = "iconApplicationFees";
            this.iconApplicationFees.Size = new System.Drawing.Size(51, 54);
            this.iconApplicationFees.TabIndex = 13;
            this.iconApplicationFees.TabStop = false;
            // 
            // iconApplicationDate
            // 
            this.iconApplicationDate.BackgroundImage = global::DVLD.Properties.Resources.Date__1_;
            this.iconApplicationDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconApplicationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconApplicationDate.Location = new System.Drawing.Point(237, 194);
            this.iconApplicationDate.Name = "iconApplicationDate";
            this.iconApplicationDate.Size = new System.Drawing.Size(51, 55);
            this.iconApplicationDate.TabIndex = 12;
            this.iconApplicationDate.TabStop = false;
            // 
            // iconLicanceClass
            // 
            this.iconLicanceClass.BackgroundImage = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__18_;
            this.iconLicanceClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconLicanceClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconLicanceClass.Location = new System.Drawing.Point(237, 126);
            this.iconLicanceClass.Name = "iconLicanceClass";
            this.iconLicanceClass.Size = new System.Drawing.Size(51, 55);
            this.iconLicanceClass.TabIndex = 11;
            this.iconLicanceClass.TabStop = false;
            // 
            // iconDrivingLocalApplicationID
            // 
            this.iconDrivingLocalApplicationID.BackgroundImage = global::DVLD.Properties.Resources.Application_Edit;
            this.iconDrivingLocalApplicationID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconDrivingLocalApplicationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconDrivingLocalApplicationID.Location = new System.Drawing.Point(237, 64);
            this.iconDrivingLocalApplicationID.Name = "iconDrivingLocalApplicationID";
            this.iconDrivingLocalApplicationID.Size = new System.Drawing.Size(51, 56);
            this.iconDrivingLocalApplicationID.TabIndex = 10;
            this.iconDrivingLocalApplicationID.TabStop = false;
            // 
            // cobLicenseClass
            // 
            this.cobLicenseClass.FormattingEnabled = true;
            this.cobLicenseClass.Location = new System.Drawing.Point(356, 141);
            this.cobLicenseClass.Name = "cobLicenseClass";
            this.cobLicenseClass.Size = new System.Drawing.Size(260, 24);
            this.cobLicenseClass.TabIndex = 9;
            // 
            // lblCretatedByForLicance
            // 
            this.lblCretatedByForLicance.AutoSize = true;
            this.lblCretatedByForLicance.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblCretatedByForLicance.Location = new System.Drawing.Point(351, 341);
            this.lblCretatedByForLicance.Name = "lblCretatedByForLicance";
            this.lblCretatedByForLicance.Size = new System.Drawing.Size(28, 30);
            this.lblCretatedByForLicance.TabIndex = 8;
            this.lblCretatedByForLicance.Text = "A";
            // 
            // lblApplicationFeesForLicance
            // 
            this.lblApplicationFeesForLicance.AutoSize = true;
            this.lblApplicationFeesForLicance.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFeesForLicance.Location = new System.Drawing.Point(351, 268);
            this.lblApplicationFeesForLicance.Name = "lblApplicationFeesForLicance";
            this.lblApplicationFeesForLicance.Size = new System.Drawing.Size(37, 30);
            this.lblApplicationFeesForLicance.TabIndex = 7;
            this.lblApplicationFeesForLicance.Text = "15";
            // 
            // lblApplicationDateForLicance
            // 
            this.lblApplicationDateForLicance.AutoSize = true;
            this.lblApplicationDateForLicance.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDateForLicance.Location = new System.Drawing.Point(351, 195);
            this.lblApplicationDateForLicance.Name = "lblApplicationDateForLicance";
            this.lblApplicationDateForLicance.Size = new System.Drawing.Size(61, 30);
            this.lblApplicationDateForLicance.TabIndex = 6;
            this.lblApplicationDateForLicance.Text = "0000";
            // 
            // lbllblDrivingLocalApplicationIDForPerson
            // 
            this.lbllblDrivingLocalApplicationIDForPerson.AutoSize = true;
            this.lbllblDrivingLocalApplicationIDForPerson.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lbllblDrivingLocalApplicationIDForPerson.Location = new System.Drawing.Point(351, 75);
            this.lbllblDrivingLocalApplicationIDForPerson.Name = "lbllblDrivingLocalApplicationIDForPerson";
            this.lbllblDrivingLocalApplicationIDForPerson.Size = new System.Drawing.Size(22, 30);
            this.lbllblDrivingLocalApplicationIDForPerson.TabIndex = 5;
            this.lbllblDrivingLocalApplicationIDForPerson.Text = "?";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.Location = new System.Drawing.Point(19, 267);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(183, 30);
            this.lblApplicationFees.TabIndex = 4;
            this.lblApplicationFees.Text = "Application Fees";
            // 
            // lblCretatedBy
            // 
            this.lblCretatedBy.AutoSize = true;
            this.lblCretatedBy.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblCretatedBy.Location = new System.Drawing.Point(19, 340);
            this.lblCretatedBy.Name = "lblCretatedBy";
            this.lblCretatedBy.Size = new System.Drawing.Size(136, 30);
            this.lblCretatedBy.TabIndex = 3;
            this.lblCretatedBy.Text = "Cretated By";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.Location = new System.Drawing.Point(19, 194);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(187, 30);
            this.lblApplicationDate.TabIndex = 2;
            this.lblApplicationDate.Text = "Application Date";
            // 
            // lblLicanceClass
            // 
            this.lblLicanceClass.AutoSize = true;
            this.lblLicanceClass.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblLicanceClass.Location = new System.Drawing.Point(19, 133);
            this.lblLicanceClass.Name = "lblLicanceClass";
            this.lblLicanceClass.Size = new System.Drawing.Size(147, 30);
            this.lblLicanceClass.TabIndex = 1;
            this.lblLicanceClass.Text = "Licance Class";
            // 
            // lblDrivingLocalApplicationID
            // 
            this.lblDrivingLocalApplicationID.AutoSize = true;
            this.lblDrivingLocalApplicationID.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblDrivingLocalApplicationID.Location = new System.Drawing.Point(19, 74);
            this.lblDrivingLocalApplicationID.Name = "lblDrivingLocalApplicationID";
            this.lblDrivingLocalApplicationID.Size = new System.Drawing.Size(199, 30);
            this.lblDrivingLocalApplicationID.TabIndex = 0;
            this.lblDrivingLocalApplicationID.Text = "D.L.Application ID";
            // 
            // btnSaveDate
            // 
            this.btnSaveDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveDate.Enabled = false;
            this.btnSaveDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDate.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSaveDate.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__35_;
            this.btnSaveDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveDate.Location = new System.Drawing.Point(843, 727);
            this.btnSaveDate.Name = "btnSaveDate";
            this.btnSaveDate.Size = new System.Drawing.Size(146, 61);
            this.btnSaveDate.TabIndex = 31;
            this.btnSaveDate.Text = "       Save";
            this.btnSaveDate.UseVisualStyleBackColor = false;
            this.btnSaveDate.Click += new System.EventHandler(this.btnSaveDate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Always Find Demo", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(668, 728);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 61);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "     Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1001, 801);
            this.Controls.Add(this.btnSaveDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TcNewLocalDrivingLicenseApplication);
            this.Controls.Add(this.lblNewLocalDrivingLicenseApplications);
            this.Name = "NewLocalDrivingLicenseApplications";
            this.Text = "New Local Driving License Applications";
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseApplications_Load);
            this.TcNewLocalDrivingLicenseApplication.ResumeLayout(false);
            this.tapPersonInfo.ResumeLayout(false);
            this.tapApplication.ResumeLayout(false);
            this.tapApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCretatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLicanceClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDrivingLocalApplicationID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewLocalDrivingLicenseApplications;
        private ctrSearchPeronInfo ctrPersonInfo;
        private System.Windows.Forms.TabControl TcNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.TabPage tapPersonInfo;
        private System.Windows.Forms.TabPage tapApplication;
        private System.Windows.Forms.Button btnSaveDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDrivingLocalApplicationID;
        private System.Windows.Forms.Label lblLicanceClass;
        private System.Windows.Forms.Label lbllblDrivingLocalApplicationIDForPerson;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCretatedBy;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationDateForLicance;
        private System.Windows.Forms.Label lblCretatedByForLicance;
        private System.Windows.Forms.Label lblApplicationFeesForLicance;
        private System.Windows.Forms.ComboBox cobLicenseClass;
        private System.Windows.Forms.PictureBox iconCretatedBy;
        private System.Windows.Forms.PictureBox iconApplicationFees;
        private System.Windows.Forms.PictureBox iconApplicationDate;
        private System.Windows.Forms.PictureBox iconLicanceClass;
        private System.Windows.Forms.PictureBox iconDrivingLocalApplicationID;
    }
}