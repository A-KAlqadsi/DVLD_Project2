namespace DVLD_View
{
    partial class frmReplacementForDamageOrLost
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementForDamageOrLost));
			this.lblMode = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbLostLicense = new System.Windows.Forms.RadioButton();
			this.rbDamageLicense = new System.Windows.Forms.RadioButton();
			this.llShowLicense = new System.Windows.Forms.LinkLabel();
			this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnIssue = new System.Windows.Forms.Button();
			this.ctrlDriverLicenseCardWithFilter1 = new DVLD_View.ctrlDriverLicenseCardWithFilter();
			this.gbApplicationInfoForLicenseReplacement = new System.Windows.Forms.GroupBox();
			this.pbUser = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.pbFees = new System.Windows.Forms.PictureBox();
			this.lblAppFees = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblRLAppID = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pbDateOfBirth = new System.Windows.Forms.PictureBox();
			this.lblApplicationDate = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pbLicenseID = new System.Windows.Forms.PictureBox();
			this.lblOldLicenseID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pbIntLicenseID = new System.Windows.Forms.PictureBox();
			this.lblReplacedLicenseID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.gbApplicationInfoForLicenseReplacement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicenseID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIntLicenseID)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMode
			// 
			this.lblMode.AutoSize = true;
			this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblMode.Location = new System.Drawing.Point(265, -1);
			this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMode.Name = "lblMode";
			this.lblMode.Size = new System.Drawing.Size(469, 36);
			this.lblMode.TabIndex = 9;
			this.lblMode.Text = "Replacement For Damage License";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbLostLicense);
			this.groupBox1.Controls.Add(this.rbDamageLicense);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(730, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 110);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Replacement For";
			// 
			// rbLostLicense
			// 
			this.rbLostLicense.AutoSize = true;
			this.rbLostLicense.Location = new System.Drawing.Point(6, 68);
			this.rbLostLicense.Name = "rbLostLicense";
			this.rbLostLicense.Size = new System.Drawing.Size(143, 29);
			this.rbLostLicense.TabIndex = 1;
			this.rbLostLicense.Text = "Lost License";
			this.rbLostLicense.UseVisualStyleBackColor = true;
			this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
			// 
			// rbDamageLicense
			// 
			this.rbDamageLicense.AutoSize = true;
			this.rbDamageLicense.Checked = true;
			this.rbDamageLicense.Location = new System.Drawing.Point(6, 31);
			this.rbDamageLicense.Name = "rbDamageLicense";
			this.rbDamageLicense.Size = new System.Drawing.Size(180, 29);
			this.rbDamageLicense.TabIndex = 0;
			this.rbDamageLicense.TabStop = true;
			this.rbDamageLicense.Text = "Damage License";
			this.rbDamageLicense.UseVisualStyleBackColor = true;
			this.rbDamageLicense.CheckedChanged += new System.EventHandler(this.rbDamageLicense_CheckedChanged);
			// 
			// llShowLicense
			// 
			this.llShowLicense.AutoSize = true;
			this.llShowLicense.Enabled = false;
			this.llShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicense.Location = new System.Drawing.Point(206, 662);
			this.llShowLicense.Name = "llShowLicense";
			this.llShowLicense.Size = new System.Drawing.Size(184, 20);
			this.llShowLicense.TabIndex = 113;
			this.llShowLicense.TabStop = true;
			this.llShowLicense.Text = "Show New License Info";
			this.llShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicense_LinkClicked);
			// 
			// llShowLicenseHistory
			// 
			this.llShowLicenseHistory.AutoSize = true;
			this.llShowLicenseHistory.Enabled = false;
			this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseHistory.Location = new System.Drawing.Point(21, 661);
			this.llShowLicenseHistory.Name = "llShowLicenseHistory";
			this.llShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
			this.llShowLicenseHistory.TabIndex = 112;
			this.llShowLicenseHistory.TabStop = true;
			this.llShowLicenseHistory.Text = "Show License History";
			this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
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
			this.btnClose.Location = new System.Drawing.Point(736, 661);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 43);
			this.btnClose.TabIndex = 111;
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
			this.btnIssue.Location = new System.Drawing.Point(880, 660);
			this.btnIssue.Name = "btnIssue";
			this.btnIssue.Size = new System.Drawing.Size(138, 44);
			this.btnIssue.TabIndex = 110;
			this.btnIssue.Text = "Issue";
			this.btnIssue.UseVisualStyleBackColor = false;
			this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
			// 
			// ctrlDriverLicenseCardWithFilter1
			// 
			this.ctrlDriverLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
			this.ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
			this.ctrlDriverLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 48);
			this.ctrlDriverLicenseCardWithFilter1.Name = "ctrlDriverLicenseCardWithFilter1";
			this.ctrlDriverLicenseCardWithFilter1.Size = new System.Drawing.Size(1021, 444);
			this.ctrlDriverLicenseCardWithFilter1.TabIndex = 10;
			this.ctrlDriverLicenseCardWithFilter1.OnLicenseSelected += new System.EventHandler<DVLD_View.ctrlDriverLicenseCardWithFilter.OnLicenseSelectedEventArgs>(this.ctrlDriverLicenseCardWithFilter1_OnLicenseSelected);
			// 
			// gbApplicationInfoForLicenseReplacement
			// 
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pbUser);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblUsername);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label19);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pbFees);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblAppFees);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label2);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox1);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblRLAppID);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label9);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pbDateOfBirth);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblApplicationDate);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label14);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pbLicenseID);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblOldLicenseID);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label4);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pbIntLicenseID);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblReplacedLicenseID);
			this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label1);
			this.gbApplicationInfoForLicenseReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbApplicationInfoForLicenseReplacement.Location = new System.Drawing.Point(22, 490);
			this.gbApplicationInfoForLicenseReplacement.Name = "gbApplicationInfoForLicenseReplacement";
			this.gbApplicationInfoForLicenseReplacement.Size = new System.Drawing.Size(1008, 162);
			this.gbApplicationInfoForLicenseReplacement.TabIndex = 116;
			this.gbApplicationInfoForLicenseReplacement.TabStop = false;
			this.gbApplicationInfoForLicenseReplacement.Text = "Application Info For License Replacement";
			// 
			// pbUser
			// 
			this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
			this.pbUser.Location = new System.Drawing.Point(750, 113);
			this.pbUser.Margin = new System.Windows.Forms.Padding(2);
			this.pbUser.Name = "pbUser";
			this.pbUser.Size = new System.Drawing.Size(39, 35);
			this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbUser.TabIndex = 111;
			this.pbUser.TabStop = false;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(804, 118);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(68, 25);
			this.lblUsername.TabIndex = 110;
			this.lblUsername.Text = "[????]";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(598, 118);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(127, 25);
			this.label19.TabIndex = 109;
			this.label19.Text = "Created By:";
			// 
			// pbFees
			// 
			this.pbFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
			this.pbFees.Location = new System.Drawing.Point(223, 112);
			this.pbFees.Margin = new System.Windows.Forms.Padding(2);
			this.pbFees.Name = "pbFees";
			this.pbFees.Size = new System.Drawing.Size(39, 30);
			this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbFees.TabIndex = 108;
			this.pbFees.TabStop = false;
			// 
			// lblAppFees
			// 
			this.lblAppFees.AutoSize = true;
			this.lblAppFees.Location = new System.Drawing.Point(275, 115);
			this.lblAppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppFees.Name = "lblAppFees";
			this.lblAppFees.Size = new System.Drawing.Size(56, 25);
			this.lblAppFees.TabIndex = 107;
			this.lblAppFees.Text = "$$$$";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 115);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 25);
			this.label2.TabIndex = 106;
			this.label2.Text = "Application Fees:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(223, 39);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 105;
			this.pictureBox1.TabStop = false;
			// 
			// lblRLAppID
			// 
			this.lblRLAppID.AutoSize = true;
			this.lblRLAppID.Location = new System.Drawing.Point(275, 42);
			this.lblRLAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRLAppID.Name = "lblRLAppID";
			this.lblRLAppID.Size = new System.Drawing.Size(68, 25);
			this.lblRLAppID.TabIndex = 104;
			this.lblRLAppID.Text = "[????]";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 42);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(191, 25);
			this.label9.TabIndex = 103;
			this.label9.Text = "L.R.Application ID:";
			// 
			// pbDateOfBirth
			// 
			this.pbDateOfBirth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("pbDateOfBirth.Image")));
			this.pbDateOfBirth.Location = new System.Drawing.Point(223, 73);
			this.pbDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
			this.pbDateOfBirth.Name = "pbDateOfBirth";
			this.pbDateOfBirth.Size = new System.Drawing.Size(39, 30);
			this.pbDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDateOfBirth.TabIndex = 97;
			this.pbDateOfBirth.TabStop = false;
			// 
			// lblApplicationDate
			// 
			this.lblApplicationDate.AutoSize = true;
			this.lblApplicationDate.Location = new System.Drawing.Point(275, 75);
			this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblApplicationDate.Name = "lblApplicationDate";
			this.lblApplicationDate.Size = new System.Drawing.Size(123, 25);
			this.lblApplicationDate.TabIndex = 99;
			this.lblApplicationDate.Text = "3/NOV/2004";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(25, 75);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(177, 25);
			this.label14.TabIndex = 98;
			this.label14.Text = "Application Date:";
			// 
			// pbLicenseID
			// 
			this.pbLicenseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("pbLicenseID.Image")));
			this.pbLicenseID.Location = new System.Drawing.Point(750, 75);
			this.pbLicenseID.Margin = new System.Windows.Forms.Padding(2);
			this.pbLicenseID.Name = "pbLicenseID";
			this.pbLicenseID.Size = new System.Drawing.Size(39, 30);
			this.pbLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLicenseID.TabIndex = 91;
			this.pbLicenseID.TabStop = false;
			// 
			// lblOldLicenseID
			// 
			this.lblOldLicenseID.AutoSize = true;
			this.lblOldLicenseID.Location = new System.Drawing.Point(804, 78);
			this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOldLicenseID.Name = "lblOldLicenseID";
			this.lblOldLicenseID.Size = new System.Drawing.Size(68, 25);
			this.lblOldLicenseID.TabIndex = 93;
			this.lblOldLicenseID.Text = "[????]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(564, 78);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 25);
			this.label4.TabIndex = 92;
			this.label4.Text = "Old License ID:";
			// 
			// pbIntLicenseID
			// 
			this.pbIntLicenseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbIntLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("pbIntLicenseID.Image")));
			this.pbIntLicenseID.Location = new System.Drawing.Point(750, 40);
			this.pbIntLicenseID.Margin = new System.Windows.Forms.Padding(2);
			this.pbIntLicenseID.Name = "pbIntLicenseID";
			this.pbIntLicenseID.Size = new System.Drawing.Size(39, 30);
			this.pbIntLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIntLicenseID.TabIndex = 90;
			this.pbIntLicenseID.TabStop = false;
			// 
			// lblReplacedLicenseID
			// 
			this.lblReplacedLicenseID.AutoSize = true;
			this.lblReplacedLicenseID.Location = new System.Drawing.Point(804, 43);
			this.lblReplacedLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
			this.lblReplacedLicenseID.Size = new System.Drawing.Size(68, 25);
			this.lblReplacedLicenseID.TabIndex = 89;
			this.lblReplacedLicenseID.Text = "[????]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(509, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 25);
			this.label1.TabIndex = 88;
			this.label1.Text = "Replaced License ID:";
			// 
			// frmReplacementForDamageOrLost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1045, 723);
			this.Controls.Add(this.gbApplicationInfoForLicenseReplacement);
			this.Controls.Add(this.llShowLicense);
			this.Controls.Add(this.llShowLicenseHistory);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnIssue);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ctrlDriverLicenseCardWithFilter1);
			this.Controls.Add(this.lblMode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmReplacementForDamageOrLost";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Replacement For Damage/Lost";
			this.Load += new System.EventHandler(this.frmReplacementForDamageOrLost_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbApplicationInfoForLicenseReplacement.ResumeLayout(false);
			this.gbApplicationInfoForLicenseReplacement.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicenseID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIntLicenseID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private ctrlDriverLicenseCardWithFilter ctrlDriverLicenseCardWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamageLicense;
        private System.Windows.Forms.LinkLabel llShowLicense;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
		private System.Windows.Forms.GroupBox gbApplicationInfoForLicenseReplacement;
		private System.Windows.Forms.PictureBox pbUser;
		public System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.PictureBox pbFees;
		public System.Windows.Forms.Label lblAppFees;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblRLAppID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbDateOfBirth;
		public System.Windows.Forms.Label lblApplicationDate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pbLicenseID;
		public System.Windows.Forms.Label lblOldLicenseID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pbIntLicenseID;
		public System.Windows.Forms.Label lblReplacedLicenseID;
		private System.Windows.Forms.Label label1;
	}
}