namespace DVLD_View
{
    partial class frmRenewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLocalDrivingLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.llShowLicense = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.ctrlRenewLicenseApplicationInfo1 = new DVLD_View.ctrlRenewLicenseApplicationInfo();
            this.ctrlDriverLicenseCardWithFilter1 = new DVLD_View.ctrlDriverLicenseCardWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(321, -6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Renew License Application";
            // 
            // llShowLicense
            // 
            this.llShowLicense.AutoSize = true;
            this.llShowLicense.Enabled = false;
            this.llShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicense.Location = new System.Drawing.Point(214, 782);
            this.llShowLicense.Name = "llShowLicense";
            this.llShowLicense.Size = new System.Drawing.Size(184, 20);
            this.llShowLicense.TabIndex = 109;
            this.llShowLicense.TabStop = true;
            this.llShowLicense.Text = "Show New License Info";
            this.llShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicense_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseHistory.Location = new System.Drawing.Point(29, 781);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
            this.llShowLicenseHistory.TabIndex = 108;
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
            this.btnClose.Location = new System.Drawing.Point(749, 779);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 43);
            this.btnClose.TabIndex = 107;
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
            this.btnIssue.Location = new System.Drawing.Point(893, 778);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(138, 44);
            this.btnIssue.TabIndex = 106;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlRenewLicenseApplicationInfo1
            // 
            this.ctrlRenewLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlRenewLicenseApplicationInfo1.Location = new System.Drawing.Point(23, 484);
            this.ctrlRenewLicenseApplicationInfo1.Name = "ctrlRenewLicenseApplicationInfo1";
            this.ctrlRenewLicenseApplicationInfo1.Size = new System.Drawing.Size(1008, 291);
            this.ctrlRenewLicenseApplicationInfo1.TabIndex = 10;
            // 
            // ctrlDriverLicenseCardWithFilter1
            // 
            this.ctrlDriverLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 36);
            this.ctrlDriverLicenseCardWithFilter1.Name = "ctrlDriverLicenseCardWithFilter1";
            this.ctrlDriverLicenseCardWithFilter1.Size = new System.Drawing.Size(1021, 442);
            this.ctrlDriverLicenseCardWithFilter1.TabIndex = 9;
            this.ctrlDriverLicenseCardWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseCardWithFilter1_OnLicenseSelected);
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 831);
            this.Controls.Add(this.llShowLicense);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ctrlRenewLicenseApplicationInfo1);
            this.Controls.Add(this.ctrlDriverLicenseCardWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Local Driving License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseCardWithFilter ctrlDriverLicenseCardWithFilter1;
        private ctrlRenewLicenseApplicationInfo ctrlRenewLicenseApplicationInfo1;
        private System.Windows.Forms.LinkLabel llShowLicense;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
    }
}