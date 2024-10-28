namespace DVLD_View
{
    partial class frmTakeTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.rbPass = new System.Windows.Forms.RadioButton();
			this.rbFail = new System.Windows.Forms.RadioButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.ctrlScheduledTest1 = new DVLD_View.Tests.Controls.ctrlScheduledTest();
			this.lblUserMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(497, 646);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(138, 38);
			this.btnSave.TabIndex = 88;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(335, 646);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(138, 38);
			this.btnClose.TabIndex = 89;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 510);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 25);
			this.label2.TabIndex = 90;
			this.label2.Text = "Result:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(29, 545);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 25);
			this.label6.TabIndex = 91;
			this.label6.Text = "Notes:";
			// 
			// rbPass
			// 
			this.rbPass.AutoSize = true;
			this.rbPass.Checked = true;
			this.rbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPass.Location = new System.Drawing.Point(182, 508);
			this.rbPass.Name = "rbPass";
			this.rbPass.Size = new System.Drawing.Size(77, 29);
			this.rbPass.TabIndex = 92;
			this.rbPass.TabStop = true;
			this.rbPass.Text = "Pass";
			this.rbPass.UseVisualStyleBackColor = true;
			// 
			// rbFail
			// 
			this.rbFail.AutoSize = true;
			this.rbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFail.Location = new System.Drawing.Point(263, 508);
			this.rbFail.Name = "rbFail";
			this.rbFail.Size = new System.Drawing.Size(64, 29);
			this.rbFail.TabIndex = 93;
			this.rbFail.Text = "Fail";
			this.rbFail.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(114, 507);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(39, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 94;
			this.pictureBox2.TabStop = false;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(180, 545);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(455, 95);
			this.txtNotes.TabIndex = 95;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(113, 545);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(39, 30);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 96;
			this.pictureBox3.TabStop = false;
			// 
			// ctrlScheduledTest1
			// 
			this.ctrlScheduledTest1.BackColor = System.Drawing.Color.White;
			this.ctrlScheduledTest1.Location = new System.Drawing.Point(1, 2);
			this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
			this.ctrlScheduledTest1.Size = new System.Drawing.Size(643, 498);
			this.ctrlScheduledTest1.TabIndex = 97;
			this.ctrlScheduledTest1.TestTypeId = DVLD_Business.clsTestType.enTestType.VisionTest;
			// 
			// lblUserMessage
			// 
			this.lblUserMessage.AutoSize = true;
			this.lblUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
			this.lblUserMessage.Location = new System.Drawing.Point(335, 510);
			this.lblUserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblUserMessage.Name = "lblUserMessage";
			this.lblUserMessage.Size = new System.Drawing.Size(304, 25);
			this.lblUserMessage.TabIndex = 200;
			this.lblUserMessage.Text = "You cannot change the results";
			this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblUserMessage.Visible = false;
			// 
			// frmTakeTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(643, 696);
			this.Controls.Add(this.lblUserMessage);
			this.Controls.Add(this.ctrlScheduledTest1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.rbFail);
			this.Controls.Add(this.rbPass);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmTakeTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Take Test";
			this.Load += new System.EventHandler(this.frmTakeTest_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox3;
		private Tests.Controls.ctrlScheduledTest ctrlScheduledTest1;
		private System.Windows.Forms.Label lblUserMessage;
	}
}