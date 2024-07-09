﻿namespace DVLD_View
{
    partial class ctrlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonFilters = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DVLD_View.ctrlPersonCard();
            this.epFilterValidating = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epFilterValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By :";
            // 
            // cbPersonFilters
            // 
            this.cbPersonFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersonFilters.FormattingEnabled = true;
            this.cbPersonFilters.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbPersonFilters.Location = new System.Drawing.Point(104, 11);
            this.cbPersonFilters.Name = "cbPersonFilters";
            this.cbPersonFilters.Size = new System.Drawing.Size(181, 33);
            this.cbPersonFilters.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(291, 11);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 33);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.WordWrap = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(527, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(49, 41);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(472, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(49, 41);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 57);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(910, 249);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // epFilterValidating
            // 
            this.epFilterValidating.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbPersonFilters);
            this.Controls.Add(this.label1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(913, 303);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epFilterValidating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNew;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider epFilterValidating;
    }
}
