using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using System.IO;
using DVLD_View.Properties;

namespace DVLD_View
{
    public partial class ctrlPersonCard : UserControl
    {

        private clsPerson _Person;
        private int _PersonID = -1;
        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person;}
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personID)
        {
            
            _Person = clsPerson.Find(personID);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + personID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else                
                _FillPersonInfo();
        }

        public void LoadPersonInfo(string nationalNo)
        {
            _Person = clsPerson.Find(nationalNo);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with NationalNo = " + nationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
               _FillPersonInfo();
        }

        private void _ResetPersonInfo()
        {
            llEditPerson.Enabled = false;
            lblPersonID.Text = "[????]";
            lblName.Text = "[????]";
            lblAddress.Text = "[????]";
            lblCountry.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            pbGender.Image = Resources.Man_32;
            lblEmail.Text = "[????]";
            lblGender.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblPhone.Text = "[????]";
            pbPersonalImage.Image = Resources.Male_512;
        }
        private void _LoadPersonImage()
        {
			if (_Person.Gender == 0)
            {
				pbGender.Image = Resources.Man_32;
				pbPersonalImage.Image = Resources.Male_512;
			}
            else
            {
				pbGender.Image = Resources.Woman_32;
				pbPersonalImage.Image = Resources.Female_512;
			}

			if (_Person.ImagePath != "")
				if (File.Exists(_Person.ImagePath))
					pbPersonalImage.ImageLocation =_Person.ImagePath;
				else
					MessageBox.Show("Could not find this image: " + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		private void _FillPersonInfo()
        {
			llEditPerson.Enabled = true;
			_PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo.ToString();
            lblName.Text = _Person.FullName;
			lblEmail.Text = _Person.Email;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
			lblPhone.Text = _Person.Phone;
			lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
			lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
			lblAddress.Text = _Person.Address;

            _LoadPersonImage();
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson(_PersonID);
            addEditPerson.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
