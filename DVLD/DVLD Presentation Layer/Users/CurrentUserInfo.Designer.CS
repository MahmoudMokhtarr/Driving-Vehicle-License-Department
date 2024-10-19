namespace DVLD
{
    partial class CurrentUserInfo
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
            this.ctrlPersonInformation1 = new DVLD.ctrlPersonInformation();
            this.SuspendLayout();
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(2, 2);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(769, 432);
            this.ctrlPersonInformation1.TabIndex = 0;
            // 
            // CurrentUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(783, 588);
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Name = "CurrentUserInfo";
            this.Text = "CurrentUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInformation ctrlPersonInformation1;
    }
}