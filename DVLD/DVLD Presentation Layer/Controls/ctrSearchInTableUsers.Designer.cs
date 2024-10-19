namespace DVLD
{
    partial class ctrSearchInTableUsers
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
            this.txbSearchByWord = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cobFilterUsers = new System.Windows.Forms.ComboBox();
            this.cobActiveUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(13, 56);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 13;
            this.txbSearchByWord.Text = "";
            this.txbSearchByWord.Visible = false;
            this.txbSearchByWord.TextChanged += new System.EventHandler(this.txbSearchByWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter By : ";
            // 
            // cobFilterUsers
            // 
            this.cobFilterUsers.FormattingEnabled = true;
            this.cobFilterUsers.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName",
            "PersonID",
            "FullName",
            "IsActive"});
            this.cobFilterUsers.Location = new System.Drawing.Point(122, 20);
            this.cobFilterUsers.Name = "cobFilterUsers";
            this.cobFilterUsers.Size = new System.Drawing.Size(136, 24);
            this.cobFilterUsers.TabIndex = 11;
            this.cobFilterUsers.SelectedValueChanged += new System.EventHandler(this.cobFilterUsers_SelectedValueChanged);
            // 
            // cobActiveUsers
            // 
            this.cobActiveUsers.FormattingEnabled = true;
            this.cobActiveUsers.Items.AddRange(new object[] {
            "ALL",
            "Yes",
            "No"});
            this.cobActiveUsers.Location = new System.Drawing.Point(73, 56);
            this.cobActiveUsers.Name = "cobActiveUsers";
            this.cobActiveUsers.Size = new System.Drawing.Size(113, 24);
            this.cobActiveUsers.TabIndex = 14;
            this.cobActiveUsers.Visible = false;
            this.cobActiveUsers.SelectedValueChanged += new System.EventHandler(this.cobActiveUsers_SelectedValueChanged);
            // 
            // ctrSearchInTableUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cobActiveUsers);
            this.Controls.Add(this.txbSearchByWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cobFilterUsers);
            this.Name = "ctrSearchInTableUsers";
            this.Size = new System.Drawing.Size(397, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbSearchByWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobFilterUsers;
        private System.Windows.Forms.ComboBox cobActiveUsers;
    }
}
