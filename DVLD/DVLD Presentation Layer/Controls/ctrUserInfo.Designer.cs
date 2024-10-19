namespace DVLD
{
    partial class ctrUserInfo
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
            this.ctrlPersonInformation1 = new DVLD.ctrlPersonInformation();
            this.ctrUserLoginInfo1 = new DVLD.ctrUserLoginInfo();
            this.SuspendLayout();
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(769, 432);
            this.ctrlPersonInformation1.TabIndex = 0;
            // 
            // ctrUserLoginInfo1
            // 
            this.ctrUserLoginInfo1.Location = new System.Drawing.Point(14, 454);
            this.ctrUserLoginInfo1.Name = "ctrUserLoginInfo1";
            this.ctrUserLoginInfo1.Size = new System.Drawing.Size(709, 114);
            this.ctrUserLoginInfo1.TabIndex = 1;
            // 
            // ctrUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrUserLoginInfo1);
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Name = "ctrUserInfo";
            this.Size = new System.Drawing.Size(726, 583);
            this.Load += new System.EventHandler(this.ctrUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInformation ctrlPersonInformation1;
        private ctrUserLoginInfo ctrUserLoginInfo1;
    }
}
