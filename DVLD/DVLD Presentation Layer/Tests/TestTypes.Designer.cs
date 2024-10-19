namespace DVLD
{
    partial class TestTypes
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
            this.lblManageApplicationTypes = new System.Windows.Forms.Label();
            this.dtViewTestTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewTestTypes)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageApplicationTypes
            // 
            this.lblManageApplicationTypes.AutoSize = true;
            this.lblManageApplicationTypes.Font = new System.Drawing.Font("Always Find Demo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageApplicationTypes.Location = new System.Drawing.Point(307, 183);
            this.lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            this.lblManageApplicationTypes.Size = new System.Drawing.Size(400, 47);
            this.lblManageApplicationTypes.TabIndex = 6;
            this.lblManageApplicationTypes.Text = "Manage Test Types";
            // 
            // dtViewTestTypes
            // 
            this.dtViewTestTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtViewTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewTestTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titel,
            this.Description,
            this.Fees});
            this.dtViewTestTypes.ContextMenuStrip = this.contextMenuStrip;
            this.dtViewTestTypes.Location = new System.Drawing.Point(12, 269);
            this.dtViewTestTypes.Name = "dtViewTestTypes";
            this.dtViewTestTypes.RowHeadersWidth = 51;
            this.dtViewTestTypes.RowTemplate.Height = 24;
            this.dtViewTestTypes.Size = new System.Drawing.Size(954, 366);
            this.dtViewTestTypes.TabIndex = 4;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditApplicationType});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 56);
            // 
            // EditApplicationType
            // 
            this.EditApplicationType.Name = "EditApplicationType";
            this.EditApplicationType.Size = new System.Drawing.Size(210, 24);
            this.EditApplicationType.Text = "Edit Test Type";
            this.EditApplicationType.Click += new System.EventHandler(this.EditApplicationType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__18_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(404, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 130);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Fees
            // 
            this.Fees.HeaderText = "Fees";
            this.Fees.MinimumWidth = 6;
            this.Fees.Name = "Fees";
            this.Fees.Width = 118;
            // 
            // TestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(968, 647);
            this.Controls.Add(this.lblManageApplicationTypes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtViewTestTypes);
            this.Name = "TestTypes";
            this.Text = "TestTypes";
            this.Load += new System.EventHandler(this.TestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewTestTypes)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageApplicationTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtViewTestTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
    }
}