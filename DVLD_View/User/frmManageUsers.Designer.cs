﻿namespace DVLD_View
{
    partial class frmManageUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilterUsers = new System.Windows.Forms.ComboBox();
			this.cmsUsersMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbIsActiveFilter = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.pbManagePeople = new System.Windows.Forms.PictureBox();
			this.dgvListUsers = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmsUsersMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(406, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "Manage Users";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(15, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "Filter By : ";
			// 
			// cbFilterUsers
			// 
			this.cbFilterUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFilterUsers.FormattingEnabled = true;
			this.cbFilterUsers.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "UserName",
            "Is Active"});
			this.cbFilterUsers.Location = new System.Drawing.Point(120, 205);
			this.cbFilterUsers.Name = "cbFilterUsers";
			this.cbFilterUsers.Size = new System.Drawing.Size(155, 33);
			this.cbFilterUsers.TabIndex = 7;
			this.cbFilterUsers.SelectedIndexChanged += new System.EventHandler(this.cbFilterUsers_SelectedIndexChanged);
			// 
			// cmsUsersMenu
			// 
			this.cmsUsersMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsUsersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripMenuItem1,
            this.tsmiAddNewUser,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiChangePassword,
            this.toolStripMenuItem2,
            this.tsmiSendEmail,
            this.tsmiPhoneCall});
			this.cmsUsersMenu.Name = "contextMenuStrip1";
			this.cmsUsersMenu.Size = new System.Drawing.Size(206, 282);
			// 
			// tsmiShowDetails
			// 
			this.tsmiShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDetails.Image")));
			this.tsmiShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiShowDetails.Name = "tsmiShowDetails";
			this.tsmiShowDetails.Size = new System.Drawing.Size(205, 38);
			this.tsmiShowDetails.Text = "Show Details";
			this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
			// 
			// tsmiAddNewUser
			// 
			this.tsmiAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddNewUser.Image")));
			this.tsmiAddNewUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiAddNewUser.Name = "tsmiAddNewUser";
			this.tsmiAddNewUser.Size = new System.Drawing.Size(205, 38);
			this.tsmiAddNewUser.Text = "Add New User";
			this.tsmiAddNewUser.Click += new System.EventHandler(this.tsmiAddNewUser_Click);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
			this.tsmiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(205, 38);
			this.tsmiEdit.Text = "Edit";
			this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
			this.tsmiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(205, 38);
			this.tsmiDelete.Text = "Delete";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// tsmiChangePassword
			// 
			this.tsmiChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsmiChangePassword.Image")));
			this.tsmiChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiChangePassword.Name = "tsmiChangePassword";
			this.tsmiChangePassword.Size = new System.Drawing.Size(205, 38);
			this.tsmiChangePassword.Text = "ChangePassword";
			this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 6);
			// 
			// tsmiSendEmail
			// 
			this.tsmiSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSendEmail.Image")));
			this.tsmiSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiSendEmail.Name = "tsmiSendEmail";
			this.tsmiSendEmail.Size = new System.Drawing.Size(205, 38);
			this.tsmiSendEmail.Text = "Send Email";
			this.tsmiSendEmail.Click += new System.EventHandler(this.tsmiSendEmail_Click);
			// 
			// tsmiPhoneCall
			// 
			this.tsmiPhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPhoneCall.Image")));
			this.tsmiPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsmiPhoneCall.Name = "tsmiPhoneCall";
			this.tsmiPhoneCall.Size = new System.Drawing.Size(205, 38);
			this.tsmiPhoneCall.Text = "Phone Call";
			this.tsmiPhoneCall.Click += new System.EventHandler(this.tsmiPhoneCall_Click);
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
			this.lblRecordsCount.Location = new System.Drawing.Point(100, 525);
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
			this.label3.Location = new System.Drawing.Point(12, 525);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "# Records:";
			// 
			// cbIsActiveFilter
			// 
			this.cbIsActiveFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIsActiveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbIsActiveFilter.FormattingEnabled = true;
			this.cbIsActiveFilter.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
			this.cbIsActiveFilter.Location = new System.Drawing.Point(280, 205);
			this.cbIsActiveFilter.Name = "cbIsActiveFilter";
			this.cbIsActiveFilter.Size = new System.Drawing.Size(155, 33);
			this.cbIsActiveFilter.TabIndex = 16;
			this.cbIsActiveFilter.Visible = false;
			this.cbIsActiveFilter.SelectedIndexChanged += new System.EventHandler(this.cbIsActiveFilter_SelectedIndexChanged);
			// 
			// txtFilter
			// 
			this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilter.Location = new System.Drawing.Point(280, 206);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(225, 30);
			this.txtFilter.TabIndex = 15;
			this.txtFilter.Visible = false;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::DVLD_View.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(847, 520);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 47);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.White;
			this.btnAddNew.BackgroundImage = global::DVLD_View.Properties.Resources.Add_New_User_72;
			this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Location = new System.Drawing.Point(905, 180);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(79, 58);
			this.btnAddNew.TabIndex = 9;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// pbManagePeople
			// 
			this.pbManagePeople.BackColor = System.Drawing.Color.Transparent;
			this.pbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pbManagePeople.Image")));
			this.pbManagePeople.Location = new System.Drawing.Point(376, 0);
			this.pbManagePeople.Name = "pbManagePeople";
			this.pbManagePeople.Size = new System.Drawing.Size(243, 134);
			this.pbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbManagePeople.TabIndex = 4;
			this.pbManagePeople.TabStop = false;
			// 
			// dgvListUsers
			// 
			this.dgvListUsers.AllowUserToAddRows = false;
			this.dgvListUsers.AllowUserToDeleteRows = false;
			this.dgvListUsers.AllowUserToOrderColumns = true;
			this.dgvListUsers.BackgroundColor = System.Drawing.Color.White;
			this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListUsers.ContextMenuStrip = this.cmsUsersMenu;
			this.dgvListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvListUsers.Location = new System.Drawing.Point(0, 0);
			this.dgvListUsers.Name = "dgvListUsers";
			this.dgvListUsers.ReadOnly = true;
			this.dgvListUsers.RowHeadersWidth = 51;
			this.dgvListUsers.RowTemplate.Height = 24;
			this.dgvListUsers.Size = new System.Drawing.Size(972, 276);
			this.dgvListUsers.TabIndex = 10;
			this.dgvListUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvListUsers_MouseDoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvListUsers);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(12, 243);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(972, 276);
			this.panel1.TabIndex = 17;
			// 
			// frmManageUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(996, 578);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cbFilterUsers);
			this.Controls.Add(this.cbIsActiveFilter);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pbManagePeople);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Users";
			this.Load += new System.EventHandler(this.frmManageUsers_Load);
			this.cmsUsersMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManagePeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterUsers;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIsActiveFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ContextMenuStrip cmsUsersMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
		private System.Windows.Forms.DataGridView dgvListUsers;
		private System.Windows.Forms.Panel panel1;
	}
}