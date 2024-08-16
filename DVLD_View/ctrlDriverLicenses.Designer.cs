namespace DVLD_View
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLocalLicenseCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListLocalLicenses = new System.Windows.Forms.DataGridView();
            this.colLicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInternationalLicensesCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.colIntLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbDriverLicenses.SuspendLayout();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalLicenses)).BeginInit();
            this.tpInternational.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcDriverLicenses);
            this.gbDriverLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDriverLicenses.Location = new System.Drawing.Point(3, 3);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(1173, 402);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocal);
            this.tcDriverLicenses.Controls.Add(this.tpInternational);
            this.tcDriverLicenses.Location = new System.Drawing.Point(6, 37);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1161, 360);
            this.tcDriverLicenses.TabIndex = 0;
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.panel1);
            this.tpLocal.Location = new System.Drawing.Point(4, 29);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(1153, 327);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            this.tpLocal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLocalLicenseCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvListLocalLicenses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 321);
            this.panel1.TabIndex = 0;
            // 
            // lblLocalLicenseCount
            // 
            this.lblLocalLicenseCount.AutoSize = true;
            this.lblLocalLicenseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseCount.Location = new System.Drawing.Point(87, 298);
            this.lblLocalLicenseCount.Name = "lblLocalLicenseCount";
            this.lblLocalLicenseCount.Size = new System.Drawing.Size(15, 16);
            this.lblLocalLicenseCount.TabIndex = 4;
            this.lblLocalLicenseCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local Licenses History";
            // 
            // dgvListLocalLicenses
            // 
            this.dgvListLocalLicenses.AllowUserToAddRows = false;
            this.dgvListLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvListLocalLicenses.AllowUserToOrderColumns = true;
            this.dgvListLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvListLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLocalLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLicID,
            this.colAppID,
            this.colClassName,
            this.colIssueDate,
            this.colExpirationDate,
            this.colIsActive});
            this.dgvListLocalLicenses.Location = new System.Drawing.Point(3, 40);
            this.dgvListLocalLicenses.Name = "dgvListLocalLicenses";
            this.dgvListLocalLicenses.ReadOnly = true;
            this.dgvListLocalLicenses.RowHeadersWidth = 51;
            this.dgvListLocalLicenses.RowTemplate.Height = 24;
            this.dgvListLocalLicenses.Size = new System.Drawing.Size(1141, 254);
            this.dgvListLocalLicenses.TabIndex = 0;
            // 
            // colLicID
            // 
            this.colLicID.HeaderText = "Lic.ID";
            this.colLicID.MinimumWidth = 6;
            this.colLicID.Name = "colLicID";
            this.colLicID.ReadOnly = true;
            this.colLicID.Width = 90;
            // 
            // colAppID
            // 
            this.colAppID.HeaderText = "App.ID";
            this.colAppID.MinimumWidth = 6;
            this.colAppID.Name = "colAppID";
            this.colAppID.ReadOnly = true;
            this.colAppID.Width = 90;
            // 
            // colClassName
            // 
            this.colClassName.HeaderText = "Class Name";
            this.colClassName.MinimumWidth = 6;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.Width = 250;
            // 
            // colIssueDate
            // 
            this.colIssueDate.HeaderText = "Issue Date";
            this.colIssueDate.MinimumWidth = 6;
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.ReadOnly = true;
            this.colIssueDate.Width = 140;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.HeaderText = "Expiration Date";
            this.colExpirationDate.MinimumWidth = 6;
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.ReadOnly = true;
            this.colExpirationDate.Width = 140;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Width = 90;
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.panel2);
            this.tpInternational.Location = new System.Drawing.Point(4, 29);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(1153, 327);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInternationalLicensesCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvListInternationalLicenses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 321);
            this.panel2.TabIndex = 1;
            // 
            // lblInternationalLicensesCount
            // 
            this.lblInternationalLicensesCount.AutoSize = true;
            this.lblInternationalLicensesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesCount.Location = new System.Drawing.Point(89, 299);
            this.lblInternationalLicensesCount.Name = "lblInternationalLicensesCount";
            this.lblInternationalLicensesCount.Size = new System.Drawing.Size(15, 16);
            this.lblInternationalLicensesCount.TabIndex = 2;
            this.lblInternationalLicensesCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "International Licenses History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Records:";
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.dgvListInternationalLicenses.Location = new System.Drawing.Point(3, 40);
            this.dgvListInternationalLicenses.Name = "dgvListInternationalLicenses";
            this.dgvListInternationalLicenses.ReadOnly = true;
            this.dgvListInternationalLicenses.RowHeadersWidth = 51;
            this.dgvListInternationalLicenses.RowTemplate.Height = 24;
            this.dgvListInternationalLicenses.Size = new System.Drawing.Size(1141, 255);
            this.dgvListInternationalLicenses.TabIndex = 0;
            // 
            // colIntLicenseID
            // 
            this.colIntLicenseID.HeaderText = "Int.License ID";
            this.colIntLicenseID.MinimumWidth = 6;
            this.colIntLicenseID.Name = "colIntLicenseID";
            this.colIntLicenseID.ReadOnly = true;
            this.colIntLicenseID.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Application ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "License ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Issue Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Expiration Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is Active";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1179, 404);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalLicenses)).EndInit();
            this.tpInternational.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.DataGridView dgvListLocalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.Label lblLocalLicenseCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListInternationalLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
