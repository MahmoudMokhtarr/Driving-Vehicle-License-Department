namespace DVLD
{
    partial class ChangePassword
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
            this.ctrUserInfo1 = new DVLD.ctrUserInfo();
            this.lblCurentPassword = new System.Windows.Forms.Label();
            this.txbCurentPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrUserInfo1
            // 
            this.ctrUserInfo1.BackColor = System.Drawing.Color.White;
            this.ctrUserInfo1.Location = new System.Drawing.Point(2, 6);
            this.ctrUserInfo1.Name = "ctrUserInfo1";
            this.ctrUserInfo1.Size = new System.Drawing.Size(726, 583);
            this.ctrUserInfo1.TabIndex = 0;
            // 
            // lblCurentPassword
            // 
            this.lblCurentPassword.AutoSize = true;
            this.lblCurentPassword.Font = new System.Drawing.Font("Always Find Demo", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCurentPassword.Location = new System.Drawing.Point(791, 94);
            this.lblCurentPassword.Name = "lblCurentPassword";
            this.lblCurentPassword.Size = new System.Drawing.Size(190, 24);
            this.lblCurentPassword.TabIndex = 1;
            this.lblCurentPassword.Text = "Curent Password";
            // 
            // txbCurentPassword
            // 
            this.txbCurentPassword.Location = new System.Drawing.Point(795, 147);
            this.txbCurentPassword.Multiline = true;
            this.txbCurentPassword.Name = "txbCurentPassword";
            this.txbCurentPassword.Size = new System.Drawing.Size(191, 33);
            this.txbCurentPassword.TabIndex = 2;
            this.txbCurentPassword.TextChanged += new System.EventHandler(this.txbCurentPassword_TextChanged);
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(795, 283);
            this.txbNewPassword.Multiline = true;
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(191, 33);
            this.txbNewPassword.TabIndex = 4;
            this.txbNewPassword.TextChanged += new System.EventHandler(this.txbNewPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Always Find Demo", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNewPassword.Location = new System.Drawing.Point(791, 230);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(166, 24);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "New Password";
            // 
            // txbConfirmNewPassword
            // 
            this.txbConfirmNewPassword.Location = new System.Drawing.Point(800, 415);
            this.txbConfirmNewPassword.Multiline = true;
            this.txbConfirmNewPassword.Name = "txbConfirmNewPassword";
            this.txbConfirmNewPassword.Size = new System.Drawing.Size(191, 33);
            this.txbConfirmNewPassword.TabIndex = 6;
            this.txbConfirmNewPassword.TextChanged += new System.EventHandler(this.txbConfirmNewPassword_TextChanged);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Always Find Demo", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(796, 362);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(219, 20);
            this.lblConfirmNewPassword.TabIndex = 5;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__35_;
            this.btnSaveData.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveData.Location = new System.Drawing.Point(823, 496);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(146, 61);
            this.btnSaveData.TabIndex = 27;
            this.btnSaveData.Text = "       Save";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveDate_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1068, 598);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.txbConfirmNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txbCurentPassword);
            this.Controls.Add(this.lblCurentPassword);
            this.Controls.Add(this.ctrUserInfo1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrUserInfo ctrUserInfo1;
        private System.Windows.Forms.Label lblCurentPassword;
        private System.Windows.Forms.TextBox txbCurentPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txbConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSaveData;
    }
}