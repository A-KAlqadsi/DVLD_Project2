namespace DVLD_View.Applications.Control
{
	partial class ctrlApplicationBasicInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlApplicationBasicInfo));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.llViewPersonInfo = new System.Windows.Forms.LinkLabel();
			this.lblUsername = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.lblLastStatusDate = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.lblAppDate = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblApplicant = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblAppType = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblAppFees = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblAppStatus = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblAppID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pbUser = new System.Windows.Forms.PictureBox();
			this.pbStatusDate = new System.Windows.Forms.PictureBox();
			this.pbDate = new System.Windows.Forms.PictureBox();
			this.pbApplicant = new System.Windows.Forms.PictureBox();
			this.pbAppType = new System.Windows.Forms.PictureBox();
			this.pbFees = new System.Windows.Forms.PictureBox();
			this.pbStatus = new System.Windows.Forms.PictureBox();
			this.pbAppID = new System.Windows.Forms.PictureBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbStatusDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbApplicant)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAppType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAppID)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.llViewPersonInfo);
			this.groupBox2.Controls.Add(this.pbUser);
			this.groupBox2.Controls.Add(this.lblUsername);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.pbStatusDate);
			this.groupBox2.Controls.Add(this.lblLastStatusDate);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.pbDate);
			this.groupBox2.Controls.Add(this.lblAppDate);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.pbApplicant);
			this.groupBox2.Controls.Add(this.lblApplicant);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.pbAppType);
			this.groupBox2.Controls.Add(this.lblAppType);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.pbFees);
			this.groupBox2.Controls.Add(this.lblAppFees);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.pbStatus);
			this.groupBox2.Controls.Add(this.lblAppStatus);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.pbAppID);
			this.groupBox2.Controls.Add(this.lblAppID);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(2, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1027, 270);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Application Basic Info";
			// 
			// llViewPersonInfo
			// 
			this.llViewPersonInfo.AutoSize = true;
			this.llViewPersonInfo.Enabled = false;
			this.llViewPersonInfo.Location = new System.Drawing.Point(778, 182);
			this.llViewPersonInfo.Name = "llViewPersonInfo";
			this.llViewPersonInfo.Size = new System.Drawing.Size(164, 25);
			this.llViewPersonInfo.TabIndex = 48;
			this.llViewPersonInfo.TabStop = true;
			this.llViewPersonInfo.Text = "View Person Info.";
			this.llViewPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewPersonInfo_LinkClicked);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(874, 109);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(68, 25);
			this.lblUsername.TabIndex = 46;
			this.lblUsername.Text = "[????]";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(668, 109);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(127, 25);
			this.label19.TabIndex = 45;
			this.label19.Text = "Created By:";
			// 
			// lblLastStatusDate
			// 
			this.lblLastStatusDate.AutoSize = true;
			this.lblLastStatusDate.Location = new System.Drawing.Point(874, 67);
			this.lblLastStatusDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLastStatusDate.Name = "lblLastStatusDate";
			this.lblLastStatusDate.Size = new System.Drawing.Size(68, 25);
			this.lblLastStatusDate.TabIndex = 43;
			this.lblLastStatusDate.Text = "[????]";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(663, 67);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(132, 25);
			this.label17.TabIndex = 42;
			this.label17.Text = "Status Date:";
			// 
			// lblAppDate
			// 
			this.lblAppDate.AutoSize = true;
			this.lblAppDate.Location = new System.Drawing.Point(874, 24);
			this.lblAppDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppDate.Name = "lblAppDate";
			this.lblAppDate.Size = new System.Drawing.Size(68, 25);
			this.lblAppDate.TabIndex = 40;
			this.lblAppDate.Text = "[????]";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(731, 26);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 25);
			this.label15.TabIndex = 39;
			this.label15.Text = "Date:";
			// 
			// lblApplicant
			// 
			this.lblApplicant.AutoSize = true;
			this.lblApplicant.Location = new System.Drawing.Point(224, 225);
			this.lblApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblApplicant.Name = "lblApplicant";
			this.lblApplicant.Size = new System.Drawing.Size(68, 25);
			this.lblApplicant.TabIndex = 37;
			this.lblApplicant.Text = "[????]";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(25, 225);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(109, 25);
			this.label13.TabIndex = 36;
			this.label13.Text = "Applicant:";
			// 
			// lblAppType
			// 
			this.lblAppType.AutoSize = true;
			this.lblAppType.Location = new System.Drawing.Point(224, 179);
			this.lblAppType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppType.Name = "lblAppType";
			this.lblAppType.Size = new System.Drawing.Size(68, 25);
			this.lblAppType.TabIndex = 34;
			this.lblAppType.Text = "[????]";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(66, 179);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 25);
			this.label11.TabIndex = 33;
			this.label11.Text = "Type:";
			// 
			// lblAppFees
			// 
			this.lblAppFees.AutoSize = true;
			this.lblAppFees.Location = new System.Drawing.Point(224, 132);
			this.lblAppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppFees.Name = "lblAppFees";
			this.lblAppFees.Size = new System.Drawing.Size(68, 25);
			this.lblAppFees.TabIndex = 31;
			this.lblAppFees.Text = "[????]";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(67, 132);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 25);
			this.label9.TabIndex = 30;
			this.label9.Text = "Fees:";
			// 
			// lblAppStatus
			// 
			this.lblAppStatus.AutoSize = true;
			this.lblAppStatus.Location = new System.Drawing.Point(224, 88);
			this.lblAppStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppStatus.Name = "lblAppStatus";
			this.lblAppStatus.Size = new System.Drawing.Size(68, 25);
			this.lblAppStatus.TabIndex = 28;
			this.lblAppStatus.Text = "[????]";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(53, 88);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 25);
			this.label7.TabIndex = 27;
			this.label7.Text = "Status:";
			// 
			// lblAppID
			// 
			this.lblAppID.AutoSize = true;
			this.lblAppID.Location = new System.Drawing.Point(224, 44);
			this.lblAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAppID.Name = "lblAppID";
			this.lblAppID.Size = new System.Drawing.Size(68, 25);
			this.lblAppID.TabIndex = 25;
			this.lblAppID.Text = "[????]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(94, 44);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 25);
			this.label4.TabIndex = 24;
			this.label4.Text = "ID:";
			// 
			// pbUser
			// 
			this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
			this.pbUser.Location = new System.Drawing.Point(819, 104);
			this.pbUser.Margin = new System.Windows.Forms.Padding(2);
			this.pbUser.Name = "pbUser";
			this.pbUser.Size = new System.Drawing.Size(39, 35);
			this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbUser.TabIndex = 47;
			this.pbUser.TabStop = false;
			// 
			// pbStatusDate
			// 
			this.pbStatusDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbStatusDate.Image = ((System.Drawing.Image)(resources.GetObject("pbStatusDate.Image")));
			this.pbStatusDate.Location = new System.Drawing.Point(819, 64);
			this.pbStatusDate.Margin = new System.Windows.Forms.Padding(2);
			this.pbStatusDate.Name = "pbStatusDate";
			this.pbStatusDate.Size = new System.Drawing.Size(39, 30);
			this.pbStatusDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbStatusDate.TabIndex = 44;
			this.pbStatusDate.TabStop = false;
			// 
			// pbDate
			// 
			this.pbDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbDate.Image = ((System.Drawing.Image)(resources.GetObject("pbDate.Image")));
			this.pbDate.Location = new System.Drawing.Point(819, 21);
			this.pbDate.Margin = new System.Windows.Forms.Padding(2);
			this.pbDate.Name = "pbDate";
			this.pbDate.Size = new System.Drawing.Size(39, 30);
			this.pbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDate.TabIndex = 41;
			this.pbDate.TabStop = false;
			// 
			// pbApplicant
			// 
			this.pbApplicant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbApplicant.Image = ((System.Drawing.Image)(resources.GetObject("pbApplicant.Image")));
			this.pbApplicant.Location = new System.Drawing.Point(162, 222);
			this.pbApplicant.Margin = new System.Windows.Forms.Padding(2);
			this.pbApplicant.Name = "pbApplicant";
			this.pbApplicant.Size = new System.Drawing.Size(39, 30);
			this.pbApplicant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbApplicant.TabIndex = 38;
			this.pbApplicant.TabStop = false;
			// 
			// pbAppType
			// 
			this.pbAppType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbAppType.Image = ((System.Drawing.Image)(resources.GetObject("pbAppType.Image")));
			this.pbAppType.Location = new System.Drawing.Point(162, 171);
			this.pbAppType.Margin = new System.Windows.Forms.Padding(2);
			this.pbAppType.Name = "pbAppType";
			this.pbAppType.Size = new System.Drawing.Size(39, 40);
			this.pbAppType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbAppType.TabIndex = 35;
			this.pbAppType.TabStop = false;
			// 
			// pbFees
			// 
			this.pbFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
			this.pbFees.Location = new System.Drawing.Point(162, 129);
			this.pbFees.Margin = new System.Windows.Forms.Padding(2);
			this.pbFees.Name = "pbFees";
			this.pbFees.Size = new System.Drawing.Size(39, 30);
			this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbFees.TabIndex = 32;
			this.pbFees.TabStop = false;
			// 
			// pbStatus
			// 
			this.pbStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbStatus.Image = ((System.Drawing.Image)(resources.GetObject("pbStatus.Image")));
			this.pbStatus.Location = new System.Drawing.Point(162, 85);
			this.pbStatus.Margin = new System.Windows.Forms.Padding(2);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(39, 30);
			this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbStatus.TabIndex = 29;
			this.pbStatus.TabStop = false;
			// 
			// pbAppID
			// 
			this.pbAppID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbAppID.Image = ((System.Drawing.Image)(resources.GetObject("pbAppID.Image")));
			this.pbAppID.Location = new System.Drawing.Point(162, 41);
			this.pbAppID.Margin = new System.Windows.Forms.Padding(2);
			this.pbAppID.Name = "pbAppID";
			this.pbAppID.Size = new System.Drawing.Size(39, 30);
			this.pbAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbAppID.TabIndex = 26;
			this.pbAppID.TabStop = false;
			// 
			// ctrlApplicationBasicInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Name = "ctrlApplicationBasicInfo";
			this.Size = new System.Drawing.Size(1034, 277);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbStatusDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbApplicant)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAppType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAppID)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.LinkLabel llViewPersonInfo;
		private System.Windows.Forms.PictureBox pbUser;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.PictureBox pbStatusDate;
		private System.Windows.Forms.Label lblLastStatusDate;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pbDate;
		private System.Windows.Forms.Label lblAppDate;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.PictureBox pbApplicant;
		private System.Windows.Forms.Label lblApplicant;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox pbAppType;
		private System.Windows.Forms.Label lblAppType;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pbFees;
		private System.Windows.Forms.Label lblAppFees;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbStatus;
		private System.Windows.Forms.Label lblAppStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pbAppID;
		public System.Windows.Forms.Label lblAppID;
		private System.Windows.Forms.Label label4;
	}
}
