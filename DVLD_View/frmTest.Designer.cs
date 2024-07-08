namespace DVLD_View
{
    partial class frmTest
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
            this.ctrlUserPersonCard1 = new DVLD_View.ctrlUserPersonCard();
            this.ctrlPersonCard1 = new DVLD_View.ctrlPersonCard();
            this.ctrlPersonCardWithFilter1 = new DVLD_View.ctrlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // ctrlUserPersonCard1
            // 
            this.ctrlUserPersonCard1.Location = new System.Drawing.Point(8, 250);
            this.ctrlUserPersonCard1.Name = "ctrlUserPersonCard1";
            this.ctrlUserPersonCard1.Size = new System.Drawing.Size(812, 334);
            this.ctrlUserPersonCard1.TabIndex = 1;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(12, -1);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(808, 245);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(512, 104);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(813, 307);
            this.ctrlPersonCardWithFilter1.TabIndex = 2;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 574);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.ctrlUserPersonCard1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private ctrlUserPersonCard ctrlUserPersonCard1;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}