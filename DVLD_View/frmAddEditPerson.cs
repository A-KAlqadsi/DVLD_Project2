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
using DVLD_View.Properties;

namespace DVLD_View
{
    public partial class frmAddEditPerson : Form
    {
        private  enum enMode { AddNew =1,Update =2 }
        private enMode _Mode;
        private int _PersonID;
        private clsPerson _Person;
        private bool _IsEmpty = false;
        private string _NationalNo;
        private string _ImageLocation = "";
        private string _DVLDPeopleImagesDirectory = @"C:\DVLD-People-Images";

        public frmAddEditPerson(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            if(_PersonID == -1)
                _Mode = enMode.AddNew;
            else 
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
        
        private void _LoadData()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            _LoadCountriesToComboBox();
            cbCountries.SelectedItem = "Yemen";

            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                this.Text = "Add Person";
                lblMode.Text = "Add New Person";
                return;
            }

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because no Person with ID=" + _PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblMode.Text = $"Edit Person";
            this.Text = "Edit Person";

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            _NationalNo = _Person.NationalNo;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = Convert.ToDateTime(_Person.DateOfBirth);
            cbCountries.SelectedItem = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            llRemoveImage.Visible = (_Person.ImagePath != "");


            if (_Person.Gender == 0)
            {
                rbMale.Checked = true;
                pbPersonalImage.Image = Resources.Male_512;
            }
            else
            {
                rbFemale.Checked = true;
                pbPersonalImage.Image =Resources.Female_512;
            }


            if(_Person.ImagePath != "")
            {
                if(File.Exists(_Person.ImagePath))
                {
                    pbPersonalImage.ImageLocation =_Person.ImagePath;
                    _ImageLocation = _Person.ImagePath;
                }
            }
            

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_IsTxtEmpty())
            {
                MessageBox.Show($"Can't Save, mouse hover on{Environment.NewLine}the red icon(s) for Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _IsEmpty = false;
                return;
            }

            if (clsPerson.IsPersonExist(txtNationalNo.Text) && txtNationalNo.Text != _NationalNo)
            {
                epInputValidating.SetError(txtNationalNo, "National No already exist!");
                MessageBox.Show($"Can't Save, mouse hover on{Environment.NewLine}the red icon(s) for Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtEmail.Text.Trim() != "")
            {
                if(!_IsValideEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show($"Can't Save, mouse hover on{Environment.NewLine}the red icon(s) for Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _Person.NationalNo = txtNationalNo.Text;
            _Person.FirstName= txtFirstName.Text;
            _Person.SecondName=txtSecondName.Text;
            _Person.LastName= txtLastName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.Phone= txtPhone.Text;
            _Person.Email= txtEmail.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Address= txtAddress.Text;
            _Person.NationalityCountryID = clsCountry.Find(cbCountries.SelectedItem.ToString()).CountryID;
            _Person.Gender = Convert.ToInt16((rbMale.Checked == true) ? 0 : 1);


            _Person.ImagePath = _ImageLocation;

            if (_Person.Save())
            {
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data save failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            lblMode.Text = $"Edit Person";
            this.Text = "Edit Person";
            _ImageLocation = _Person.ImagePath;
            _PersonID = _Person.PersonID;
            _NationalNo = _Person.NationalNo;
            lblPersonID.Text = _Person.PersonID.ToString();
            _Mode = enMode.Update;

        }

        private bool _IsTxtEmpty()
        {
            
            epInputValidating.Clear();
            if(txtFirstName.Text.Trim() == "")
            {
                _IsEmpty = true;
                epInputValidating.SetError(txtFirstName, "First name is required!");
            }

            if (txtSecondName.Text.Trim() == "")
            {
                _IsEmpty = true;
                epInputValidating.SetError(txtSecondName, "Second name is required!");
            }
            if (txtLastName.Text.Trim() == "")
            {
                _IsEmpty = true;
                epInputValidating.SetError(txtLastName, "Last name is required!");
            }
            if (txtNationalNo.Text.Trim() == "")
            {
                _IsEmpty = true;
                epInputValidating.SetError(txtNationalNo, "National No is required!");
            }
            if(txtPhone.Text.Trim()=="")
            {
                _IsEmpty = true;
                epInputValidating.SetError(txtPhone, "Phone is required!");
            }
            
            if (txtAddress.Text.Trim() == "")
            {
                _IsEmpty = true;
                epInputValidating.SetError(txtAddress, "Address is required!");
            }

            return _IsEmpty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Guid guid = Guid.NewGuid();
            string extention;
            string newFileName;
            string selectedFilePath;
            string destinationFilePath;
            //MessageBox.Show("Set image will be here!");
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Choose Image";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog1.FileName;
                if (!Directory.Exists(_DVLDPeopleImagesDirectory))
                {
                    Directory.CreateDirectory(_DVLDPeopleImagesDirectory);
                }

                 extention = Path.GetExtension(selectedFilePath).ToLower();
                 newFileName = guid.ToString() + extention;
                 
                 destinationFilePath = Path.Combine(_DVLDPeopleImagesDirectory, newFileName);
                
                File.Copy(selectedFilePath, destinationFilePath);
                
                _ImageLocation = destinationFilePath;
                
                pbPersonalImage.ImageLocation = _ImageLocation;
                
            }

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Remove image will be here!");
            llRemoveImage.Visible=false;
            pbPersonalImage.ImageLocation = null;
            if (rbMale.Checked) 
            {
                pbPersonalImage.Image = Resources.Male_512;
            }
            else
            {
                pbPersonalImage.Image = Resources.Female_512;
            }
            
            //if (File.Exists(_ImageLocation))
                File.Delete(_ImageLocation);
            _ImageLocation = "";

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtNationalNo.Text.Trim() == "")
            {
                epInputValidating.SetError(txtNationalNo, "National No is required!");
                return;
            }
            else
            {
                if (clsPerson.IsPersonExist(txtNationalNo.Text) && txtNationalNo.Text != _NationalNo)
                    epInputValidating.SetError(txtNationalNo, "National No already exists!");
                else
                    epInputValidating.SetError(txtNationalNo, "");
            }         
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text.Trim() == "")
                epInputValidating.SetError(txtFirstName, "First name is required!");
            else
                epInputValidating.SetError(txtFirstName, "");
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (txtSecondName.Text.Trim() == "")
                epInputValidating.SetError(txtSecondName, "Second name is required!");
            else
                epInputValidating.SetError(txtSecondName, "");
            
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Trim() == "")
                epInputValidating.SetError(txtLastName, "Last name is required!");
            else
                epInputValidating.SetError(txtLastName, "");

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Trim() == "")
                epInputValidating.SetError(txtPhone, "Phone is required!");
            else
                epInputValidating.SetError(txtPhone, "");

        }

        private bool IsValidEmailPattern(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool _IsValideEmail(string email)
        {
            if (!IsValidEmailPattern(email))
            {
                epInputValidating.SetError(txtEmail, "Email pattern (example@gmail.com) is not right!");
                return false;
            }
            else
                epInputValidating.SetError(txtEmail, "");
            return true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txtEmail.Text.Trim() != "")
            {
                _IsValideEmail(txtEmail.Text.Trim());
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text.Trim() == "")
                epInputValidating.SetError(txtAddress, "Address is required!");
            else
                epInputValidating.SetError(txtAddress, "");
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(_ImageLocation == "")
                pbPersonalImage.Image = Image.FromFile(@"C:\Users\Abdulkarim\source\Abu-Hadhoud\19 DVLD\DVLD_View\Icons\Male 512.png");
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(_ImageLocation == "")
                pbPersonalImage.Image = Image.FromFile(@"C:\Users\Abdulkarim\source\Abu-Hadhoud\19 DVLD\DVLD_View\Icons\Female 512.png");

        }

    }
}
