using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            _LoadCountriesToComboBox();
            cbCountries.SelectedIndex = 0;

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
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
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
                if (File.Exists(_Person.ImagePath))
                    pbPersonalImage.Load(_Person.ImagePath);
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
                MessageBox.Show("Save failed");
                _IsEmpty = false;
                return;
            }

            if (clsPerson.IsPersonExist(txtNationalNo.Text))
            {
                epInputValidating.SetError(txtNationalNo, "National No already exist!");
                return;
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

            //if (!pbPersonalImage.Image.Equals(Resources.Male_512)  && !pbPersonalImage.Image.Equals(Resources.Female_512))
            //    _Person.ImagePath = pbPersonalImage.ImageLocation.ToString();
            //else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                MessageBox.Show("Save successfully");
            }
            else
                MessageBox.Show("Save failed!!");
            
            lblMode.Text = $"Edit Person";
            this.Text = "Edit Person";
            _PersonID = _Person.PersonID;
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
            //MessageBox.Show("Set image will be here!");
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Choose Image";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonalImage.Load(selectedFilePath);
            }

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Remove image will be here!");
            llRemoveImage.Visible=false;
            
            if (rbMale.Checked) 
            {
                pbPersonalImage.Image = Resources.Male_512;
            }
            else
            {
                pbPersonalImage.Image = Resources.Female_512;

            }
        }

    }
}
