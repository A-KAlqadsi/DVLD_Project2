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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDrivers));
            this.label1 = new System.Windows.Forms.Label();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListDrivers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterDrivers = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.colDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActiveLicenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(573, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Drivers";
            // 
            // pbDrivers
            // 
            this.pbDrivers.BackColor = System.Drawing.Color.Transparent;
            this.pbDrivers.Image = ((System.Drawing.Image)(resources.GetObject("pbDrivers.Image")));
            this.pbDrivers.Location = new System.Drawing.Point(575, 2);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(223, 131);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrivers.TabIndex = 3;
            this.pbDrivers.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListDrivers);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 327);
            this.panel1.TabIndex = 5;
            // 
            // dgvListDrivers
            // 
            this.dgvListDrivers.AllowUserToAddRows = false;
            this.dgvListDrivers.AllowUserToDeleteRows = false;
            this.dgvListDrivers.AllowUserToOrderColumns = true;
            this.dgvListDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverID,
            this.colPersonID,
            this.colNationalNo,
            this.colFullName,
            this.colDate,
            this.colActiveLicenses});
            this.dgvListDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListDrivers.Location = new System.Drawing.Point(0, 0);
            this.dgvListDrivers.Name = "dgvListDrivers";
            this.dgvListDrivers.ReadOnly = true;
            this.dgvListDrivers.RowHeadersWidth = 51;
            this.dgvListDrivers.RowTemplate.Height = 24;
            this.dgvListDrivers.Size = new System.Drawing.Size(1303, 327);
            this.dgvListDrivers.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1179, 534);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.label2.Location = new System.Drawing.Point(9, 165);
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
            "National No",
            "Full Name",
            "Active Licenses"});
            this.cbFilterDrivers.Location = new System.Drawing.Point(112, 161);
            this.cbFilterDrivers.Name = "cbFilterDrivers";
            this.cbFilterDrivers.Size = new System.Drawing.Size(192, 33);
            this.cbFilterDrivers.TabIndex = 15;
            this.cbFilterDrivers.SelectedIndexChanged += new System.EventHandler(this.cbFilterDrivers_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(310, 162);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(184, 30);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // colDriverID
            // 
            this.colDriverID.HeaderText = "Driver ID";
            this.colDriverID.MinimumWidth = 6;
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.ReadOnly = true;
            // 
            // colPersonID
            // 
            this.colPersonID.HeaderText = "Person ID";
            this.colPersonID.MinimumWidth = 6;
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            // 
            // colNationalNo
            // 
            this.colNationalNo.HeaderText = "National No";
            this.colNationalNo.MinimumWidth = 6;
            this.colNationalNo.Name = "colNationalNo";
            this.colNationalNo.ReadOnly = true;
            this.colNationalNo.Width = 120;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 290;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 155;
            // 
            // colActiveLicenses
            // 
            this.colActiveLicenses.HeaderText = "Active Licenses";
            this.colActiveLicenses.MinimumWidth = 6;
            this.colActiveLicenses.Name = "colActiveLicenses";
            this.colActiveLicenses.ReadOnly = true;
            this.colActiveLicenses.Width = 140;
            // 
            // frmListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 588);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLicenses;
    }
}