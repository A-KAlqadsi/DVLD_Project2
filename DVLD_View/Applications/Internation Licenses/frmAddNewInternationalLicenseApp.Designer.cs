namespace DVLD_View
{
    partial class frmAddNewInternationalLicenseApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewInternationalLicenseApp));
			this.label1 = new System.Windows.Forms.Label();
			this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
			this.llShowLicense = new System.Windows.Forms.LinkLabel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnIssue = new System.Windows.Forms.Button();
			this.ctrlDriverLicenseCardWithFilter1 = new DVLD_View.ctrlDriverLicenseCardWithFilter();
			this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
			this.pbUser = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.pbFees = new System.Windows.Forms.PictureBox();
			this.lblAppFees = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblILAppID = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pbExpirationDate = new System.Windows.Forms.PictureBox();
			this.lblExpirationDate = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pbDateOfBirth = new System.Windows.Forms.PictureBox();
			this.lblApplicationDate = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pbIssueDate = new System.Windows.Forms.PictureBox();
			this.lblIssueDate = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pbLicenseID = new System.Windows.Forms.PictureBox();
			this.lblLicenseID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pbIntLicenseID = new System.Windows.Forms.PictureBox();
			this.lblIntLicenseID = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gbApplicationInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExpirationDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIssueDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicenseID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIntLicenseID)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(299, 2);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(447, 36);
			this.label1.TabIndex = 7;
			this.label1.Text = "International License Application";
			// 
			// llShowLicenseHistory
			// 
			this.llShowLicenseHistory.AutoSize = true;
			this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseHistory.Location = new System.Drawing.Point(23, 733);
			this.llShowLicenseHistory.Name = "llShowLicenseHistory";
			this.llShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
			this.llShowLicenseHistory.TabIndex = 104;
			this.llShowLicenseHistory.TabStop = true;
			this.llShowLicenseHistory.Text = "Show License History";
			this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
			// 
			// llShowLicense
			// 
			this.llShowLicense.AutoSize = true;
			this.llShowLicense.Enabled = false;
			this.llShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicense.Location = new System.Drawing.Point(208, 734);
			this.llShowLicense.Name = "llShowLicense";
			this.llShowLicense.Size = new System.Drawing.Size(114, 20);
			this.llShowLicense.TabIndex = 105;
			this.llShowLicense.TabStop = true;
			this.llShowLicense.Text = "Show License";
			this.llShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicense_LinkClicked);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(751, 729);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 43);
			this.btnClose.TabIndex = 103;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnIssue
			// 
			this.btnIssue.BackColor = System.Drawing.Color.White;
			this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnIssue.Enabled = false;
			this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
			this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIssue.Location = new System.Drawing.Point(895, 728);
			this.btnIssue.Name = "btnIssue";
			this.btnIssue.Size = new System.Drawing.Size(138, 44);
			this.btnIssue.TabIndex = 102;
			this.btnIssue.Text = "Issue";
			this.btnIssue.UseVisualStyleBackColor = false;
			this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
			// 
			// ctrlDriverLicenseCardWithFilter1
			// 
			this.ctrlDriverLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
			this.ctrlDriverLicenseCardWithFilter1.FilterEnabled = true;
			this.ctrlDriverLicenseCardWithFilter1.Location = new System.Drawing.Point(21, 46);
			this.ctrlDriverLicenseCardWithFilter1.Name = "ctrlDriverLicenseCardWithFilter1";
			this.ctrlDriverLicenseCardWithFilter1.Size = new System.Drawing.Size(1021, 444);
			this.ctrlDriverLicenseCardWithFilter1.TabIndex = 0;
			this.ctrlDriverLicenseCardWithFilter1.OnLicenseSelected += new System.EventHandler<DVLD_View.ctrlDriverLicenseCardWithFilter.OnLicenseSelectedEventArgs>(this.ctrlDriverLicenseCardWithFilter1_OnLicenseSelected);
			// 
			// gbApplicationInfo
			// 
			this.gbApplicationInfo.Controls.Add(this.pbUser);
			this.gbApplicationInfo.Controls.Add(this.lblUsername);
			this.gbApplicationInfo.Controls.Add(this.label19);
			this.gbApplicationInfo.Controls.Add(this.pbFees);
			this.gbApplicationInfo.Controls.Add(this.lblAppFees);
			this.gbApplicationInfo.Controls.Add(this.label2);
			this.gbApplicationInfo.Controls.Add(this.pictureBox1);
			this.gbApplicationInfo.Controls.Add(this.lblILAppID);
			this.gbApplicationInfo.Controls.Add(this.label9);
			this.gbApplicationInfo.Controls.Add(this.pbExpirationDate);
			this.gbApplicationInfo.Controls.Add(this.lblExpirationDate);
			this.gbApplicationInfo.Controls.Add(this.label10);
			this.gbApplicationInfo.Controls.Add(this.pbDateOfBirth);
			this.gbApplicationInfo.Controls.Add(this.lblApplicationDate);
			this.gbApplicationInfo.Controls.Add(this.label14);
			this.gbApplicationInfo.Controls.Add(this.pbIssueDate);
			this.gbApplicationInfo.Controls.Add(this.lblIssueDate);
			this.gbApplicationInfo.Controls.Add(this.label6);
			this.gbApplicationInfo.Controls.Add(this.pbLicenseID);
			this.gbApplicationInfo.Controls.Add(this.lblLicenseID);
			this.gbApplicationInfo.Controls.Add(this.label4);
			this.gbApplicationInfo.Controls.Add(this.pbIntLicenseID);
			this.gbApplicationInfo.Controls.Add(this.lblIntLicenseID);
			this.gbApplicationInfo.Controls.Add(this.label3);
			this.gbApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbApplicationInfo.Location = new System.Drawing.Point(33, 489);
			this.gbApplicationInfo.Name = "gbApplicationInfo";
			this.gbApplicationInfo.Size = new System.Drawing.Size(1002, 233);
			this.gbApplicationInfo.TabIndex = 106;
			this.gbApplicationInfo.TabStop = false;
			this.gbApplicationInfo.Text = "Application Info";
			// 
			// pbUser
			// 
			this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
			this.pbUser.Location = new System.Drawing.Point(693, 183);
			this.pbUser.Margin = new System.Windows.Forms.Padding(2);
			this.pbUser.Name = "pbUser";
			this.pbUser.Size = new System.Drawing.Size(39, 35);
			this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbUser.TabIndex = 87;
			this.pbUser.TabStop = false;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(747, 188);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(68, 25);
			this.lblUsername.TabIndex = 86;
			this.lblUsername.Text = "[????]";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(541, 188);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(127, 25);
			this.label19.TabIndex = 85;
			this.label19.Text = "Created By:";
			// 
			// pbFees
			// 
			this.pbFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
			this.pbFees.Location = new System.Drawing.Point(232, 185);
			this.pbFees.Margin = new System.Windows.Forms.Padding(2);
			this.pbFees.Name = "pbFees";
			this.pbFees.Size = new System.Drawing.Size(39, 30);
			this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbFees.TabIndex = 84;
			this.pbFees.TabStop = false;
			// 
			// lblAppFees
			// 
			this.lblAppFees.AutoSize = true;
			this.lblAppFees.Location = new System.Drawing.Point(284, 188);
			this.lblAppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppFees.Name = "lblAppFees";
			this.lblAppFees.Size = new System.Drawing.Size(68, 25);
			this.lblAppFees.TabIndex = 83;
			this.lblAppFees.Text = "[????]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(144, 188);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 25);
			this.label2.TabIndex = 82;
			this.label2.Text = "Fees:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(232, 59);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 81;
			this.pictureBox1.TabStop = false;
			// 
			// lblILAppID
			// 
			this.lblILAppID.AutoSize = true;
			this.lblILAppID.Location = new System.Drawing.Point(284, 62);
			this.lblILAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblILAppID.Name = "lblILAppID";
			this.lblILAppID.Size = new System.Drawing.Size(68, 25);
			this.lblILAppID.TabIndex = 80;
			this.lblILAppID.Text = "[????]";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(28, 62);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(183, 25);
			this.label9.TabIndex = 79;
			this.label9.Text = "I.L Application ID:";
			// 
			// pbExpirationDate
			// 
			this.pbExpirationDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbExpirationDate.Image = ((System.Drawing.Image)(resources.GetObject("pbExpirationDate.Image")));
			this.pbExpirationDate.Location = new System.Drawing.Point(693, 142);
			this.pbExpirationDate.Margin = new System.Windows.Forms.Padding(2);
			this.pbExpirationDate.Name = "pbExpirationDate";
			this.pbExpirationDate.Size = new System.Drawing.Size(39, 30);
			this.pbExpirationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbExpirationDate.TabIndex = 76;
			this.pbExpirationDate.TabStop = false;
			// 
			// lblExpirationDate
			// 
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.Location = new System.Drawing.Point(747, 145);
			this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblExpirationDate.Name = "lblExpirationDate";
			this.lblExpirationDate.Size = new System.Drawing.Size(68, 25);
			this.lblExpirationDate.TabIndex = 78;
			this.lblExpirationDate.Text = "[????]";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(502, 145);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(166, 25);
			this.label10.TabIndex = 77;
			this.label10.Text = "Expiration Date:";
			// 
			// pbDateOfBirth
			// 
			this.pbDateOfBirth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("pbDateOfBirth.Image")));
			this.pbDateOfBirth.Location = new System.Drawing.Point(232, 99);
			this.pbDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
			this.pbDateOfBirth.Name = "pbDateOfBirth";
			this.pbDateOfBirth.Size = new System.Drawing.Size(39, 30);
			this.pbDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDateOfBirth.TabIndex = 67;
			this.pbDateOfBirth.TabStop = false;
			// 
			// lblApplicationDate
			// 
			this.lblApplicationDate.AutoSize = true;
			this.lblApplicationDate.Location = new System.Drawing.Point(284, 102);
			this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblApplicationDate.Name = "lblApplicationDate";
			this.lblApplicationDate.Size = new System.Drawing.Size(123, 25);
			this.lblApplicationDate.TabIndex = 70;
			this.lblApplicationDate.Text = "3/NOV/2004";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(34, 102);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(177, 25);
			this.label14.TabIndex = 69;
			this.label14.Text = "Application Date:";
			// 
			// pbIssueDate
			// 
			this.pbIssueDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbIssueDate.Image = ((System.Drawing.Image)(resources.GetObject("pbIssueDate.Image")));
			this.pbIssueDate.Location = new System.Drawing.Point(232, 142);
			this.pbIssueDate.Margin = new System.Windows.Forms.Padding(2);
			this.pbIssueDate.Name = "pbIssueDate";
			this.pbIssueDate.Size = new System.Drawing.Size(39, 30);
			this.pbIssueDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIssueDate.TabIndex = 64;
			this.pbIssueDate.TabStop = false;
			// 
			// lblIssueDate
			// 
			this.lblIssueDate.AutoSize = true;
			this.lblIssueDate.Location = new System.Drawing.Point(284, 145);
			this.lblIssueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIssueDate.Name = "lblIssueDate";
			this.lblIssueDate.Size = new System.Drawing.Size(114, 25);
			this.lblIssueDate.TabIndex = 66;
			this.lblIssueDate.Text = "2/Nov/2024";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(89, 145);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 25);
			this.label6.TabIndex = 65;
			this.label6.Text = "Issue Date:";
			// 
			// pbLicenseID
			// 
			this.pbLicenseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("pbLicenseID.Image")));
			this.pbLicenseID.Location = new System.Drawing.Point(693, 99);
			this.pbLicenseID.Margin = new System.Windows.Forms.Padding(2);
			this.pbLicenseID.Name = "pbLicenseID";
			this.pbLicenseID.Size = new System.Drawing.Size(39, 30);
			this.pbLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLicenseID.TabIndex = 61;
			this.pbLicenseID.TabStop = false;
			// 
			// lblLicenseID
			// 
			this.lblLicenseID.AutoSize = true;
			this.lblLicenseID.Location = new System.Drawing.Point(747, 102);
			this.lblLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLicenseID.Name = "lblLicenseID";
			this.lblLicenseID.Size = new System.Drawing.Size(68, 25);
			this.lblLicenseID.TabIndex = 63;
			this.lblLicenseID.Text = "[????]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(489, 102);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 25);
			this.label4.TabIndex = 62;
			this.label4.Text = "Local License ID:";
			// 
			// pbIntLicenseID
			// 
			this.pbIntLicenseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbIntLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("pbIntLicenseID.Image")));
			this.pbIntLicenseID.Location = new System.Drawing.Point(693, 59);
			this.pbIntLicenseID.Margin = new System.Windows.Forms.Padding(2);
			this.pbIntLicenseID.Name = "pbIntLicenseID";
			this.pbIntLicenseID.Size = new System.Drawing.Size(39, 30);
			this.pbIntLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIntLicenseID.TabIndex = 60;
			this.pbIntLicenseID.TabStop = false;
			// 
			// lblIntLicenseID
			// 
			this.lblIntLicenseID.AutoSize = true;
			this.lblIntLicenseID.Location = new System.Drawing.Point(747, 62);
			this.lblIntLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIntLicenseID.Name = "lblIntLicenseID";
			this.lblIntLicenseID.Size = new System.Drawing.Size(68, 25);
			this.lblIntLicenseID.TabIndex = 55;
			this.lblIntLicenseID.Text = "[????]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(517, 62);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 25);
			this.label3.TabIndex = 52;
			this.label3.Text = "Int.License ID:";
			// 
			// frmAddNewInternationalLicenseApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1061, 787);
			this.Controls.Add(this.gbApplicationInfo);
			this.Controls.Add(this.llShowLicense);
			this.Controls.Add(this.llShowLicenseHistory);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnIssue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrlDriverLicenseCardWithFilter1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddNewInternationalLicenseApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New International License App";
			this.Load += new System.EventHandler(this.frmAddNewInternationalLicenseApp_Load);
			this.gbApplicationInfo.ResumeLayout(false);
			this.gbApplicationInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExpirationDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIssueDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicenseID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIntLicenseID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseCardWithFilter ctrlDriverLicenseCardWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llShowLicense;
		private System.Windows.Forms.GroupBox gbApplicationInfo;
		private System.Windows.Forms.PictureBox pbUser;
		public System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.PictureBox pbFees;
		public System.Windows.Forms.Label lblAppFees;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblILAppID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbExpirationDate;
		public System.Windows.Forms.Label lblExpirationDate;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pbDateOfBirth;
		public System.Windows.Forms.Label lblApplicationDate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pbIssueDate;
		public System.Windows.Forms.Label lblIssueDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pbLicenseID;
		public System.Windows.Forms.Label lblLicenseID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pbIntLicenseID;
		public System.Windows.Forms.Label lblIntLicenseID;
		private System.Windows.Forms.Label label3;
	}
}