namespace DVLD_View
{
    partial class ctrlDriverLicenseCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicenseCardWithFilter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchLicenseID = new System.Windows.Forms.TextBox();
            this.ctrlDriverLicenseCard1 = new DVLD_View.ctrlDriverLicenseCard();
            this.epFindLicenseValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFindLicenseValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchLicenseID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(599, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 65);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "License ID:";
            // 
            // txtSearchLicenseID
            // 
            this.txtSearchLicenseID.Location = new System.Drawing.Point(212, 42);
            this.txtSearchLicenseID.Name = "txtSearchLicenseID";
            this.txtSearchLicenseID.Size = new System.Drawing.Size(348, 30);
            this.txtSearchLicenseID.TabIndex = 0;
            this.txtSearchLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchLicenseID_KeyPress);
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(3, 112);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(1015, 332);
            this.ctrlDriverLicenseCard1.TabIndex = 0;
            // 
            // epFindLicenseValidate
            // 
            this.epFindLicenseValidate.ContainerControl = this;
            // 
            // ctrlDriverLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.Name = "ctrlDriverLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(1021, 444);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFindLicenseValidate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchLicenseID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider epFindLicenseValidate;
    }
}
