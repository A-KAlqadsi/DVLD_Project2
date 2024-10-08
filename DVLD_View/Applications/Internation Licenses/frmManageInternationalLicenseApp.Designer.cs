namespace DVLD_View
{
    partial class frmManageInternationalLicenseApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalLicenseApp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbManageIntLApps = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterInterLicenseApps = new System.Windows.Forms.ComboBox();
            this.cbActivityFilter = new System.Windows.Forms.ComboBox();
            this.cmsManageIntLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colIntLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageIntLApps)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).BeginInit();
            this.cmsManageIntLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(449, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "International License Applications";
            // 
            // pbManageIntLApps
            // 
            this.pbManageIntLApps.BackColor = System.Drawing.Color.Transparent;
            this.pbManageIntLApps.Image = ((System.Drawing.Image)(resources.GetObject("pbManageIntLApps.Image")));
            this.pbManageIntLApps.Location = new System.Drawing.Point(577, -2);
            this.pbManageIntLApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbManageIntLApps.Name = "pbManageIntLApps";
            this.pbManageIntLApps.Size = new System.Drawing.Size(139, 143);
            this.pbManageIntLApps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageIntLApps.TabIndex = 8;
            this.pbManageIntLApps.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListInternationalLicenses);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 329);
            this.panel1.TabIndex = 11;
            // 
            // dgvListInternationalLicenses
            // 
            this.dgvListInternationalLicenses.AllowUserToAddRows = false;
            this.dgvListInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvListInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvListInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvListInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInternationalLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntLicenseID,
            this.colApplicationID,
            this.colDriverID,
            this.colLocalLicenseID,
            this.colIssueDate,
            this.colExpirationDate,
            this.colIsActive});
            this.dgvListInternationalLicenses.ContextMenuStrip = this.cmsManageIntLicenses;
            this.dgvListInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListInternationalLicenses.Location = new System.Drawing.Point(0, 0);
            this.dgvListInternationalLicenses.Name = "dgvListInternationalLicenses";
            this.dgvListInternationalLicenses.ReadOnly = true;
            this.dgvListInternationalLicenses.RowHeadersWidth = 51;
            this.dgvListInternationalLicenses.RowTemplate.Height = 24;
            this.dgvListInternationalLicenses.Size = new System.Drawing.Size(1313, 329);
            this.dgvListInternationalLicenses.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(302, 222);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(270, 30);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter By:";
            // 
            // cbFilterInterLicenseApps
            // 
            this.cbFilterInterLicenseApps.BackColor = System.Drawing.Color.White;
            this.cbFilterInterLicenseApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterInterLicenseApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterInterLicenseApps.FormattingEnabled = true;
            this.cbFilterInterLicenseApps.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Is Active"});
            this.cbFilterInterLicenseApps.Location = new System.Drawing.Point(106, 221);
            this.cbFilterInterLicenseApps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFilterInterLicenseApps.Name = "cbFilterInterLicenseApps";
            this.cbFilterInterLicenseApps.Size = new System.Drawing.Size(192, 33);
            this.cbFilterInterLicenseApps.TabIndex = 12;
            this.cbFilterInterLicenseApps.SelectedIndexChanged += new System.EventHandler(this.cbFilterInterLicenseApps_SelectedIndexChanged);
            // 
            // cbActivityFilter
            // 
            this.cbActivityFilter.BackColor = System.Drawing.Color.White;
            this.cbActivityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivityFilter.FormattingEnabled = true;
            this.cbActivityFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cbActivityFilter.Location = new System.Drawing.Point(302, 221);
            this.cbActivityFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbActivityFilter.Name = "cbActivityFilter";
            this.cbActivityFilter.Size = new System.Drawing.Size(148, 33);
            this.cbActivityFilter.TabIndex = 15;
            this.cbActivityFilter.Visible = false;
            this.cbActivityFilter.SelectedIndexChanged += new System.EventHandler(this.cbActivityFilter_SelectedIndexChanged);
            // 
            // cmsManageIntLicenses
            // 
            this.cmsManageIntLicenses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageIntLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageIntLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowPersonDetails,
            this.toolStripMenuItem1,
            this.tsmiShowLicenseDetails,
            this.tsmiShowPersonLicenseHistory});
            this.cmsManageIntLicenses.Name = "cmsManageIntLicenses";
            this.cmsManageIntLicenses.Size = new System.Drawing.Size(312, 152);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(308, 6);
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
            // tsmiShowPersonLicenseHistory
            // 
            this.tsmiShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowPersonLicenseHistory.Image")));
            this.tsmiShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowPersonLicenseHistory.Name = "tsmiShowPersonLicenseHistory";
            this.tsmiShowPersonLicenseHistory.Size = new System.Drawing.Size(311, 38);
            this.tsmiShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmiShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmiShowPersonLicenseHistory_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1187, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 41);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(97, 600);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
            this.lblRecordsCount.TabIndex = 18;
            this.lblRecordsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "# Records:";
            // 
            // colIntLicenseID
            // 
            this.colIntLicenseID.HeaderText = "Int.License ID";
            this.colIntLicenseID.MinimumWidth = 6;
            this.colIntLicenseID.Name = "colIntLicenseID";
            this.colIntLicenseID.ReadOnly = true;
            this.colIntLicenseID.Width = 125;
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "Application ID";
            this.colApplicationID.MinimumWidth = 6;
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            this.colApplicationID.Width = 125;
            // 
            // colDriverID
            // 
            this.colDriverID.HeaderText = "Driver ID";
            this.colDriverID.MinimumWidth = 6;
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.ReadOnly = true;
            // 
            // colLocalLicenseID
            // 
            this.colLocalLicenseID.HeaderText = "L.License ID";
            this.colLocalLicenseID.MinimumWidth = 6;
            this.colLocalLicenseID.Name = "colLocalLicenseID";
            this.colLocalLicenseID.ReadOnly = true;
            this.colLocalLicenseID.Width = 115;
            // 
            // colIssueDate
            // 
            this.colIssueDate.HeaderText = "Issue Date";
            this.colIssueDate.MinimumWidth = 6;
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.ReadOnly = true;
            this.colIssueDate.Width = 175;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.HeaderText = "Expiration Date";
            this.colExpirationDate.MinimumWidth = 6;
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.ReadOnly = true;
            this.colExpirationDate.Width = 175;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Width = 105;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1241, 182);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 80);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmManageInternationalLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 651);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbActivityFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterInterLicenseApps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbManageIntLApps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageInternationalLicenseApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage International License Application";
            this.Load += new System.EventHandler(this.frmManageInternationalLicenseApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageIntLApps)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).EndInit();
            this.cmsManageIntLicenses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManageIntLApps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListInternationalLicenses;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterInterLicenseApps;
        private System.Windows.Forms.ComboBox cbActivityFilter;
        private System.Windows.Forms.ContextMenuStrip cmsManageIntLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.Button btnAddNew;
    }
}