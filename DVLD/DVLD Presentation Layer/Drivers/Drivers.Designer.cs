namespace DVLD
{
    partial class Drivers
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
            this.lblMangeDrivers = new System.Windows.Forms.Label();
            this.DGVListDrivers = new System.Windows.Forms.DataGridView();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveLicense = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageMangeDrivers = new System.Windows.Forms.PictureBox();
            this.txbSearchByWord = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cobFilterDrives = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMangeDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMangeDrivers
            // 
            this.lblMangeDrivers.AutoSize = true;
            this.lblMangeDrivers.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMangeDrivers.Location = new System.Drawing.Point(481, 23);
            this.lblMangeDrivers.Name = "lblMangeDrivers";
            this.lblMangeDrivers.Size = new System.Drawing.Size(255, 38);
            this.lblMangeDrivers.TabIndex = 5;
            this.lblMangeDrivers.Text = "Mange Drivers";
            // 
            // DGVListDrivers
            // 
            this.DGVListDrivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverID,
            this.PersonID,
            this.NationalNo,
            this.FullName,
            this.Date,
            this.ActiveLicense});
            this.DGVListDrivers.Location = new System.Drawing.Point(15, 262);
            this.DGVListDrivers.Name = "DGVListDrivers";
            this.DGVListDrivers.RowHeadersWidth = 51;
            this.DGVListDrivers.RowTemplate.Height = 24;
            this.DGVListDrivers.Size = new System.Drawing.Size(1158, 339);
            this.DGVListDrivers.TabIndex = 6;
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.MinimumWidth = 6;
            this.DriverID.Name = "DriverID";
            this.DriverID.Width = 125;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.MinimumWidth = 6;
            this.PersonID.Name = "PersonID";
            this.PersonID.Width = 125;
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 24;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // ActiveLicense
            // 
            this.ActiveLicense.HeaderText = "Active License";
            this.ActiveLicense.MinimumWidth = 6;
            this.ActiveLicense.Name = "ActiveLicense";
            this.ActiveLicense.Width = 125;
            // 
            // imageMangeDrivers
            // 
            this.imageMangeDrivers.BackgroundImage = global::DVLD.Properties.Resources.Mange_Drivers;
            this.imageMangeDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageMangeDrivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageMangeDrivers.Location = new System.Drawing.Point(471, 76);
            this.imageMangeDrivers.Name = "imageMangeDrivers";
            this.imageMangeDrivers.Size = new System.Drawing.Size(248, 168);
            this.imageMangeDrivers.TabIndex = 7;
            this.imageMangeDrivers.TabStop = false;
            // 
            // txbSearchByWord
            // 
            this.txbSearchByWord.Location = new System.Drawing.Point(12, 65);
            this.txbSearchByWord.Name = "txbSearchByWord";
            this.txbSearchByWord.Size = new System.Drawing.Size(256, 30);
            this.txbSearchByWord.TabIndex = 17;
            this.txbSearchByWord.Text = "";
            this.txbSearchByWord.TextChanged += new System.EventHandler(this.txbSearchByWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filter By : ";
            // 
            // cobFilterDrives
            // 
            this.cobFilterDrives.FormattingEnabled = true;
            this.cobFilterDrives.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "FullName"});
            this.cobFilterDrives.Location = new System.Drawing.Point(121, 29);
            this.cobFilterDrives.Name = "cobFilterDrives";
            this.cobFilterDrives.Size = new System.Drawing.Size(136, 24);
            this.cobFilterDrives.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__36_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(500, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 61);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1180, 685);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txbSearchByWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cobFilterDrives);
            this.Controls.Add(this.imageMangeDrivers);
            this.Controls.Add(this.DGVListDrivers);
            this.Controls.Add(this.lblMangeDrivers);
            this.Name = "Drivers";
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMangeDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMangeDrivers;
        private System.Windows.Forms.DataGridView DGVListDrivers;
        private System.Windows.Forms.PictureBox imageMangeDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActiveLicense;
        private System.Windows.Forms.RichTextBox txbSearchByWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobFilterDrives;
        private System.Windows.Forms.Button btnClose;
    }
}