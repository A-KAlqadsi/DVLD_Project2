﻿namespace DVLD_View.User
{
	partial class frmAddUpdateUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
			this.lblMode = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpPersonalInfo = new System.Windows.Forms.TabPage();
			this.tpLoginInfo = new System.Windows.Forms.TabPage();
			this.ctrlPersonCardWithFilter1 = new DVLD_View.ctrlPersonCardWithFilter();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnPersonInfoNext = new System.Windows.Forms.Button();
			this.lblUserID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl1.SuspendLayout();
			this.tpPersonalInfo.SuspendLayout();
			this.tpLoginInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMode
			// 
			this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblMode.Location = new System.Drawing.Point(12, 9);
			this.lblMode.Name = "lblMode";
			this.lblMode.Size = new System.Drawing.Size(934, 36);
			this.lblMode.TabIndex = 6;
			this.lblMode.Text = "Add New User";
			this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpPersonalInfo);
			this.tabControl1.Controls.Add(this.tpLoginInfo);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(943, 444);
			this.tabControl1.TabIndex = 7;
			// 
			// tpPersonalInfo
			// 
			this.tpPersonalInfo.Controls.Add(this.btnPersonInfoNext);
			this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
			this.tpPersonalInfo.Location = new System.Drawing.Point(4, 34);
			this.tpPersonalInfo.Name = "tpPersonalInfo";
			this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpPersonalInfo.Size = new System.Drawing.Size(935, 406);
			this.tpPersonalInfo.TabIndex = 0;
			this.tpPersonalInfo.Text = "Personal Info";
			this.tpPersonalInfo.UseVisualStyleBackColor = true;
			// 
			// tpLoginInfo
			// 
			this.tpLoginInfo.Controls.Add(this.pictureBox2);
			this.tpLoginInfo.Controls.Add(this.lblUserID);
			this.tpLoginInfo.Controls.Add(this.label4);
			this.tpLoginInfo.Controls.Add(this.chkIsActive);
			this.tpLoginInfo.Controls.Add(this.txtUserName);
			this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
			this.tpLoginInfo.Controls.Add(this.label1);
			this.tpLoginInfo.Controls.Add(this.label3);
			this.tpLoginInfo.Controls.Add(this.label2);
			this.tpLoginInfo.Controls.Add(this.txtPassword);
			this.tpLoginInfo.Controls.Add(this.pictureBox1);
			this.tpLoginInfo.Controls.Add(this.pictureBox8);
			this.tpLoginInfo.Controls.Add(this.pictureBox3);
			this.tpLoginInfo.Location = new System.Drawing.Point(4, 34);
			this.tpLoginInfo.Name = "tpLoginInfo";
			this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpLoginInfo.Size = new System.Drawing.Size(935, 406);
			this.tpLoginInfo.TabIndex = 1;
			this.tpLoginInfo.Text = "Login Info";
			this.tpLoginInfo.UseVisualStyleBackColor = true;
			// 
			// ctrlPersonCardWithFilter1
			// 
			this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
			this.ctrlPersonCardWithFilter1.FilterEnabled = true;
			this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(9, 5);
			this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
			this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
			this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(913, 344);
			this.ctrlPersonCardWithFilter1.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(686, 494);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(126, 37);
			this.btnClose.TabIndex = 115;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(820, 494);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(126, 37);
			this.btnSave.TabIndex = 114;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnPersonInfoNext
			// 
			this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPersonInfoNext.Location = new System.Drawing.Point(790, 352);
			this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPersonInfoNext.Name = "btnPersonInfoNext";
			this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 37);
			this.btnPersonInfoNext.TabIndex = 120;
			this.btnPersonInfoNext.Text = "Next";
			this.btnPersonInfoNext.UseVisualStyleBackColor = true;
			this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
			// 
			// lblUserID
			// 
			this.lblUserID.AutoSize = true;
			this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserID.Location = new System.Drawing.Point(256, 63);
			this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.Size = new System.Drawing.Size(48, 25);
			this.lblUserID.TabIndex = 142;
			this.lblUserID.Text = "???";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(123, 63);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 25);
			this.label4.TabIndex = 141;
			this.label4.Text = "UserID:";
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Checked = true;
			this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsActive.Location = new System.Drawing.Point(254, 213);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(108, 29);
			this.chkIsActive.TabIndex = 140;
			this.chkIsActive.Text = "Is Active";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(254, 101);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUserName.MaxLength = 50;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(195, 30);
			this.txtUserName.TabIndex = 131;
			this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(254, 173);
			this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtConfirmPassword.MaxLength = 50;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(195, 30);
			this.txtConfirmPassword.TabIndex = 137;
			this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 101);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 25);
			this.label1.TabIndex = 133;
			this.label1.Text = "UserName:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 173);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 25);
			this.label3.TabIndex = 138;
			this.label3.Text = "Confirm Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(95, 137);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 25);
			this.label2.TabIndex = 134;
			this.label2.Text = "Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(254, 137);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPassword.MaxLength = 50;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(195, 30);
			this.txtPassword.TabIndex = 132;
			this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(216, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 143;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(216, 173);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 139;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(216, 99);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(31, 26);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 136;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::DVLD_View.Properties.Resources.Password_32;
			this.pictureBox3.Location = new System.Drawing.Point(216, 136);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(31, 26);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 135;
			this.pictureBox3.TabStop = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmAddUpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(955, 552);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lblMode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddUpdateUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddUpdateUser";
			this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
			this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
			this.tabControl1.ResumeLayout(false);
			this.tpPersonalInfo.ResumeLayout(false);
			this.tpLoginInfo.ResumeLayout(false);
			this.tpLoginInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblMode;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpPersonalInfo;
		private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
		private System.Windows.Forms.TabPage tpLoginInfo;
		private System.Windows.Forms.Button btnPersonInfoNext;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}