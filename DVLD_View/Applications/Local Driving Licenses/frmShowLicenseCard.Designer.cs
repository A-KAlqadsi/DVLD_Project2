namespace DVLD_View
{
    partial class frmShowLicenseCard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLicenseCard));
			this.ctrlDriverLicenseCard1 = new DVLD_View.ctrlDriverLicenseCard();
			this.pbManageLDLApps = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).BeginInit();
			this.SuspendLayout();
			// 
			// ctrlDriverLicenseCard1
			// 
			this.ctrlDriverLicenseCard1.BackColor = System.Drawing.Color.White;
			this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(16, 177);
			this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
			this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(1015, 331);
			this.ctrlDriverLicenseCard1.TabIndex = 0;
			// 
			// pbManageLDLApps
			// 
			this.pbManageLDLApps.BackColor = System.Drawing.Color.Transparent;
			this.pbManageLDLApps.Image = ((System.Drawing.Image)(resources.GetObject("pbManageLDLApps.Image")));
			this.pbManageLDLApps.Location = new System.Drawing.Point(467, 3);
			this.pbManageLDLApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbManageLDLApps.Name = "pbManageLDLApps";
			this.pbManageLDLApps.Size = new System.Drawing.Size(160, 124);
			this.pbManageLDLApps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbManageLDLApps.TabIndex = 6;
			this.pbManageLDLApps.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(415, 132);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(263, 36);
			this.label1.TabIndex = 7;
			this.label1.Text = "Driver License Info";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(893, 514);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 41);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmShowLicenseCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1047, 564);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbManageLDLApps);
			this.Controls.Add(this.ctrlDriverLicenseCard1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmShowLicenseCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "License Info";
			this.Load += new System.EventHandler(this.frmShowLicenseCard_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        private System.Windows.Forms.PictureBox pbManageLDLApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}