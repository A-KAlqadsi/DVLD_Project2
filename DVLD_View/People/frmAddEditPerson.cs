using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_View.Globals;
using DVLD_View.Properties;

namespace DVLD_View
{
    public partial class frmAddEditPerson : Form
    {

		// Declare a delegate
		public delegate void DataBackEventHandler(int PersonID);

		// Declare an event using the delegate
		public event DataBackEventHandler evPersonIDBack;


		private enum enMode { AddNew =1,Update =2 }
		public enum enGender { Male = 0, Female = 1 };
		private enMode _Mode;
        private int _PersonID =-1;
        private clsPerson _Person;

        
        public frmAddEditPerson()
        {
            InitializeComponent();
           
            _Mode = enMode.AddNew;       
        }

		public frmAddEditPerson(int personID)
		{
			InitializeComponent();
			_PersonID = personID;
            _Mode = enMode.Update;
		}

		private void _LoadCountriesToComboBox()
        {
            DataTable dt = clsCountry.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbCountries.Items.Add(dr["CountryName"]);
            }
            
        }

        private void _ResetDefaultValues()
        {
            _LoadCountriesToComboBox();

            if(_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                lblMode.Text = "Add New Person";
                this.Text = "Add New Person";
            }
            else
            {
                lblMode.Text = "Update Person";
                this.Text = "Update Person";
            }

            if (rbMale.Checked)
                pbPersonalImage.Image = Resources.Male_512;
            else
				pbPersonalImage.Image = Resources.Female_512;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(18);

            dtpDateOfBirth.Value = dtpDateOfBirth.MinDate;

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(100);

            cbCountries.SelectedIndex = cbCountries.FindString("Yemen");

            txtNationalNo.Text = "";
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

		}

		private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Not found person with ID [" + _PersonID +"]", "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;           
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
			
            if (_Person.Gender == 0)
				rbMale.Checked = true;
			else
				rbFemale.Checked = true;

			txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = Convert.ToDateTime(_Person.DateOfBirth);
            cbCountries.SelectedItem = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            llRemoveImage.Visible = (_Person.ImagePath != "");

            if(_Person.ImagePath != "")
                if(File.Exists(_Person.ImagePath))
                    pbPersonalImage.ImageLocation =_Person.ImagePath;

            llRemoveImage.Visible = (_Person.ImagePath != "");

		}

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }

		private bool _HandlePersonImage()
		{

			//this procedure will handle the person image,
			//it will take care of deleting the old image from the folder
			//in case the image changed. and it will rename the new image with guid and 
			// place it in the images folder.


			//_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
			if (_Person.ImagePath != pbPersonalImage.ImageLocation)
			{
				if (_Person.ImagePath != "")
				{
					//first we delete the old image from the folder in case there is any.

					try
					{
						File.Delete(_Person.ImagePath);
					}
					catch (IOException)
					{
						// We could not delete the file.
						//log it later   
					}
				}

				if (pbPersonalImage.ImageLocation != null)
				{
					//then we copy the new image to the image folder after we rename it
					string SourceImageFile = pbPersonalImage.ImageLocation.ToString();

					if (Util.CopyImageToProjectImagesFolder(ref SourceImageFile))
					{
						pbPersonalImage.ImageLocation = SourceImageFile;
						return true;
					}
					else
					{
						MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}

			}
			return true;
		}


		private void btnSave_Click(object sender, EventArgs e)
        {
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!_HandlePersonImage())
				return;

			_Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.FirstName= txtFirstName.Text.Trim();
            _Person.SecondName=txtSecondName.Text.Trim();
            _Person.LastName= txtLastName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.Phone= txtPhone.Text.Trim();
			_Person.Email = txtEmail.Text.Trim();
			_Person.Address = txtAddress.Text.Trim();
			_Person.DateOfBirth = dtpDateOfBirth.Value;

			if (rbMale.Checked)
                _Person.Gender = (short)enGender.Male;
            else
                _Person.Gender = (short)enGender.Female;

            
            _Person.NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;

            if (pbPersonalImage.ImageLocation != null)
                _Person.ImagePath = pbPersonalImage.ImageLocation.ToString();
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
				lblMode.Text = $"Update Person";
				this.Text = "Update Person";
				lblPersonID.Text = _Person.PersonID.ToString();
				_Mode = enMode.Update;

				MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				evPersonIDBack?.Invoke(_Person.PersonID); // firing the event PersonIDBack

			}
			else
                MessageBox.Show("Data save failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Choose Image";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonalImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonalImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonalImage.Image = Resources.Male_512;
            else
                pbPersonalImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;  
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                epInputValidating.SetError(temp, "This field is required!");
            }
            else
                epInputValidating.SetError(temp, null);
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtNationalNo.Text.Trim() == "")
            {
                e.Cancel = true;
                epInputValidating.SetError(txtNationalNo, "National No is required!");
                return;
            }
            else
            {
                epInputValidating.SetError(txtNationalNo, null);
			}
            // make sure NationalNo is not already exists
			if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
				epInputValidating.SetError(txtNationalNo, "National No already exists!");
			}
			else
				epInputValidating.SetError(txtNationalNo, null);
		}

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;
            
            if(!Validation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                epInputValidating.SetError(txtEmail, "Invalid Email Format!");
            }
            else
            {
              epInputValidating.SetError(txtEmail,null);  
            };
        }

		private void rbFemale_Click(object sender, EventArgs e)
		{
            if (pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.Female_512;
		}

		private void rbMale_Click(object sender, EventArgs e)
		{
			if (pbPersonalImage.ImageLocation == null)
				pbPersonalImage.Image = Resources.Male_512;
		}
	}
}
