namespace DVLD_View
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
			this.ctrlPersonCard1 = new DVLD_View.ctrlPersonCard();
			this.epFilterValidating = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbFilter = new System.Windows.Forms.GroupBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.cbPersonFilters = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.epFilterValidating)).BeginInit();
			this.gbFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// ctrlPersonCard1
			// 
			this.ctrlPersonCard1.Location = new System.Drawing.Point(2, 97);
			this.ctrlPersonCard1.Name = "ctrlPersonCard1";
			this.ctrlPersonCard1.Size = new System.Drawing.Size(910, 248);
			this.ctrlPersonCard1.TabIndex = 6;
			// 
			// epFilterValidating
			// 
			this.epFilterValidating.ContainerControl = this;
			// 
			// gbFilter
			// 
			this.gbFilter.Controls.Add(this.btnAddNew);
			this.gbFilter.Controls.Add(this.txtSearch);
			this.gbFilter.Controls.Add(this.btnFind);
			this.gbFilter.Controls.Add(this.cbPersonFilters);
			this.gbFilter.Controls.Add(this.label1);
			this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFilter.Location = new System.Drawing.Point(3, 4);
			this.gbFilter.Name = "gbFilter";
			this.gbFilter.Size = new System.Drawing.Size(907, 86);
			this.gbFilter.TabIndex = 7;
			this.gbFilter.TabStop = false;
			this.gbFilter.Text = "Filter";
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
			this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(598, 19);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(55, 54);
			this.btnAddNew.TabIndex = 7;
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(354, 29);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(166, 33);
			this.txtSearch.TabIndex = 4;
			this.txtSearch.WordWrap = false;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// btnFind
			// 
			this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
			this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(533, 19);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(58, 54);
			this.btnFind.TabIndex = 5;
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
			// 
			// cbPersonFilters
			// 
			this.cbPersonFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPersonFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPersonFilters.FormattingEnabled = true;
			this.cbPersonFilters.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
			this.cbPersonFilters.Location = new System.Drawing.Point(167, 29);
			this.cbPersonFilters.Name = "cbPersonFilters";
			this.cbPersonFilters.Size = new System.Drawing.Size(181, 33);
			this.cbPersonFilters.TabIndex = 8;
			this.cbPersonFilters.SelectedIndexChanged += new System.EventHandler(this.cbPersonFilters_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(74, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Find By :";
			// 
			// ctrlPersonCardWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gbFilter);
			this.Controls.Add(this.ctrlPersonCard1);
			this.Name = "ctrlPersonCardWithFilter";
			this.Size = new System.Drawing.Size(913, 344);
			this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
			((System.ComponentModel.ISupportInitialize)(this.epFilterValidating)).EndInit();
			this.gbFilter.ResumeLayout(false);
			this.gbFilter.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epFilterValidating;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbFilter;
        public ctrlPersonCard ctrlPersonCard1;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.ComboBox cbPersonFilters;
    }
}
