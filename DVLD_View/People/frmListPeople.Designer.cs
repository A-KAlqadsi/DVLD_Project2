namespace DVLD_View
{
    partial class frmListPeople
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
			this.dgvListPeople = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.cbFilterPeople = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.pbManagePeople = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddPerson = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvListPeople
			// 
			this.dgvListPeople.AllowUserToAddRows = false;
			this.dgvListPeople.AllowUserToDeleteRows = false;
			this.dgvListPeople.AllowUserToOrderColumns = true;
			this.dgvListPeople.BackgroundColor = System.Drawing.Color.White;
			this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListPeople.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvListPeople.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvListPeople.Location = new System.Drawing.Point(0, 0);
			this.dgvListPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvListPeople.Name = "dgvListPeople";
			this.dgvListPeople.ReadOnly = true;
			this.dgvListPeople.RowHeadersWidth = 51;
			this.dgvListPeople.RowTemplate.Height = 24;
			this.dgvListPeople.Size = new System.Drawing.Size(1360, 336);
			this.dgvListPeople.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripMenuItem1,
            this.tsmiAddNewPerson,
            this.tsmiEdit,
            this.tsmiDelete,
            this.toolStripMenuItem2,
            this.tsmiSendEmail,
            this.tsmiPhoneCall});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(204, 244);
			// 
			// tsmiShowDetails
			// 
			this.tsmiShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDetails.Image")));
			this.tsmiShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowDetails.Name = "tsmiShowDetails";
			this.tsmiShowDetails.Size = new System.Drawing.Size(203, 38);
			this.tsmiShowDetails.Text = "Show Details";
			this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
			// 
			// tsmiAddNewPerson
			// 
			this.tsmiAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddNewPerson.Image")));
			this.tsmiAddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiAddNewPerson.Name = "tsmiAddNewPerson";
			this.tsmiAddNewPerson.Size = new System.Drawing.Size(203, 38);
			this.tsmiAddNewPerson.Text = "Add New Person";
			this.tsmiAddNewPerson.Click += new System.EventHandler(this.tsmiAddNewPerson_Click);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
			this.tsmiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(203, 38);
			this.tsmiEdit.Text = "Edit";
			this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
			this.tsmiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(203, 38);
			this.tsmiDelete.Text = "Delete";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
			// 
			// tsmiSendEmail
			// 
			this.tsmiSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSendEmail.Image")));
			this.tsmiSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiSendEmail.Name = "tsmiSendEmail";
			this.tsmiSendEmail.Size = new System.Drawing.Size(203, 38);
			this.tsmiSendEmail.Text = "Send Email";
			this.tsmiSendEmail.Click += new System.EventHandler(this.tsmiSendEmail_Click);
			// 
			// tsmiPhoneCall
			// 
			this.tsmiPhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPhoneCall.Image")));
			this.tsmiPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiPhoneCall.Name = "tsmiPhoneCall";
			this.tsmiPhoneCall.Size = new System.Drawing.Size(203, 38);
			this.tsmiPhoneCall.Text = "Phone Call";
			this.tsmiPhoneCall.Click += new System.EventHandler(this.tsmiPhoneCall_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(615, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "Manage People";
			// 
			// cbFilterPeople
			// 
			this.cbFilterPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFilterPeople.FormattingEnabled = true;
			this.cbFilterPeople.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
			this.cbFilterPeople.Location = new System.Drawing.Point(118, 181);
			this.cbFilterPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbFilterPeople.Name = "cbFilterPeople";
			this.cbFilterPeople.Size = new System.Drawing.Size(208, 33);
			this.cbFilterPeople.TabIndex = 0;
			this.cbFilterPeople.SelectedIndexChanged += new System.EventHandler(this.cbFilterPeople_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(19, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Filter By :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(21, 560);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "# Records:";
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
			this.lblRecordsCount.Location = new System.Drawing.Point(89, 560);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(15, 16);
			this.lblRecordsCount.TabIndex = 8;
			this.lblRecordsCount.Text = "0";
			// 
			// txtFilter
			// 
			this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilter.Location = new System.Drawing.Point(332, 184);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(223, 30);
			this.txtFilter.TabIndex = 1;
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
			this.btnClose.Location = new System.Drawing.Point(1614, 616);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(155, 53);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.White;
			this.btnAddNew.BackgroundImage = global::DVLD_View.Properties.Resources.Add_Person_40;
			this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Location = new System.Drawing.Point(1602, 164);
			this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(100, 66);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// pbManagePeople
			// 
			this.pbManagePeople.BackColor = System.Drawing.Color.Transparent;
			this.pbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pbManagePeople.Image")));
			this.pbManagePeople.Location = new System.Drawing.Point(598, 6);
			this.pbManagePeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbManagePeople.Name = "pbManagePeople";
			this.pbManagePeople.Size = new System.Drawing.Size(248, 136);
			this.pbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbManagePeople.TabIndex = 1;
			this.pbManagePeople.TabStop = false;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(1284, 560);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 29);
			this.button1.TabIndex = 93;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvListPeople);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(24, 219);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1360, 336);
			this.panel1.TabIndex = 94;
			// 
			// btnAddPerson
			// 
			this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPerson.Image = global::DVLD_View.Properties.Resources.Add_Person_40;
			this.btnAddPerson.Location = new System.Drawing.Point(1296, 159);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(88, 55);
			this.btnAddPerson.TabIndex = 95;
			this.btnAddPerson.UseVisualStyleBackColor = true;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
			// 
			// frmListPeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1396, 595);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.cbFilterPeople);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbManagePeople);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmListPeople";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage People";
			this.Load += new System.EventHandler(this.frmListPeople_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPeople;
        private System.Windows.Forms.PictureBox pbManagePeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterPeople;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhoneCall;
        private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddPerson;
	}
}