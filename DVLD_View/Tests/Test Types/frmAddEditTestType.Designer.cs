namespace DVLD_View
{
    partial class frmAddEditTestType
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditTestType));
			this.txtFees = new System.Windows.Forms.TextBox();
			this.lblTestTypeID = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lblMode = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pbTitle = new System.Windows.Forms.PictureBox();
			this.pbFees = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbDescription = new System.Windows.Forms.PictureBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.epValidateInput = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDescription)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epValidateInput)).BeginInit();
			this.SuspendLayout();
			// 
			// txtFees
			// 
			this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFees.Location = new System.Drawing.Point(219, 391);
			this.txtFees.Name = "txtFees";
			this.txtFees.Size = new System.Drawing.Size(453, 30);
			this.txtFees.TabIndex = 2;
			this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
			// 
			// lblTestTypeID
			// 
			this.lblTestTypeID.AutoSize = true;
			this.lblTestTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTestTypeID.Location = new System.Drawing.Point(214, 89);
			this.lblTestTypeID.Name = "lblTestTypeID";
			this.lblTestTypeID.Size = new System.Drawing.Size(48, 25);
			this.lblTestTypeID.TabIndex = 39;
			this.lblTestTypeID.Text = "???";
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(219, 136);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(453, 30);
			this.txtTitle.TabIndex = 0;
			this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
			// 
			// lblMode
			// 
			this.lblMode.AutoSize = true;
			this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblMode.Location = new System.Drawing.Point(237, 7);
			this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMode.Name = "lblMode";
			this.lblMode.Size = new System.Drawing.Size(250, 36);
			this.lblMode.TabIndex = 37;
			this.lblMode.Text = "Update Test Type";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(538, 427);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(134, 43);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
			this.btnClose.Location = new System.Drawing.Point(397, 427);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(134, 43);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbTitle
			// 
			this.pbTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
			this.pbTitle.Location = new System.Drawing.Point(167, 136);
			this.pbTitle.Margin = new System.Windows.Forms.Padding(2);
			this.pbTitle.Name = "pbTitle";
			this.pbTitle.Size = new System.Drawing.Size(41, 32);
			this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbTitle.TabIndex = 42;
			this.pbTitle.TabStop = false;
			// 
			// pbFees
			// 
			this.pbFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
			this.pbFees.Location = new System.Drawing.Point(167, 391);
			this.pbFees.Margin = new System.Windows.Forms.Padding(2);
			this.pbFees.Name = "pbFees";
			this.pbFees.Size = new System.Drawing.Size(41, 32);
			this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbFees.TabIndex = 41;
			this.pbFees.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(72, 391);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 25);
			this.label4.TabIndex = 47;
			this.label4.Text = "Fees:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(78, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 25);
			this.label3.TabIndex = 46;
			this.label3.Text = "Title:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(99, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 25);
			this.label2.TabIndex = 45;
			this.label2.Text = "ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 48;
			this.label1.Text = "Description:";
			// 
			// pbDescription
			// 
			this.pbDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbDescription.Image = ((System.Drawing.Image)(resources.GetObject("pbDescription.Image")));
			this.pbDescription.Location = new System.Drawing.Point(167, 184);
			this.pbDescription.Margin = new System.Windows.Forms.Padding(2);
			this.pbDescription.Name = "pbDescription";
			this.pbDescription.Size = new System.Drawing.Size(41, 32);
			this.pbDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbDescription.TabIndex = 49;
			this.pbDescription.TabStop = false;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(219, 184);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(453, 201);
			this.txtDescription.TabIndex = 1;
			this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
			// 
			// epValidateInput
			// 
			this.epValidateInput.ContainerControl = this;
			// 
			// frmAddEditTestType
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(696, 488);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.pbDescription);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pbTitle);
			this.Controls.Add(this.pbFees);
			this.Controls.Add(this.txtFees);
			this.Controls.Add(this.lblTestTypeID);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblMode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddEditTestType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmAddEditTestType";
			this.Load += new System.EventHandler(this.frmAddEditTestType_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDescription)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epValidateInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ErrorProvider epValidateInput;
    }
}