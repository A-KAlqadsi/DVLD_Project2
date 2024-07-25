namespace DVLD_View
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            this.label1 = new System.Windows.Forms.Label();
            this.pbManagePeople = new System.Windows.Forms.PictureBox();
            this.dgvListApplicationTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditApplicationTypeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(172, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Application Types";
            // 
            // pbManagePeople
            // 
            this.pbManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.pbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pbManagePeople.Image")));
            this.pbManagePeople.Location = new System.Drawing.Point(188, 0);
            this.pbManagePeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbManagePeople.Name = "pbManagePeople";
            this.pbManagePeople.Size = new System.Drawing.Size(314, 136);
            this.pbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeople.TabIndex = 3;
            this.pbManagePeople.TabStop = false;
            // 
            // dgvListApplicationTypes
            // 
            this.dgvListApplicationTypes.AllowUserToAddRows = false;
            this.dgvListApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvListApplicationTypes.AllowUserToOrderColumns = true;
            this.dgvListApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListApplicationTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colFees});
            this.dgvListApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListApplicationTypes.Location = new System.Drawing.Point(12, 187);
            this.dgvListApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListApplicationTypes.Name = "dgvListApplicationTypes";
            this.dgvListApplicationTypes.ReadOnly = true;
            this.dgvListApplicationTypes.RowHeadersWidth = 51;
            this.dgvListApplicationTypes.RowTemplate.Height = 24;
            this.dgvListApplicationTypes.Size = new System.Drawing.Size(655, 308);
            this.dgvListApplicationTypes.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditApplicationTypeInfo});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 42);
            // 
            // tsmiEditApplicationTypeInfo
            // 
            this.tsmiEditApplicationTypeInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditApplicationTypeInfo.Image")));
            this.tsmiEditApplicationTypeInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditApplicationTypeInfo.Name = "tsmiEditApplicationTypeInfo";
            this.tsmiEditApplicationTypeInfo.Size = new System.Drawing.Size(236, 38);
            this.tsmiEditApplicationTypeInfo.Text = "Edit Application Type";
            this.tsmiEditApplicationTypeInfo.Click += new System.EventHandler(this.tsmiEditApplicationTypeInfo_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(91, 501);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
            this.lblRecordsCount.TabIndex = 10;
            this.lblRecordsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 501);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "# Records:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(523, 499);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 90;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 400;
            // 
            // colFees
            // 
            this.colFees.HeaderText = "Fees";
            this.colFees.MinimumWidth = 6;
            this.colFees.Name = "colFees";
            this.colFees.ReadOnly = true;
            this.colFees.Width = 90;
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListApplicationTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbManagePeople);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManagePeople;
        private System.Windows.Forms.DataGridView dgvListApplicationTypes;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplicationTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFees;
    }
}