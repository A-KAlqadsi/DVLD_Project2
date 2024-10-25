namespace DVLD_View
{
    partial class frmManageLocalDrivingLicenseApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApp));
			this.label1 = new System.Windows.Forms.Label();
			this.pbManageLDLApps = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dgvListLocalDrivingLicenseApps = new System.Windows.Forms.DataGridView();
			this.cmsManageLocalDrivingLicenseApp = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiShowAppDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiEditApplication = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
			this.sToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiScheduleTests = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilterLocalDrivingLicenseApps = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAddNew = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDrivingLicenseApps)).BeginInit();
			this.cmsManageLocalDrivingLicenseApp.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(426, 150);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 36);
			this.label1.TabIndex = 6;
			this.label1.Text = "Local Driving License Applications";
			// 
			// pbManageLDLApps
			// 
			this.pbManageLDLApps.BackColor = System.Drawing.Color.Transparent;
			this.pbManageLDLApps.Image = ((System.Drawing.Image)(resources.GetObject("pbManageLDLApps.Image")));
			this.pbManageLDLApps.Location = new System.Drawing.Point(554, 3);
			this.pbManageLDLApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbManageLDLApps.Name = "pbManageLDLApps";
			this.pbManageLDLApps.Size = new System.Drawing.Size(139, 143);
			this.pbManageLDLApps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbManageLDLApps.TabIndex = 5;
			this.pbManageLDLApps.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(677, 54);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// dgvListLocalDrivingLicenseApps
			// 
			this.dgvListLocalDrivingLicenseApps.AllowUserToAddRows = false;
			this.dgvListLocalDrivingLicenseApps.AllowUserToDeleteRows = false;
			this.dgvListLocalDrivingLicenseApps.AllowUserToOrderColumns = true;
			this.dgvListLocalDrivingLicenseApps.BackgroundColor = System.Drawing.Color.White;
			this.dgvListLocalDrivingLicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListLocalDrivingLicenseApps.ContextMenuStrip = this.cmsManageLocalDrivingLicenseApp;
			this.dgvListLocalDrivingLicenseApps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvListLocalDrivingLicenseApps.Location = new System.Drawing.Point(0, 0);
			this.dgvListLocalDrivingLicenseApps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dgvListLocalDrivingLicenseApps.Name = "dgvListLocalDrivingLicenseApps";
			this.dgvListLocalDrivingLicenseApps.ReadOnly = true;
			this.dgvListLocalDrivingLicenseApps.RowHeadersWidth = 51;
			this.dgvListLocalDrivingLicenseApps.RowTemplate.Height = 24;
			this.dgvListLocalDrivingLicenseApps.Size = new System.Drawing.Size(1309, 294);
			this.dgvListLocalDrivingLicenseApps.TabIndex = 8;
			// 
			// cmsManageLocalDrivingLicenseApp
			// 
			this.cmsManageLocalDrivingLicenseApp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmsManageLocalDrivingLicenseApp.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsManageLocalDrivingLicenseApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowAppDetails,
            this.toolStripMenuItem1,
            this.tsmiEditApplication,
            this.tsmiDeleteApplication,
            this.toolStripMenuItem2,
            this.tsmiCancelApplication,
            this.sToolStripMenuItem,
            this.tsmiScheduleTests,
            this.toolStripMenuItem3,
            this.tsmiIssueDrivingLicense,
            this.toolStripMenuItem4,
            this.tsmiShowLicense,
            this.toolStripMenuItem5,
            this.tsmiShowPersonLicenseHistory});
			this.cmsManageLocalDrivingLicenseApp.Name = "cmsManageLocalDrivingLicenseApp";
			this.cmsManageLocalDrivingLicenseApp.Size = new System.Drawing.Size(342, 372);
			this.cmsManageLocalDrivingLicenseApp.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManageLocalDrivingLicenseApp_Opening);
			// 
			// tsmiShowAppDetails
			// 
			this.tsmiShowAppDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowAppDetails.Image")));
			this.tsmiShowAppDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowAppDetails.Name = "tsmiShowAppDetails";
			this.tsmiShowAppDetails.Size = new System.Drawing.Size(341, 38);
			this.tsmiShowAppDetails.Text = "Show  Application Details";
			this.tsmiShowAppDetails.Click += new System.EventHandler(this.tsmiShowAppDetails_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(338, 6);
			// 
			// tsmiEditApplication
			// 
			this.tsmiEditApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditApplication.Image")));
			this.tsmiEditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiEditApplication.Name = "tsmiEditApplication";
			this.tsmiEditApplication.Size = new System.Drawing.Size(341, 38);
			this.tsmiEditApplication.Text = "Edit Application";
			this.tsmiEditApplication.Click += new System.EventHandler(this.tsmiEditApplication_Click);
			// 
			// tsmiDeleteApplication
			// 
			this.tsmiDeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteApplication.Image")));
			this.tsmiDeleteApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiDeleteApplication.Name = "tsmiDeleteApplication";
			this.tsmiDeleteApplication.Size = new System.Drawing.Size(341, 38);
			this.tsmiDeleteApplication.Text = "Delete Application";
			this.tsmiDeleteApplication.Click += new System.EventHandler(this.tsmiDeleteApplication_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(338, 6);
			// 
			// tsmiCancelApplication
			// 
			this.tsmiCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancelApplication.Image")));
			this.tsmiCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiCancelApplication.Name = "tsmiCancelApplication";
			this.tsmiCancelApplication.Size = new System.Drawing.Size(341, 38);
			this.tsmiCancelApplication.Text = "Cancel Application";
			this.tsmiCancelApplication.Click += new System.EventHandler(this.tsmiCancelApplication_Click);
			// 
			// sToolStripMenuItem
			// 
			this.sToolStripMenuItem.Name = "sToolStripMenuItem";
			this.sToolStripMenuItem.Size = new System.Drawing.Size(338, 6);
			// 
			// tsmiScheduleTests
			// 
			this.tsmiScheduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScheduleVisionTest,
            this.tsmiScheduleWrittenTest,
            this.tsmiScheduleStreetTest});
			this.tsmiScheduleTests.Image = ((System.Drawing.Image)(resources.GetObject("tsmiScheduleTests.Image")));
			this.tsmiScheduleTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiScheduleTests.Name = "tsmiScheduleTests";
			this.tsmiScheduleTests.Size = new System.Drawing.Size(341, 38);
			this.tsmiScheduleTests.Text = "Schedule Tests";
			// 
			// tsmiScheduleVisionTest
			// 
			this.tsmiScheduleVisionTest.Enabled = false;
			this.tsmiScheduleVisionTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiScheduleVisionTest.Image")));
			this.tsmiScheduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiScheduleVisionTest.Name = "tsmiScheduleVisionTest";
			this.tsmiScheduleVisionTest.Size = new System.Drawing.Size(271, 38);
			this.tsmiScheduleVisionTest.Tag = "1";
			this.tsmiScheduleVisionTest.Text = "Schedule Vision Test";
			this.tsmiScheduleVisionTest.Click += new System.EventHandler(this.tsmiScheduleVisionTest_Click);
			// 
			// tsmiScheduleWrittenTest
			// 
			this.tsmiScheduleWrittenTest.Enabled = false;
			this.tsmiScheduleWrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiScheduleWrittenTest.Image")));
			this.tsmiScheduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiScheduleWrittenTest.Name = "tsmiScheduleWrittenTest";
			this.tsmiScheduleWrittenTest.Size = new System.Drawing.Size(271, 38);
			this.tsmiScheduleWrittenTest.Tag = "2";
			this.tsmiScheduleWrittenTest.Text = "Schedule Written Test";
			this.tsmiScheduleWrittenTest.Click += new System.EventHandler(this.tsmiScheduleWrittenTest_Click);
			// 
			// tsmiScheduleStreetTest
			// 
			this.tsmiScheduleStreetTest.Enabled = false;
			this.tsmiScheduleStreetTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiScheduleStreetTest.Image")));
			this.tsmiScheduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiScheduleStreetTest.Name = "tsmiScheduleStreetTest";
			this.tsmiScheduleStreetTest.Size = new System.Drawing.Size(271, 38);
			this.tsmiScheduleStreetTest.Tag = "3";
			this.tsmiScheduleStreetTest.Text = "Schedule Street Test";
			this.tsmiScheduleStreetTest.Click += new System.EventHandler(this.tsmiScheduleStreetTest_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(338, 6);
			// 
			// tsmiIssueDrivingLicense
			// 
			this.tsmiIssueDrivingLicense.Enabled = false;
			this.tsmiIssueDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiIssueDrivingLicense.Image")));
			this.tsmiIssueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiIssueDrivingLicense.Name = "tsmiIssueDrivingLicense";
			this.tsmiIssueDrivingLicense.Size = new System.Drawing.Size(341, 38);
			this.tsmiIssueDrivingLicense.Text = "Issue Driving License (First Time)";
			this.tsmiIssueDrivingLicense.Click += new System.EventHandler(this.tsmiIssueDrivingLicense_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(338, 6);
			// 
			// tsmiShowLicense
			// 
			this.tsmiShowLicense.Enabled = false;
			this.tsmiShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowLicense.Image")));
			this.tsmiShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowLicense.Name = "tsmiShowLicense";
			this.tsmiShowLicense.Size = new System.Drawing.Size(341, 38);
			this.tsmiShowLicense.Text = "Show License";
			this.tsmiShowLicense.Click += new System.EventHandler(this.tsmiShowLicense_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(338, 6);
			// 
			// tsmiShowPersonLicenseHistory
			// 
			this.tsmiShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowPersonLicenseHistory.Image")));
			this.tsmiShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowPersonLicenseHistory.Name = "tsmiShowPersonLicenseHistory";
			this.tsmiShowPersonLicenseHistory.Size = new System.Drawing.Size(341, 38);
			this.tsmiShowPersonLicenseHistory.Text = "Show Person License History";
			this.tsmiShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmiShowPersonLicenseHistory_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(22, 223);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Filter By:";
			// 
			// cbFilterLocalDrivingLicenseApps
			// 
			this.cbFilterLocalDrivingLicenseApps.BackColor = System.Drawing.Color.White;
			this.cbFilterLocalDrivingLicenseApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterLocalDrivingLicenseApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFilterLocalDrivingLicenseApps.FormattingEnabled = true;
			this.cbFilterLocalDrivingLicenseApps.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "Driving Class",
            "National No",
            "Full Name",
            "Passed Tests",
            "Status"});
			this.cbFilterLocalDrivingLicenseApps.Location = new System.Drawing.Point(110, 219);
			this.cbFilterLocalDrivingLicenseApps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cbFilterLocalDrivingLicenseApps.Name = "cbFilterLocalDrivingLicenseApps";
			this.cbFilterLocalDrivingLicenseApps.Size = new System.Drawing.Size(192, 33);
			this.cbFilterLocalDrivingLicenseApps.TabIndex = 9;
			this.cbFilterLocalDrivingLicenseApps.SelectedIndexChanged += new System.EventHandler(this.cbFilterLocalDrivingLicenseApps_SelectedIndexChanged);
			// 
			// txtFilter
			// 
			this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilter.Location = new System.Drawing.Point(308, 220);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(270, 30);
			this.txtFilter.TabIndex = 11;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvListLocalDrivingLicenseApps);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(11, 268);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1309, 294);
			this.panel1.TabIndex = 13;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1182, 567);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 41);
			this.btnClose.TabIndex = 16;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
			this.lblRecordsCount.Location = new System.Drawing.Point(96, 567);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
			this.lblRecordsCount.TabIndex = 15;
			this.lblRecordsCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(15, 567);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "# Records:";
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.White;
			this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
			this.btnAddNew.Location = new System.Drawing.Point(1236, 182);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(84, 80);
			this.btnAddNew.TabIndex = 17;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// frmManageLocalDrivingLicenseApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1331, 620);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbFilterLocalDrivingLicenseApps);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbManageLDLApps);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "frmManageLocalDrivingLicenseApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Local Driving License Applications";
			this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenseApp_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDrivingLicenseApps)).EndInit();
			this.cmsManageLocalDrivingLicenseApp.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManageLDLApps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvListLocalDrivingLicenseApps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterLocalDrivingLicenseApps;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ContextMenuStrip cmsManageLocalDrivingLicenseApp;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAppDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplication;
        private System.Windows.Forms.ToolStripSeparator sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleTests;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleStreetTest;
    }
}