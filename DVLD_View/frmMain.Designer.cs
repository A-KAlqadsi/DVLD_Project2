namespace DVLD_View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.pbDVLDLogo = new System.Windows.Forms.PictureBox();
            this.tsmiApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDrivingLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLostDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDamagedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehicleLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDVLDLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplications,
            this.tsmiPeople,
            this.tsmiDrivers,
            this.tsmiUsers,
            this.tsmiAccountSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 80);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.Location = new System.Drawing.Point(1141, 90);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(167, 25);
            this.lblLoginUser.TabIndex = 6;
            this.lblLoginUser.Text = "Login Username=";
            // 
            // pbDVLDLogo
            // 
            this.pbDVLDLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbDVLDLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbDVLDLogo.Image")));
            this.pbDVLDLogo.Location = new System.Drawing.Point(406, 170);
            this.pbDVLDLogo.Name = "pbDVLDLogo";
            this.pbDVLDLogo.Size = new System.Drawing.Size(596, 286);
            this.pbDVLDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDVLDLogo.TabIndex = 4;
            this.pbDVLDLogo.TabStop = false;
            // 
            // tsmiApplications
            // 
            this.tsmiApplications.AutoSize = false;
            this.tsmiApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListApplications,
            this.toolStripMenuItem1,
            this.tsmiDrivingLicenseServices,
            this.tsmiVehicleLicenseServices,
            this.toolStripMenuItem2,
            this.tsmiManageApplicationTypes});
            this.tsmiApplications.Image = ((System.Drawing.Image)(resources.GetObject("tsmiApplications.Image")));
            this.tsmiApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiApplications.Name = "tsmiApplications";
            this.tsmiApplications.Size = new System.Drawing.Size(208, 70);
            this.tsmiApplications.Text = "Applications";
            // 
            // tsmiListApplications
            // 
            this.tsmiListApplications.Image = ((System.Drawing.Image)(resources.GetObject("tsmiListApplications.Image")));
            this.tsmiListApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiListApplications.Name = "tsmiListApplications";
            this.tsmiListApplications.Size = new System.Drawing.Size(405, 70);
            this.tsmiListApplications.Text = "List Applications";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(402, 6);
            // 
            // tsmiDrivingLicenseServices
            // 
            this.tsmiDrivingLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewDrivingLicense,
            this.tsmiRenewDrivingLicense,
            this.tsmiLostDrivingLicense,
            this.tsmiDamagedDrivingLicense,
            this.tsmiReleaseDetainedDrivingLicense,
            this.tsmiRetakeTest});
            this.tsmiDrivingLicenseServices.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDrivingLicenseServices.Image")));
            this.tsmiDrivingLicenseServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDrivingLicenseServices.Name = "tsmiDrivingLicenseServices";
            this.tsmiDrivingLicenseServices.Size = new System.Drawing.Size(405, 70);
            this.tsmiDrivingLicenseServices.Text = "Driving License Services";
            // 
            // tsmiNewDrivingLicense
            // 
            this.tsmiNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewLocalLicense,
            this.tsmiNewInternationalLicense});
            this.tsmiNewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNewDrivingLicense.Image")));
            this.tsmiNewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiNewDrivingLicense.Name = "tsmiNewDrivingLicense";
            this.tsmiNewDrivingLicense.Size = new System.Drawing.Size(436, 38);
            this.tsmiNewDrivingLicense.Text = "New Driving License";
            // 
            // tsmiNewLocalLicense
            // 
            this.tsmiNewLocalLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNewLocalLicense.Image")));
            this.tsmiNewLocalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiNewLocalLicense.Name = "tsmiNewLocalLicense";
            this.tsmiNewLocalLicense.Size = new System.Drawing.Size(317, 38);
            this.tsmiNewLocalLicense.Text = "Local License";
            // 
            // tsmiNewInternationalLicense
            // 
            this.tsmiNewInternationalLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNewInternationalLicense.Image")));
            this.tsmiNewInternationalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiNewInternationalLicense.Name = "tsmiNewInternationalLicense";
            this.tsmiNewInternationalLicense.Size = new System.Drawing.Size(317, 38);
            this.tsmiNewInternationalLicense.Text = "International License";
            // 
            // tsmiRenewDrivingLicense
            // 
            this.tsmiRenewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRenewDrivingLicense.Image")));
            this.tsmiRenewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRenewDrivingLicense.Name = "tsmiRenewDrivingLicense";
            this.tsmiRenewDrivingLicense.Size = new System.Drawing.Size(436, 38);
            this.tsmiRenewDrivingLicense.Text = "Renew Driving License";
            // 
            // tsmiLostDrivingLicense
            // 
            this.tsmiLostDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLostDrivingLicense.Image")));
            this.tsmiLostDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiLostDrivingLicense.Name = "tsmiLostDrivingLicense";
            this.tsmiLostDrivingLicense.Size = new System.Drawing.Size(436, 38);
            this.tsmiLostDrivingLicense.Text = "Lost Driving License";
            // 
            // tsmiDamagedDrivingLicense
            // 
            this.tsmiDamagedDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDamagedDrivingLicense.Image")));
            this.tsmiDamagedDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDamagedDrivingLicense.Name = "tsmiDamagedDrivingLicense";
            this.tsmiDamagedDrivingLicense.Size = new System.Drawing.Size(436, 38);
            this.tsmiDamagedDrivingLicense.Text = "Damaged Driving License";
            // 
            // tsmiReleaseDetainedDrivingLicense
            // 
            this.tsmiReleaseDetainedDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReleaseDetainedDrivingLicense.Image")));
            this.tsmiReleaseDetainedDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiReleaseDetainedDrivingLicense.Name = "tsmiReleaseDetainedDrivingLicense";
            this.tsmiReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(436, 38);
            this.tsmiReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            // 
            // tsmiRetakeTest
            // 
            this.tsmiRetakeTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRetakeTest.Image")));
            this.tsmiRetakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRetakeTest.Name = "tsmiRetakeTest";
            this.tsmiRetakeTest.Size = new System.Drawing.Size(436, 38);
            this.tsmiRetakeTest.Text = "Retake Test";
            // 
            // tsmiVehicleLicenseServices
            // 
            this.tsmiVehicleLicenseServices.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVehicleLicenseServices.Image")));
            this.tsmiVehicleLicenseServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiVehicleLicenseServices.Name = "tsmiVehicleLicenseServices";
            this.tsmiVehicleLicenseServices.Size = new System.Drawing.Size(405, 70);
            this.tsmiVehicleLicenseServices.Text = "Vehicle License Services";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(402, 6);
            // 
            // tsmiManageApplicationTypes
            // 
            this.tsmiManageApplicationTypes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiManageApplicationTypes.Image")));
            this.tsmiManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManageApplicationTypes.Name = "tsmiManageApplicationTypes";
            this.tsmiManageApplicationTypes.Size = new System.Drawing.Size(405, 70);
            this.tsmiManageApplicationTypes.Text = "Manage Application Types";
            this.tsmiManageApplicationTypes.Click += new System.EventHandler(this.tsmiManageApplicationTypes_Click);
            // 
            // tsmiPeople
            // 
            this.tsmiPeople.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPeople.Image")));
            this.tsmiPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPeople.Name = "tsmiPeople";
            this.tsmiPeople.Size = new System.Drawing.Size(157, 76);
            this.tsmiPeople.Text = "People";
            this.tsmiPeople.Click += new System.EventHandler(this.tsmiPeople_Click);
            // 
            // tsmiDrivers
            // 
            this.tsmiDrivers.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDrivers.Image")));
            this.tsmiDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDrivers.Name = "tsmiDrivers";
            this.tsmiDrivers.Size = new System.Drawing.Size(162, 76);
            this.tsmiDrivers.Text = "Drivers";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUsers.Image")));
            this.tsmiUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(145, 76);
            this.tsmiUsers.Text = "Users";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiAccountSettings
            // 
            this.tsmiAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUserInfo,
            this.tsmiChangePassword,
            this.toolStripMenuItem3,
            this.tsmiSignOut});
            this.tsmiAccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAccountSettings.Image")));
            this.tsmiAccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAccountSettings.Name = "tsmiAccountSettings";
            this.tsmiAccountSettings.Size = new System.Drawing.Size(258, 76);
            this.tsmiAccountSettings.Text = "Account Settings";
            // 
            // tsmiCurrentUserInfo
            // 
            this.tsmiCurrentUserInfo.AutoSize = false;
            this.tsmiCurrentUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCurrentUserInfo.Image")));
            this.tsmiCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCurrentUserInfo.Name = "tsmiCurrentUserInfo";
            this.tsmiCurrentUserInfo.Size = new System.Drawing.Size(275, 45);
            this.tsmiCurrentUserInfo.Text = "Current User Info";
            this.tsmiCurrentUserInfo.Click += new System.EventHandler(this.tsmiCurrentUserInfo_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.AutoSize = false;
            this.tsmiChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsmiChangePassword.Image")));
            this.tsmiChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(275, 45);
            this.tsmiChangePassword.Text = "Change Password";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(282, 6);
            // 
            // tsmiSignOut
            // 
            this.tsmiSignOut.AutoSize = false;
            this.tsmiSignOut.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSignOut.Image")));
            this.tsmiSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSignOut.Name = "tsmiSignOut";
            this.tsmiSignOut.Size = new System.Drawing.Size(275, 45);
            this.tsmiSignOut.Text = "Sign Out";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 525);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.pbDVLDLogo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDVLDLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiListApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiLostDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiDamagedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehicleLicenseServices;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
        private System.Windows.Forms.PictureBox pbDVLDLogo;
        private System.Windows.Forms.Label lblLoginUser;
    }
}

