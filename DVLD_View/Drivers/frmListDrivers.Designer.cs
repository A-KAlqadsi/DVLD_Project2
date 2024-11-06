namespace DVLD_View
{
    partial class frmListDrivers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDrivers));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvListDrivers = new System.Windows.Forms.DataGridView();
			this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilterDrivers = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.pbDrivers = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).BeginInit();
			this.cmsDrivers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(581, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "Manage Drivers";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvListDrivers);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(12, 212);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1293, 319);
			this.panel1.TabIndex = 5;
			// 
			// dgvListDrivers
			// 
			this.dgvListDrivers.AllowUserToAddRows = false;
			this.dgvListDrivers.AllowUserToDeleteRows = false;
			this.dgvListDrivers.AllowUserToOrderColumns = true;
			this.dgvListDrivers.BackgroundColor = System.Drawing.Color.White;
			this.dgvListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListDrivers.ContextMenuStrip = this.cmsDrivers;
			this.dgvListDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvListDrivers.Location = new System.Drawing.Point(0, 0);
			this.dgvListDrivers.Name = "dgvListDrivers";
			this.dgvListDrivers.ReadOnly = true;
			this.dgvListDrivers.RowHeadersWidth = 51;
			this.dgvListDrivers.RowTemplate.Height = 24;
			this.dgvListDrivers.Size = new System.Drawing.Size(1293, 319);
			this.dgvListDrivers.TabIndex = 0;
			// 
			// cmsDrivers
			// 
			this.cmsDrivers.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPersonLicenseHistoryToolStripMenuItem});
			this.cmsDrivers.Name = "contextMenuStrip1";
			this.cmsDrivers.Size = new System.Drawing.Size(281, 114);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Image = global::DVLD_View.Properties.Resources.PersonDetails_32;
			this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
			this.showDetailsToolStripMenuItem.Text = "&Show Person Info";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
			// 
			// showPersonLicenseHistoryToolStripMenuItem
			// 
			this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_View.Properties.Resources.PersonLicenseHistory_32;
			this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
			this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
			this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
			this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
			this.lblRecordsCount.Location = new System.Drawing.Point(100, 537);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
			this.lblRecordsCount.TabIndex = 14;
			this.lblRecordsCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(12, 537);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "# Records:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(9, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "Filter By :";
			// 
			// cbFilterDrivers
			// 
			this.cbFilterDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFilterDrivers.FormattingEnabled = true;
			this.cbFilterDrivers.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"});
			this.cbFilterDrivers.Location = new System.Drawing.Point(104, 172);
			this.cbFilterDrivers.Name = "cbFilterDrivers";
			this.cbFilterDrivers.Size = new System.Drawing.Size(192, 33);
			this.cbFilterDrivers.TabIndex = 15;
			this.cbFilterDrivers.SelectedIndexChanged += new System.EventHandler(this.cbFilterDrivers_SelectedIndexChanged);
			// 
			// txtFilter
			// 
			this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilter.Location = new System.Drawing.Point(303, 173);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(235, 30);
			this.txtFilter.TabIndex = 17;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1167, 534);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 42);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbDrivers
			// 
			this.pbDrivers.BackColor = System.Drawing.Color.Transparent;
			this.pbDrivers.Image = ((System.Drawing.Image)(resources.GetObject("pbDrivers.Image")));
			this.pbDrivers.Location = new System.Drawing.Point(583, 1);
			this.pbDrivers.Name = "pbDrivers";
			this.pbDrivers.Size = new System.Drawing.Size(223, 131);
			this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDrivers.TabIndex = 3;
			this.pbDrivers.TabStop = false;
			// 
			// frmListDrivers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1310, 588);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbFilterDrivers);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbDrivers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmListDrivers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List Drivers";
			this.Load += new System.EventHandler(this.frmListDrivers_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).EndInit();
			this.cmsDrivers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDrivers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListDrivers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterDrivers;
        private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.ContextMenuStrip cmsDrivers;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
	}
}