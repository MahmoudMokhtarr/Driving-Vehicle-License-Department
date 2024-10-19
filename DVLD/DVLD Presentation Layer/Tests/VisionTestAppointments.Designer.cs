namespace DVLD
{
    partial class VisionTestAppointments
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
            this.lblModeTestApplication = new System.Windows.Forms.Label();
            this.DTGAppointments = new System.Windows.Forms.DataGridView();
            this.MenuAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.ctrDrivingApplicationInfo1 = new DVLD.ctrDrivingApplicationInfo();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGAppointments)).BeginInit();
            this.MenuAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModeTestApplication
            // 
            this.lblModeTestApplication.AutoSize = true;
            this.lblModeTestApplication.Font = new System.Drawing.Font("Always Find Demo", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblModeTestApplication.Location = new System.Drawing.Point(342, 9);
            this.lblModeTestApplication.Name = "lblModeTestApplication";
            this.lblModeTestApplication.Size = new System.Drawing.Size(420, 38);
            this.lblModeTestApplication.TabIndex = 5;
            this.lblModeTestApplication.Text = "Vision Test Appointments";
            // 
            // DTGAppointments
            // 
            this.DTGAppointments.AllowUserToAddRows = false;
            this.DTGAppointments.AllowUserToDeleteRows = false;
            this.DTGAppointments.AllowUserToOrderColumns = true;
            this.DTGAppointments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DTGAppointments.ColumnHeadersHeight = 29;
            this.DTGAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.AppointmentDate,
            this.PaidFees,
            this.IsLocked});
            this.DTGAppointments.ContextMenuStrip = this.MenuAppointments;
            this.DTGAppointments.Location = new System.Drawing.Point(247, 493);
            this.DTGAppointments.Name = "DTGAppointments";
            this.DTGAppointments.RowHeadersWidth = 51;
            this.DTGAppointments.RowTemplate.Height = 24;
            this.DTGAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGAppointments.Size = new System.Drawing.Size(737, 233);
            this.DTGAppointments.TabIndex = 27;
            // 
            // MenuAppointments
            // 
            this.MenuAppointments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppointment,
            this.TakeTest});
            this.MenuAppointments.Name = "MenuAppointments";
            this.MenuAppointments.Size = new System.Drawing.Size(134, 52);
            // 
            // EditAppointment
            // 
            this.EditAppointment.Name = "EditAppointment";
            this.EditAppointment.Size = new System.Drawing.Size(133, 24);
            this.EditAppointment.Text = "Edit";
            this.EditAppointment.Click += new System.EventHandler(this.EditAppointment_Click);
            // 
            // TakeTest
            // 
            this.TakeTest.Name = "TakeTest";
            this.TakeTest.Size = new System.Drawing.Size(133, 24);
            this.TakeTest.Text = "TakeTest";
            this.TakeTest.Click += new System.EventHandler(this.TakeTest_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblAppointments.Location = new System.Drawing.Point(494, 442);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(161, 30);
            this.lblAppointments.TabIndex = 26;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnAddDate
            // 
            this.btnAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDate.Image = global::DVLD.Properties.Resources.تصميم_بدون_عنوان__39_;
            this.btnAddDate.Location = new System.Drawing.Point(1082, 424);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(64, 54);
            this.btnAddDate.TabIndex = 29;
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // ctrDrivingApplicationInfo1
            // 
            this.ctrDrivingApplicationInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrDrivingApplicationInfo1.Location = new System.Drawing.Point(124, 63);
            this.ctrDrivingApplicationInfo1.Name = "ctrDrivingApplicationInfo1";
            this.ctrDrivingApplicationInfo1.Size = new System.Drawing.Size(924, 376);
            this.ctrDrivingApplicationInfo1.TabIndex = 30;
            // 
            // AppointmentID
            // 
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.MinimumWidth = 6;
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.AppointmentID.Width = 125;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.MinimumWidth = 6;
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Width = 150;
            // 
            // PaidFees
            // 
            this.PaidFees.HeaderText = "Paid Fees";
            this.PaidFees.MinimumWidth = 6;
            this.PaidFees.Name = "PaidFees";
            this.PaidFees.Width = 125;
            // 
            // IsLocked
            // 
            this.IsLocked.HeaderText = "Is Locked";
            this.IsLocked.MinimumWidth = 6;
            this.IsLocked.Name = "IsLocked";
            this.IsLocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsLocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsLocked.Width = 125;
            // 
            // VisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1216, 738);
            this.Controls.Add(this.ctrDrivingApplicationInfo1);
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(this.DTGAppointments);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lblModeTestApplication);
            this.Name = "VisionTestAppointments";
            this.Text = "VisionTestAppointments";
            this.Load += new System.EventHandler(this.VisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGAppointments)).EndInit();
            this.MenuAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeTestApplication;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnAddDate;
        private ctrDrivingApplicationInfo ctrDrivingApplicationInfo1;
        private System.Windows.Forms.ContextMenuStrip MenuAppointments;
        private System.Windows.Forms.ToolStripMenuItem EditAppointment;
        private System.Windows.Forms.ToolStripMenuItem TakeTest;
        private System.Windows.Forms.DataGridView DTGAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLocked;
    }
}