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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApp));
            this.label1 = new System.Windows.Forms.Label();
            this.pbManageLDLApps = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvListLocalDrivingLicenseApps = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterLocalDrivingLicenseApps = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.colLDLAppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrivingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDrivingLicenseApps)).BeginInit();
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
            this.dgvListLocalDrivingLicenseApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLDLAppID,
            this.colDrivingClass,
            this.colNationalNo,
            this.colFullName,
            this.colApplicationDate,
            this.colPassedTests,
            this.colStatus});
            this.dgvListLocalDrivingLicenseApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListLocalDrivingLicenseApps.Location = new System.Drawing.Point(0, 0);
            this.dgvListLocalDrivingLicenseApps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvListLocalDrivingLicenseApps.Name = "dgvListLocalDrivingLicenseApps";
            this.dgvListLocalDrivingLicenseApps.ReadOnly = true;
            this.dgvListLocalDrivingLicenseApps.RowHeadersWidth = 51;
            this.dgvListLocalDrivingLicenseApps.RowTemplate.Height = 24;
            this.dgvListLocalDrivingLicenseApps.Size = new System.Drawing.Size(1309, 248);
            this.dgvListLocalDrivingLicenseApps.TabIndex = 8;
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
            this.cbFilterLocalDrivingLicenseApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterLocalDrivingLicenseApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterLocalDrivingLicenseApps.FormattingEnabled = true;
            this.cbFilterLocalDrivingLicenseApps.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cbFilterLocalDrivingLicenseApps.Location = new System.Drawing.Point(110, 219);
            this.cbFilterLocalDrivingLicenseApps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFilterLocalDrivingLicenseApps.Name = "cbFilterLocalDrivingLicenseApps";
            this.cbFilterLocalDrivingLicenseApps.Size = new System.Drawing.Size(192, 33);
            this.cbFilterLocalDrivingLicenseApps.TabIndex = 9;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(308, 220);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(270, 30);
            this.txtFilter.TabIndex = 11;
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusFilter.FormattingEnabled = true;
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbStatusFilter.Location = new System.Drawing.Point(308, 218);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(122, 33);
            this.cbStatusFilter.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListLocalDrivingLicenseApps);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 248);
            this.panel1.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1182, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 41);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(96, 519);
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
            this.label3.Location = new System.Drawing.Point(15, 519);
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
            // 
            // colLDLAppID
            // 
            this.colLDLAppID.HeaderText = "L.D.L AppID";
            this.colLDLAppID.MinimumWidth = 6;
            this.colLDLAppID.Name = "colLDLAppID";
            this.colLDLAppID.ReadOnly = true;
            this.colLDLAppID.Width = 125;
            // 
            // colDrivingClass
            // 
            this.colDrivingClass.HeaderText = "Driving Class";
            this.colDrivingClass.MinimumWidth = 6;
            this.colDrivingClass.Name = "colDrivingClass";
            this.colDrivingClass.ReadOnly = true;
            this.colDrivingClass.Width = 300;
            // 
            // colNationalNo
            // 
            this.colNationalNo.HeaderText = "National No";
            this.colNationalNo.MinimumWidth = 6;
            this.colNationalNo.Name = "colNationalNo";
            this.colNationalNo.ReadOnly = true;
            this.colNationalNo.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 300;
            // 
            // colApplicationDate
            // 
            this.colApplicationDate.HeaderText = "Application Date";
            this.colApplicationDate.MinimumWidth = 6;
            this.colApplicationDate.Name = "colApplicationDate";
            this.colApplicationDate.ReadOnly = true;
            this.colApplicationDate.Width = 140;
            // 
            // colPassedTests
            // 
            this.colPassedTests.HeaderText = "Passed Tests";
            this.colPassedTests.MinimumWidth = 6;
            this.colPassedTests.Name = "colPassedTests";
            this.colPassedTests.ReadOnly = true;
            this.colPassedTests.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // frmManageLocalDrivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 564);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbStatusFilter);
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
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLDLAppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrivingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}