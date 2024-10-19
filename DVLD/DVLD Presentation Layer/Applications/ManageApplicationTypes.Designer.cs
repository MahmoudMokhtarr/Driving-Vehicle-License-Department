namespace DVLD
{
    partial class ManageApplicationTypes
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
            this.dtViewApplicationTypes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManageApplicationTypes = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewApplicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtViewApplicationTypes
            // 
            this.dtViewApplicationTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtViewApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewApplicationTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titel,
            this.Fees});
            this.dtViewApplicationTypes.ContextMenuStrip = this.contextMenuStrip;
            this.dtViewApplicationTypes.Location = new System.Drawing.Point(135, 287);
            this.dtViewApplicationTypes.Name = "dtViewApplicationTypes";
            this.dtViewApplicationTypes.RowHeadersWidth = 51;
            this.dtViewApplicationTypes.RowTemplate.Height = 24;
            this.dtViewApplicationTypes.Size = new System.Drawing.Size(691, 366);
            this.dtViewApplicationTypes.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__17_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(373, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblManageApplicationTypes
            // 
            this.lblManageApplicationTypes.AutoSize = true;
            this.lblManageApplicationTypes.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageApplicationTypes.Location = new System.Drawing.Point(210, 207);
            this.lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            this.lblManageApplicationTypes.Size = new System.Drawing.Size(539, 47);
            this.lblManageApplicationTypes.TabIndex = 3;
            this.lblManageApplicationTypes.Text = "Manage Application Types";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditApplicationType});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(221, 28);
            // 
            // EditApplicationType
            // 
            this.EditApplicationType.Name = "EditApplicationType";
            this.EditApplicationType.Size = new System.Drawing.Size(220, 24);
            this.EditApplicationType.Text = "Edit Application Type";
            this.EditApplicationType.Click += new System.EventHandler(this.EditApplicationType_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Titel
            // 
            this.Titel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Titel.HeaderText = "Titel";
            this.Titel.MinimumWidth = 6;
            this.Titel.Name = "Titel";
            this.Titel.Width = 24;
            // 
            // Fees
            // 
            this.Fees.HeaderText = "Fees";
            this.Fees.MinimumWidth = 6;
            this.Fees.Name = "Fees";
            this.Fees.Width = 118;
            // 
            // ManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(961, 686);
            this.Controls.Add(this.lblManageApplicationTypes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtViewApplicationTypes);
            this.Name = "ManageApplicationTypes";
            this.Text = "ManageApplicationTypes";
            this.Load += new System.EventHandler(this.ManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewApplicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtViewApplicationTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManageApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
    }
}