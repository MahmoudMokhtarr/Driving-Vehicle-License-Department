namespace DVLD
{
    partial class ctrUserLoginInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblModeUserActiveForUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserNameForUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserIDForUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblModeUserActiveForUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblUserNameForUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUserIDForUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Infromaiton";
            // 
            // lblModeUserActiveForUser
            // 
            this.lblModeUserActiveForUser.AutoSize = true;
            this.lblModeUserActiveForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblModeUserActiveForUser.Location = new System.Drawing.Point(586, 43);
            this.lblModeUserActiveForUser.Name = "lblModeUserActiveForUser";
            this.lblModeUserActiveForUser.Size = new System.Drawing.Size(39, 25);
            this.lblModeUserActiveForUser.TabIndex = 6;
            this.lblModeUserActiveForUser.Text = "No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Always Find Demo", 11.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(460, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Is Active";
            // 
            // lblUserNameForUser
            // 
            this.lblUserNameForUser.AutoSize = true;
            this.lblUserNameForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserNameForUser.Location = new System.Drawing.Point(349, 43);
            this.lblUserNameForUser.Name = "lblUserNameForUser";
            this.lblUserNameForUser.Size = new System.Drawing.Size(24, 25);
            this.lblUserNameForUser.TabIndex = 4;
            this.lblUserNameForUser.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Always Find Demo", 11.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(209, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // lblUserIDForUser
            // 
            this.lblUserIDForUser.AutoSize = true;
            this.lblUserIDForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDForUser.Location = new System.Drawing.Point(117, 40);
            this.lblUserIDForUser.Name = "lblUserIDForUser";
            this.lblUserIDForUser.Size = new System.Drawing.Size(24, 25);
            this.lblUserIDForUser.TabIndex = 2;
            this.lblUserIDForUser.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Always Find Demo", 11.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID ";
            // 
            // ctrUserLoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrUserLoginInfo";
            this.Size = new System.Drawing.Size(709, 114);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblModeUserActiveForUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserNameForUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserIDForUser;
        private System.Windows.Forms.Label label1;
    }
}
