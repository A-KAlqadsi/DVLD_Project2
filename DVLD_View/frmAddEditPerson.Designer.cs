namespace DVLD_View
{
    partial class frmAddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPerson));
            this.lblMode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.pbFemale = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbDateOfBirth = new System.Windows.Forms.PictureBox();
            this.pbNationalNo = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPersonalImage = new System.Windows.Forms.PictureBox();
            this.pbAddress = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbMale = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epInputValidating = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInputValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMode.Location = new System.Drawing.Point(417, 4);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(241, 36);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "Add New Person";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.llRemoveImage);
            this.panel1.Controls.Add(this.llSetImage);
            this.panel1.Controls.Add(this.pbFemale);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.cbCountries);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNationalNo);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtThirdName);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.pbCountry);
            this.panel1.Controls.Add(this.pbPhone);
            this.panel1.Controls.Add(this.pbDateOfBirth);
            this.panel1.Controls.Add(this.pbNationalNo);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbPersonalImage);
            this.panel1.Controls.Add(this.pbAddress);
            this.panel1.Controls.Add(this.pbEmail);
            this.panel1.Controls.Add(this.pbMale);
            this.panel1.Controls.Add(this.pbName);
            this.panel1.Location = new System.Drawing.Point(15, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 379);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(672, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 49);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(519, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 49);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemoveImage.Location = new System.Drawing.Point(883, 301);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(120, 20);
            this.llRemoveImage.TabIndex = 13;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove Image";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(883, 271);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(84, 20);
            this.llSetImage.TabIndex = 12;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // pbFemale
            // 
            this.pbFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFemale.Image = global::DVLD_View.Properties.Resources.Woman_32;
            this.pbFemale.Location = new System.Drawing.Point(272, 130);
            this.pbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.pbFemale.Name = "pbFemale";
            this.pbFemale.Size = new System.Drawing.Size(39, 30);
            this.pbFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFemale.TabIndex = 63;
            this.pbFemale.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 60;
            this.label10.Text = "Last";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(691, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Third";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "First";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(629, 89);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(181, 30);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Value = new System.DateTime(2024, 7, 9, 0, 0, 0, 0);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(314, 131);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 29);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.Tag = "1";
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(629, 184);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(181, 33);
            this.cbCountries.Sorted = true;
            this.cbCountries.TabIndex = 10;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(198, 131);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(76, 29);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "0";
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(629, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 30);
            this.txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 235);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(613, 77);
            this.txtAddress.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNo.Location = new System.Drawing.Point(197, 89);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(181, 30);
            this.txtNationalNo.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(845, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 30);
            this.txtLastName.TabIndex = 3;
            // 
            // txtThirdName
            // 
            this.txtThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.Location = new System.Drawing.Point(629, 37);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(181, 30);
            this.txtThirdName.TabIndex = 2;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(413, 37);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(181, 30);
            this.txtSecondName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(197, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 30);
            this.txtFirstName.TabIndex = 0;
            // 
            // pbCountry
            // 
            this.pbCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCountry.Image = ((System.Drawing.Image)(resources.GetObject("pbCountry.Image")));
            this.pbCountry.Location = new System.Drawing.Point(585, 185);
            this.pbCountry.Margin = new System.Windows.Forms.Padding(2);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(39, 30);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCountry.TabIndex = 25;
            this.pbCountry.TabStop = false;
            // 
            // pbPhone
            // 
            this.pbPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbPhone.Image")));
            this.pbPhone.Location = new System.Drawing.Point(585, 134);
            this.pbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(39, 30);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhone.TabIndex = 26;
            this.pbPhone.TabStop = false;
            // 
            // pbDateOfBirth
            // 
            this.pbDateOfBirth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("pbDateOfBirth.Image")));
            this.pbDateOfBirth.Location = new System.Drawing.Point(585, 89);
            this.pbDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.pbDateOfBirth.Name = "pbDateOfBirth";
            this.pbDateOfBirth.Size = new System.Drawing.Size(39, 30);
            this.pbDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateOfBirth.TabIndex = 27;
            this.pbDateOfBirth.TabStop = false;
            // 
            // pbNationalNo
            // 
            this.pbNationalNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNationalNo.Image = ((System.Drawing.Image)(resources.GetObject("pbNationalNo.Image")));
            this.pbNationalNo.Location = new System.Drawing.Point(153, 89);
            this.pbNationalNo.Margin = new System.Windows.Forms.Padding(2);
            this.pbNationalNo.Name = "pbNationalNo";
            this.pbNationalNo.Size = new System.Drawing.Size(39, 30);
            this.pbNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNationalNo.TabIndex = 28;
            this.pbNationalNo.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(468, 185);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "Country:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(482, 136);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 42;
            this.label15.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(420, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Date Of Birth:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "National No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name:";
            // 
            // pbPersonalImage
            // 
            this.pbPersonalImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbPersonalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonalImage.Image = global::DVLD_View.Properties.Resources.Male_512;
            this.pbPersonalImage.Location = new System.Drawing.Point(845, 90);
            this.pbPersonalImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbPersonalImage.Name = "pbPersonalImage";
            this.pbPersonalImage.Size = new System.Drawing.Size(181, 173);
            this.pbPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonalImage.TabIndex = 23;
            this.pbPersonalImage.TabStop = false;
            // 
            // pbAddress
            // 
            this.pbAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddress.Image = ((System.Drawing.Image)(resources.GetObject("pbAddress.Image")));
            this.pbAddress.Location = new System.Drawing.Point(153, 231);
            this.pbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.pbAddress.Name = "pbAddress";
            this.pbAddress.Size = new System.Drawing.Size(39, 30);
            this.pbAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddress.TabIndex = 22;
            this.pbAddress.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
            this.pbEmail.Location = new System.Drawing.Point(153, 179);
            this.pbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(39, 30);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmail.TabIndex = 21;
            this.pbEmail.TabStop = false;
            // 
            // pbMale
            // 
            this.pbMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMale.Image = global::DVLD_View.Properties.Resources.Man_32;
            this.pbMale.Location = new System.Drawing.Point(153, 130);
            this.pbMale.Margin = new System.Windows.Forms.Padding(2);
            this.pbMale.Name = "pbMale";
            this.pbMale.Size = new System.Drawing.Size(39, 30);
            this.pbMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMale.TabIndex = 20;
            this.pbMale.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbName.Image = ((System.Drawing.Image)(resources.GetObject("pbName.Image")));
            this.pbName.Location = new System.Drawing.Point(153, 37);
            this.pbName.Margin = new System.Windows.Forms.Padding(2);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(39, 30);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbName.TabIndex = 24;
            this.pbName.TabStop = false;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(189, 61);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(49, 25);
            this.lblPersonID.TabIndex = 31;
            this.lblPersonID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Person ID :";
            // 
            // epInputValidating
            // 
            this.epInputValidating.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Person";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInputValidating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCountry;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbDateOfBirth;
        private System.Windows.Forms.PictureBox pbNationalNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbPersonalImage;
        private System.Windows.Forms.PictureBox pbAddress;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbMale;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbFemale;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epInputValidating;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}