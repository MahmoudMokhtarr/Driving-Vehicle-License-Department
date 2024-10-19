namespace DVLD
{
    partial class ctrSearchPeronInfo
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
            this.cobFilterPeople = new System.Windows.Forms.ComboBox();
            this.ctrlPersonInformation1 = new DVLD.ctrlPersonInformation();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSearchForUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(16, 58);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 17;
            this.txbSearchByWord.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filter By : ";
            // 
            // cobFilterPeople
            // 
            this.cobFilterPeople.FormattingEnabled = true;
            this.cobFilterPeople.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cobFilterPeople.Location = new System.Drawing.Point(125, 22);
            this.cobFilterPeople.Name = "cobFilterPeople";
            this.cobFilterPeople.Size = new System.Drawing.Size(136, 24);
            this.cobFilterPeople.TabIndex = 15;
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(16, 115);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(814, 432);
            this.ctrlPersonInformation1.TabIndex = 18;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__27_;
            this.btnAddUser.Location = new System.Drawing.Point(462, 25);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(82, 88);
            this.btnAddUser.TabIndex = 26;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSearchForUser
            // 
            this.btnSearchForUser.BackgroundImage = global::DVLD.Properties.Resources.Serch_In_Users;
            this.btnSearchForUser.Location = new System.Drawing.Point(334, 19);
            this.btnSearchForUser.Name = "btnSearchForUser";
            this.btnSearchForUser.Size = new System.Drawing.Size(90, 86);
            this.btnSearchForUser.TabIndex = 25;
            this.btnSearchForUser.UseVisualStyleBackColor = true;
            this.btnSearchForUser.Click += new System.EventHandler(this.btnSearchForUser_Click);
            // 
            // ctrSearchPeronInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnSearchForUser);
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Controls.Add(this.txbSearchByWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cobFilterPeople);
            this.Name = "ctrSearchPeronInfo";
            this.Size = new System.Drawing.Size(840, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobFilterPeople;
        private ctrlPersonInformation ctrlPersonInformation1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchForUser;
        internal System.Windows.Forms.RichTextBox txbSearchByWord;
    }
}
