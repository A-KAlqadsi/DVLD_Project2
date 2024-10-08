namespace DVLD_View
{
    partial class frmShowInternationalLicenseCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalLicenseCard));
            this.label1 = new System.Windows.Forms.Label();
            this.pbManageLDLApps = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlDriverInternationalLicenseCard1 = new DVLD_View.ctrlDriverInternationalLicenseCard();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(285, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Driver International License Info";
            // 
            // pbManageLDLApps
            // 
            this.pbManageLDLApps.BackColor = System.Drawing.Color.Transparent;
            this.pbManageLDLApps.Image = ((System.Drawing.Image)(resources.GetObject("pbManageLDLApps.Image")));
            this.pbManageLDLApps.Location = new System.Drawing.Point(409, 0);
            this.pbManageLDLApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbManageLDLApps.Name = "pbManageLDLApps";
            this.pbManageLDLApps.Size = new System.Drawing.Size(235, 114);
            this.pbManageLDLApps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageLDLApps.TabIndex = 8;
            this.pbManageLDLApps.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlDriverInternationalLicenseCard1
            // 
            this.ctrlDriverInternationalLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverInternationalLicenseCard1.Location = new System.Drawing.Point(15, 166);
            this.ctrlDriverInternationalLicenseCard1.Name = "ctrlDriverInternationalLicenseCard1";
            this.ctrlDriverInternationalLicenseCard1.Size = new System.Drawing.Size(1012, 301);
            this.ctrlDriverInternationalLicenseCard1.TabIndex = 11;
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
            this.btnClose.Location = new System.Drawing.Point(889, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 43);
            this.btnClose.TabIndex = 104;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmShowInternationalLicenseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 531);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDriverInternationalLicenseCard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbManageLDLApps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowInternationalLicenseCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "International Driver Info";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageLDLApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManageLDLApps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlDriverInternationalLicenseCard ctrlDriverInternationalLicenseCard1;
        private System.Windows.Forms.Button btnClose;
    }
}