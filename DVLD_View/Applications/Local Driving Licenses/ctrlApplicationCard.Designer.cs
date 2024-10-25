namespace DVLD_View
{
    partial class ctrlApplicationCard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlApplicationCard));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
			this.pbShowLicenseInfo = new System.Windows.Forms.PictureBox();
			this.pbPassedTests = new System.Windows.Forms.PictureBox();
			this.lblPassedTests = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pbLicenseClass = new System.Windows.Forms.PictureBox();
			this.lblClassName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pbDLAppID = new System.Windows.Forms.PictureBox();
			this.lblDLAppID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrlApplicationBasicInfo1 = new DVLD_View.Applications.Control.ctrlApplicationBasicInfo();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbShowLicenseInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassedTests)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.llShowLicenseInfo);
			this.groupBox1.Controls.Add(this.pbShowLicenseInfo);
			this.groupBox1.Controls.Add(this.pbPassedTests);
			this.groupBox1.Controls.Add(this.lblPassedTests);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pbLicenseClass);
			this.groupBox1.Controls.Add(this.lblClassName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.pbDLAppID);
			this.groupBox1.Controls.Add(this.lblDLAppID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(5, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1027, 162);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Driving License Application Info";
			// 
			// llShowLicenseInfo
			// 
			this.llShowLicenseInfo.AutoSize = true;
			this.llShowLicenseInfo.Enabled = false;
			this.llShowLicenseInfo.Location = new System.Drawing.Point(190, 104);
			this.llShowLicenseInfo.Name = "llShowLicenseInfo";
			this.llShowLicenseInfo.Size = new System.Drawing.Size(170, 25);
			this.llShowLicenseInfo.TabIndex = 49;
			this.llShowLicenseInfo.TabStop = true;
			this.llShowLicenseInfo.Text = "View License Info.";
			this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
			// 
			// pbShowLicenseInfo
			// 
			this.pbShowLicenseInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbShowLicenseInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbShowLicenseInfo.Image")));
			this.pbShowLicenseInfo.Location = new System.Drawing.Point(138, 95);
			this.pbShowLicenseInfo.Margin = new System.Windows.Forms.Padding(2);
			this.pbShowLicenseInfo.Name = "pbShowLicenseInfo";
			this.pbShowLicenseInfo.Size = new System.Drawing.Size(39, 43);
			this.pbShowLicenseInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbShowLicenseInfo.TabIndex = 30;
			this.pbShowLicenseInfo.TabStop = false;
			// 
			// pbPassedTests
			// 
			this.pbPassedTests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPassedTests.Image = ((System.Drawing.Image)(resources.GetObject("pbPassedTests.Image")));
			this.pbPassedTests.Location = new System.Drawing.Point(566, 86);
			this.pbPassedTests.Margin = new System.Windows.Forms.Padding(2);
			this.pbPassedTests.Name = "pbPassedTests";
			this.pbPassedTests.Size = new System.Drawing.Size(39, 43);
			this.pbPassedTests.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbPassedTests.TabIndex = 29;
			this.pbPassedTests.TabStop = false;
			// 
			// lblPassedTests
			// 
			this.lblPassedTests.AutoSize = true;
			this.lblPassedTests.Location = new System.Drawing.Point(618, 100);
			this.lblPassedTests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPassedTests.Name = "lblPassedTests";
			this.lblPassedTests.Size = new System.Drawing.Size(68, 25);
			this.lblPassedTests.TabIndex = 28;
			this.lblPassedTests.Text = "[????]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(405, 95);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 25);
			this.label5.TabIndex = 27;
			this.label5.Text = "Passed Tests:";
			// 
			// pbLicenseClass
			// 
			this.pbLicenseClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbLicenseClass.Image = ((System.Drawing.Image)(resources.GetObject("pbLicenseClass.Image")));
			this.pbLicenseClass.Location = new System.Drawing.Point(566, 35);
			this.pbLicenseClass.Margin = new System.Windows.Forms.Padding(2);
			this.pbLicenseClass.Name = "pbLicenseClass";
			this.pbLicenseClass.Size = new System.Drawing.Size(39, 43);
			this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbLicenseClass.TabIndex = 26;
			this.pbLicenseClass.TabStop = false;
			// 
			// lblClassName
			// 
			this.lblClassName.AutoSize = true;
			this.lblClassName.Location = new System.Drawing.Point(618, 44);
			this.lblClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblClassName.Name = "lblClassName";
			this.lblClassName.Size = new System.Drawing.Size(68, 25);
			this.lblClassName.TabIndex = 25;
			this.lblClassName.Text = "[????]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(345, 44);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(211, 25);
			this.label3.TabIndex = 24;
			this.label3.Text = "Applied For License:";
			// 
			// pbDLAppID
			// 
			this.pbDLAppID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbDLAppID.Image = ((System.Drawing.Image)(resources.GetObject("pbDLAppID.Image")));
			this.pbDLAppID.Location = new System.Drawing.Point(138, 31);
			this.pbDLAppID.Margin = new System.Windows.Forms.Padding(2);
			this.pbDLAppID.Name = "pbDLAppID";
			this.pbDLAppID.Size = new System.Drawing.Size(39, 43);
			this.pbDLAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbDLAppID.TabIndex = 23;
			this.pbDLAppID.TabStop = false;
			// 
			// lblDLAppID
			// 
			this.lblDLAppID.AutoSize = true;
			this.lblDLAppID.Location = new System.Drawing.Point(190, 40);
			this.lblDLAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDLAppID.Name = "lblDLAppID";
			this.lblDLAppID.Size = new System.Drawing.Size(68, 25);
			this.lblDLAppID.TabIndex = 22;
			this.lblDLAppID.Text = "[????]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 25);
			this.label1.TabIndex = 21;
			this.label1.Text = "D.L.App ID:";
			// 
			// ctrlApplicationBasicInfo1
			// 
			this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(2, 164);
			this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
			this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(1034, 277);
			this.ctrlApplicationBasicInfo1.TabIndex = 1;
			// 
			// ctrlApplicationCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.ctrlApplicationBasicInfo1);
			this.Controls.Add(this.groupBox1);
			this.Name = "ctrlApplicationCard";
			this.Size = new System.Drawing.Size(1037, 441);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbShowLicenseInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassedTests)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDLAppID)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbDLAppID;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPassedTests;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.PictureBox pbShowLicenseInfo;
		private Applications.Control.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
	}
}
