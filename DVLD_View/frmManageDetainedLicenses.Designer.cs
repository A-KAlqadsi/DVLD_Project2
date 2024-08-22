namespace DVLD_View
{
    partial class frmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            this.label1 = new System.Windows.Forms.Label();
            this.pbManagePeople = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnReleaseDetainedLicense = new System.Windows.Forms.Button();
            this.cbIsReleaseFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterDetainedLicenses = new System.Windows.Forms.ComboBox();
            this.colDetainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsReleased = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReleaseAppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsManageDetainedLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainedLicenses)).BeginInit();
            this.cmsManageDetainedLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(635, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // pbManagePeople
            // 
            this.pbManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.pbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pbManagePeople.Image")));
            this.pbManagePeople.Location = new System.Drawing.Point(699, 5);
            this.pbManagePeople.Name = "pbManagePeople";
            this.pbManagePeople.Size = new System.Drawing.Size(220, 121);
            this.pbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeople.TabIndex = 3;
            this.pbManagePeople.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListDetainedLicenses);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1676, 320);
            this.panel1.TabIndex = 5;
            // 
            // dgvListDetainedLicenses
            // 
            this.dgvListDetainedLicenses.AllowUserToAddRows = false;
            this.dgvListDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvListDetainedLicenses.AllowUserToOrderColumns = true;
            this.dgvListDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDetainedLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetainID,
            this.colLicenseID,
            this.colDetainDate,
            this.colIsReleased,
            this.colFineFees,
            this.colReleaseDate,
            this.colNationalNo,
            this.colFullName,
            this.colReleaseAppID});
            this.dgvListDetainedLicenses.ContextMenuStrip = this.cmsManageDetainedLicense;
            this.dgvListDetainedLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListDetainedLicenses.Location = new System.Drawing.Point(0, 0);
            this.dgvListDetainedLicenses.Name = "dgvListDetainedLicenses";
            this.dgvListDetainedLicenses.ReadOnly = true;
            this.dgvListDetainedLicenses.RowHeadersWidth = 51;
            this.dgvListDetainedLicenses.RowTemplate.Height = 24;
            this.dgvListDetainedLicenses.Size = new System.Drawing.Size(1676, 320);
            this.dgvListDetainedLicenses.TabIndex = 0;
            this.dgvListDetainedLicenses.SelectionChanged += new System.EventHandler(this.dgvListDetainedLicenses_SelectionChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(92, 544);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
            this.lblRecordsCount.TabIndex = 17;
            this.lblRecordsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "# Records:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1547, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.White;
            this.btnDetainLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnDetainLicense.Image")));
            this.btnDetainLicense.Location = new System.Drawing.Point(1596, 135);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(84, 80);
            this.btnDetainLicense.TabIndex = 18;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.BackColor = System.Drawing.Color.White;
            this.btnReleaseDetainedLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReleaseDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseDetainedLicense.Image")));
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(1506, 135);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(84, 80);
            this.btnReleaseDetainedLicense.TabIndex = 19;
            this.btnReleaseDetainedLicense.UseVisualStyleBackColor = false;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // cbIsReleaseFilter
            // 
            this.cbIsReleaseFilter.BackColor = System.Drawing.Color.White;
            this.cbIsReleaseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleaseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsReleaseFilter.FormattingEnabled = true;
            this.cbIsReleaseFilter.Items.AddRange(new object[] {
            "All",
            "Released",
            "Not Released"});
            this.cbIsReleaseFilter.Location = new System.Drawing.Point(298, 181);
            this.cbIsReleaseFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIsReleaseFilter.Name = "cbIsReleaseFilter";
            this.cbIsReleaseFilter.Size = new System.Drawing.Size(161, 33);
            this.cbIsReleaseFilter.TabIndex = 23;
            this.cbIsReleaseFilter.Visible = false;
            this.cbIsReleaseFilter.SelectedIndexChanged += new System.EventHandler(this.cbIsReleaseFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(298, 183);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(270, 30);
            this.txtFilter.TabIndex = 22;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter By:";
            // 
            // cbFilterDetainedLicenses
            // 
            this.cbFilterDetainedLicenses.BackColor = System.Drawing.Color.White;
            this.cbFilterDetainedLicenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterDetainedLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterDetainedLicenses.FormattingEnabled = true;
            this.cbFilterDetainedLicenses.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "License ID",
            "Is Release",
            "Fine Fees",
            "National No",
            "Full Name",
            "Rlease App ID"});
            this.cbFilterDetainedLicenses.Location = new System.Drawing.Point(101, 182);
            this.cbFilterDetainedLicenses.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFilterDetainedLicenses.Name = "cbFilterDetainedLicenses";
            this.cbFilterDetainedLicenses.Size = new System.Drawing.Size(192, 33);
            this.cbFilterDetainedLicenses.TabIndex = 20;
            this.cbFilterDetainedLicenses.SelectedIndexChanged += new System.EventHandler(this.cbFilterDetainedLicenses_SelectedIndexChanged);
            // 
            // colDetainID
            // 
            this.colDetainID.HeaderText = "D.ID";
            this.colDetainID.MinimumWidth = 6;
            this.colDetainID.Name = "colDetainID";
            this.colDetainID.ReadOnly = true;
            this.colDetainID.Width = 75;
            // 
            // colLicenseID
            // 
            this.colLicenseID.HeaderText = "L.ID";
            this.colLicenseID.MinimumWidth = 6;
            this.colLicenseID.Name = "colLicenseID";
            this.colLicenseID.ReadOnly = true;
            this.colLicenseID.Width = 75;
            // 
            // colDetainDate
            // 
            this.colDetainDate.HeaderText = "D.Date";
            this.colDetainDate.MinimumWidth = 6;
            this.colDetainDate.Name = "colDetainDate";
            this.colDetainDate.ReadOnly = true;
            this.colDetainDate.Width = 165;
            // 
            // colIsReleased
            // 
            this.colIsReleased.HeaderText = "Is Released";
            this.colIsReleased.MinimumWidth = 6;
            this.colIsReleased.Name = "colIsReleased";
            this.colIsReleased.ReadOnly = true;
            // 
            // colFineFees
            // 
            this.colFineFees.HeaderText = "Fine Fees";
            this.colFineFees.MinimumWidth = 6;
            this.colFineFees.Name = "colFineFees";
            this.colFineFees.ReadOnly = true;
            this.colFineFees.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFineFees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colReleaseDate
            // 
            this.colReleaseDate.HeaderText = "Release Date";
            this.colReleaseDate.MinimumWidth = 6;
            this.colReleaseDate.Name = "colReleaseDate";
            this.colReleaseDate.ReadOnly = true;
            this.colReleaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReleaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReleaseDate.Width = 165;
            // 
            // colNationalNo
            // 
            this.colNationalNo.HeaderText = "N.No";
            this.colNationalNo.MinimumWidth = 6;
            this.colNationalNo.Name = "colNationalNo";
            this.colNationalNo.ReadOnly = true;
            this.colNationalNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNationalNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFullName.Width = 290;
            // 
            // colReleaseAppID
            // 
            this.colReleaseAppID.HeaderText = "Rlease App.ID";
            this.colReleaseAppID.MinimumWidth = 6;
            this.colReleaseAppID.Name = "colReleaseAppID";
            this.colReleaseAppID.ReadOnly = true;
            this.colReleaseAppID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReleaseAppID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReleaseAppID.Width = 120;
            // 
            // cmsManageDetainedLicense
            // 
            this.cmsManageDetainedLicense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageDetainedLicense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageDetainedLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowPersonDetails,
            this.tsmiShowLicenseDetails,
            this.tsmiShowPersonHistory,
            this.toolStripMenuItem1,
            this.tsmiReleaseDetainedLicense});
            this.cmsManageDetainedLicense.Name = "cmsManageDetainedLicense";
            this.cmsManageDetainedLicense.Size = new System.Drawing.Size(312, 162);
            // 
            // tsmiShowPersonDetails
            // 
            this.tsmiShowPersonDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowPersonDetails.Image")));
            this.tsmiShowPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowPersonDetails.Name = "tsmiShowPersonDetails";
            this.tsmiShowPersonDetails.Size = new System.Drawing.Size(311, 38);
            this.tsmiShowPersonDetails.Text = "Show Person Details";
            this.tsmiShowPersonDetails.Click += new System.EventHandler(this.tsmiShowPersonDetails_Click);
            // 
            // tsmiShowLicenseDetails
            // 
            this.tsmiShowLicenseDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowLicenseDetails.Image")));
            this.tsmiShowLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowLicenseDetails.Name = "tsmiShowLicenseDetails";
            this.tsmiShowLicenseDetails.Size = new System.Drawing.Size(311, 38);
            this.tsmiShowLicenseDetails.Text = "Show License Details";
            this.tsmiShowLicenseDetails.Click += new System.EventHandler(this.tsmiShowLicenseDetails_Click);
            // 
            // tsmiShowPersonHistory
            // 
            this.tsmiShowPersonHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowPersonHistory.Image")));
            this.tsmiShowPersonHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowPersonHistory.Name = "tsmiShowPersonHistory";
            this.tsmiShowPersonHistory.Size = new System.Drawing.Size(311, 38);
            this.tsmiShowPersonHistory.Text = "Show Person License History";
            this.tsmiShowPersonHistory.Click += new System.EventHandler(this.tsmiShowPersonHistory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(308, 6);
            // 
            // tsmiReleaseDetainedLicense
            // 
            this.tsmiReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReleaseDetainedLicense.Image")));
            this.tsmiReleaseDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReleaseDetainedLicense.Name = "tsmiReleaseDetainedLicense";
            this.tsmiReleaseDetainedLicense.Size = new System.Drawing.Size(311, 38);
            this.tsmiReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmiReleaseDetainedLicense.Click += new System.EventHandler(this.tsmiReleaseDetainedLicense_Click);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1695, 606);
            this.Controls.Add(this.cbIsReleaseFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterDetainedLicenses);
            this.Controls.Add(this.btnReleaseDetainedLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licenses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainedLicenses)).EndInit();
            this.cmsManageDetainedLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManagePeople;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListDetainedLicenses;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.Button btnReleaseDetainedLicense;
        private System.Windows.Forms.ComboBox cbIsReleaseFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterDetainedLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetainDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFineFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReleaseAppID;
        private System.Windows.Forms.ContextMenuStrip cmsManageDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDetainedLicense;
    }
}