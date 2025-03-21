﻿namespace DVLD_View
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicenses));
			this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
			this.tcDriverLicenses = new System.Windows.Forms.TabControl();
			this.tpLocal = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblLocalLicenseCount = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvListLocalLicenses = new System.Windows.Forms.DataGridView();
			this.cmsShowLocalLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiShowLocalLicenseInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.tpInternational = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblInternationalLicensesCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvListInternationalLicenses = new System.Windows.Forms.DataGridView();
			this.cmsShowInterLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiShowInterLicenseInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.gbDriverLicenses.SuspendLayout();
			this.tcDriverLicenses.SuspendLayout();
			this.tpLocal.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListLocalLicenses)).BeginInit();
			this.cmsShowLocalLicenseInfo.SuspendLayout();
			this.tpInternational.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).BeginInit();
			this.cmsShowInterLicenseInfo.SuspendLayout();
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
			this.dgvListLocalLicenses.ContextMenuStrip = this.cmsShowLocalLicenseInfo;
			this.dgvListLocalLicenses.Location = new System.Drawing.Point(3, 40);
			this.dgvListLocalLicenses.Name = "dgvListLocalLicenses";
			this.dgvListLocalLicenses.ReadOnly = true;
			this.dgvListLocalLicenses.RowHeadersWidth = 51;
			this.dgvListLocalLicenses.RowTemplate.Height = 24;
			this.dgvListLocalLicenses.Size = new System.Drawing.Size(1141, 254);
			this.dgvListLocalLicenses.TabIndex = 0;
			// 
			// cmsShowLocalLicenseInfo
			// 
			this.cmsShowLocalLicenseInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsShowLocalLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowLocalLicenseInfo});
			this.cmsShowLocalLicenseInfo.Name = "cmsShowLocalLicenseInfo";
			this.cmsShowLocalLicenseInfo.Size = new System.Drawing.Size(232, 42);
			// 
			// tsmiShowLocalLicenseInfo
			// 
			this.tsmiShowLocalLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiShowLocalLicenseInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowLocalLicenseInfo.Image")));
			this.tsmiShowLocalLicenseInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowLocalLicenseInfo.Name = "tsmiShowLocalLicenseInfo";
			this.tsmiShowLocalLicenseInfo.Size = new System.Drawing.Size(231, 38);
			this.tsmiShowLocalLicenseInfo.Text = "Show License Info";
			this.tsmiShowLocalLicenseInfo.Click += new System.EventHandler(this.tsmiShowLocalLicenseInfo_Click);
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
			this.dgvListInternationalLicenses.ContextMenuStrip = this.cmsShowInterLicenseInfo;
			this.dgvListInternationalLicenses.Location = new System.Drawing.Point(3, 40);
			this.dgvListInternationalLicenses.Name = "dgvListInternationalLicenses";
			this.dgvListInternationalLicenses.ReadOnly = true;
			this.dgvListInternationalLicenses.RowHeadersWidth = 51;
			this.dgvListInternationalLicenses.RowTemplate.Height = 24;
			this.dgvListInternationalLicenses.Size = new System.Drawing.Size(1141, 255);
			this.dgvListInternationalLicenses.TabIndex = 0;
			// 
			// cmsShowInterLicenseInfo
			// 
			this.cmsShowInterLicenseInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsShowInterLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowInterLicenseInfo});
			this.cmsShowInterLicenseInfo.Name = "cmsShowInterLicenseInfo";
			this.cmsShowInterLicenseInfo.Size = new System.Drawing.Size(232, 42);
			// 
			// tsmiShowInterLicenseInfo
			// 
			this.tsmiShowInterLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiShowInterLicenseInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowInterLicenseInfo.Image")));
			this.tsmiShowInterLicenseInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowInterLicenseInfo.Name = "tsmiShowInterLicenseInfo";
			this.tsmiShowInterLicenseInfo.Size = new System.Drawing.Size(231, 38);
			this.tsmiShowInterLicenseInfo.Text = "Show License Info";
			this.tsmiShowInterLicenseInfo.Click += new System.EventHandler(this.tsmiShowInterLicenseInfo_Click);
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
			this.cmsShowLocalLicenseInfo.ResumeLayout(false);
			this.tpInternational.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).EndInit();
			this.cmsShowInterLicenseInfo.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblLocalLicenseCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsShowLocalLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLocalLicenseInfo;
        private System.Windows.Forms.ContextMenuStrip cmsShowInterLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInterLicenseInfo;
    }
}
