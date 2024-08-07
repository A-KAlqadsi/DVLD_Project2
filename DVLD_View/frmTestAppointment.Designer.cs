namespace DVLD_View
{
    partial class frmTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointment));
            this.lblMode = new System.Windows.Forms.Label();
            this.pbVisionTestAppointment = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListAllVisionTestAppointments = new System.Windows.Forms.DataGridView();
            this.cmsManageVisionTestAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditTestAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlApplicationCard1 = new DVLD_View.ctrlApplicationCard();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisionTestAppointment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAllVisionTestAppointments)).BeginInit();
            this.cmsManageVisionTestAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMode.Location = new System.Drawing.Point(344, 92);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(263, 36);
            this.lblMode.TabIndex = 8;
            this.lblMode.Text = "Test Appointments";
            // 
            // pbVisionTestAppointment
            // 
            this.pbVisionTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.pbVisionTestAppointment.Image = ((System.Drawing.Image)(resources.GetObject("pbVisionTestAppointment.Image")));
            this.pbVisionTestAppointment.Location = new System.Drawing.Point(435, -4);
            this.pbVisionTestAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbVisionTestAppointment.Name = "pbVisionTestAppointment";
            this.pbVisionTestAppointment.Size = new System.Drawing.Size(206, 96);
            this.pbVisionTestAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVisionTestAppointment.TabIndex = 7;
            this.pbVisionTestAppointment.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Appointments:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListAllVisionTestAppointments);
            this.panel1.Location = new System.Drawing.Point(16, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 156);
            this.panel1.TabIndex = 11;
            // 
            // dgvListAllVisionTestAppointments
            // 
            this.dgvListAllVisionTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvListAllVisionTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAllVisionTestAppointments.ContextMenuStrip = this.cmsManageVisionTestAppointment;
            this.dgvListAllVisionTestAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListAllVisionTestAppointments.Location = new System.Drawing.Point(0, 0);
            this.dgvListAllVisionTestAppointments.Name = "dgvListAllVisionTestAppointments";
            this.dgvListAllVisionTestAppointments.RowHeadersWidth = 51;
            this.dgvListAllVisionTestAppointments.RowTemplate.Height = 24;
            this.dgvListAllVisionTestAppointments.Size = new System.Drawing.Size(1027, 156);
            this.dgvListAllVisionTestAppointments.TabIndex = 0;
            // 
            // cmsManageVisionTestAppointment
            // 
            this.cmsManageVisionTestAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageVisionTestAppointment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageVisionTestAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditTestAppointment,
            this.tsmiTakeTest});
            this.cmsManageVisionTestAppointment.Name = "cmsManageVisionTestAppointment";
            this.cmsManageVisionTestAppointment.Size = new System.Drawing.Size(164, 80);
            // 
            // tsmiEditTestAppointment
            // 
            this.tsmiEditTestAppointment.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditTestAppointment.Image")));
            this.tsmiEditTestAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditTestAppointment.Name = "tsmiEditTestAppointment";
            this.tsmiEditTestAppointment.Size = new System.Drawing.Size(163, 38);
            this.tsmiEditTestAppointment.Text = "Edit";
            // 
            // tsmiTakeTest
            // 
            this.tsmiTakeTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTakeTest.Image")));
            this.tsmiTakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTakeTest.Name = "tsmiTakeTest";
            this.tsmiTakeTest.Size = new System.Drawing.Size(163, 38);
            this.tsmiTakeTest.Text = "Take Test";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.White;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.Location = new System.Drawing.Point(986, 590);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(58, 46);
            this.btnAddAppointment.TabIndex = 18;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(905, 797);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 38);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(104, 800);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
            this.lblRecordsCount.TabIndex = 21;
            this.lblRecordsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 800);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "# Records:";
            // 
            // ctrlApplicationCard1
            // 
            this.ctrlApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ctrlApplicationCard1.Location = new System.Drawing.Point(11, 137);
            this.ctrlApplicationCard1.Name = "ctrlApplicationCard1";
            this.ctrlApplicationCard1.Size = new System.Drawing.Size(1037, 450);
            this.ctrlApplicationCard1.TabIndex = 9;
            // 
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 855);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlApplicationCard1);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.pbVisionTestAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appointment";
            this.Load += new System.EventHandler(this.frmVisionTestAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVisionTestAppointment)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAllVisionTestAppointments)).EndInit();
            this.cmsManageVisionTestAppointment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox pbVisionTestAppointment;
        private ctrlApplicationCard ctrlApplicationCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListAllVisionTestAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsManageVisionTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakeTest;
    }
}