﻿namespace DVLD_View
{
    partial class frmManageTestTypes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
			this.label1 = new System.Windows.Forms.Label();
			this.dgvListTestTypes = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiEditApplicationTypeInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.pbManagePeople = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvListTestTypes)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(320, 160);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 36);
			this.label1.TabIndex = 6;
			this.label1.Text = "Manage Test Types";
			// 
			// dgvListTestTypes
			// 
			this.dgvListTestTypes.AllowUserToAddRows = false;
			this.dgvListTestTypes.AllowUserToDeleteRows = false;
			this.dgvListTestTypes.AllowUserToOrderColumns = true;
			this.dgvListTestTypes.BackgroundColor = System.Drawing.Color.White;
			this.dgvListTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListTestTypes.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvListTestTypes.Location = new System.Drawing.Point(13, 227);
			this.dgvListTestTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvListTestTypes.Name = "dgvListTestTypes";
			this.dgvListTestTypes.ReadOnly = true;
			this.dgvListTestTypes.RowHeadersWidth = 51;
			this.dgvListTestTypes.RowTemplate.Height = 24;
			this.dgvListTestTypes.Size = new System.Drawing.Size(872, 292);
			this.dgvListTestTypes.TabIndex = 7;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditApplicationTypeInfo});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(186, 42);
			// 
			// tsmiEditApplicationTypeInfo
			// 
			this.tsmiEditApplicationTypeInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditApplicationTypeInfo.Image")));
			this.tsmiEditApplicationTypeInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiEditApplicationTypeInfo.Name = "tsmiEditApplicationTypeInfo";
			this.tsmiEditApplicationTypeInfo.Size = new System.Drawing.Size(185, 38);
			this.tsmiEditApplicationTypeInfo.Text = "Edit Test Type";
			this.tsmiEditApplicationTypeInfo.Click += new System.EventHandler(this.tsmiEditApplicationTypeInfo_Click);
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
			this.lblRecordsCount.Location = new System.Drawing.Point(97, 526);
			this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
			this.label3.Location = new System.Drawing.Point(16, 524);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "# Records:";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(741, 523);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(144, 39);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbManagePeople
			// 
			this.pbManagePeople.BackColor = System.Drawing.Color.Transparent;
			this.pbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pbManagePeople.Image")));
			this.pbManagePeople.Location = new System.Drawing.Point(310, 4);
			this.pbManagePeople.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.pbManagePeople.Name = "pbManagePeople";
			this.pbManagePeople.Size = new System.Drawing.Size(273, 147);
			this.pbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbManagePeople.TabIndex = 5;
			this.pbManagePeople.TabStop = false;
			// 
			// frmManageTestTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(898, 586);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvListTestTypes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbManagePeople);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmManageTestTypes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Test Types";
			this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListTestTypes)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManagePeople;
        private System.Windows.Forms.DataGridView dgvListTestTypes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplicationTypeInfo;
    }
}