namespace DVLD_View
{
    partial class frmScheduleTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleTest));
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrlScheduleTest1 = new DVLD_View.Tests.Controls.ctrlScheduleTest();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(244, 648);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(156, 41);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrlScheduleTest1
			// 
			this.ctrlScheduleTest1.Location = new System.Drawing.Point(6, 4);
			this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
			this.ctrlScheduleTest1.Size = new System.Drawing.Size(572, 638);
			this.ctrlScheduleTest1.TabIndex = 18;
			this.ctrlScheduleTest1.TestTypeId = DVLD_Business.clsTestType.enTestType.VisionTest;
			// 
			// frmScheduleTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(578, 700);
			this.Controls.Add(this.ctrlScheduleTest1);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmScheduleTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Schedule Test";
			this.Load += new System.EventHandler(this.frmScheduleTest_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
		private Tests.Controls.ctrlScheduleTest ctrlScheduleTest1;
	}
}