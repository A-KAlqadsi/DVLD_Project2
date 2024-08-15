using DVLD_Business;
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

namespace DVLD_View
{
    public partial class ctrlDriverLicenseCard : UserControl
    {
        private clsLicense _License;
        private clsPerson _Person;
        private string _ClassName;
        private int _LicenseID;
        private string _ImagePath = @"C:\Users\Abdulkarim\source\Abu-Hadhoud\19 DVLD\DVLD_View\Icons\";

        public ctrlDriverLicenseCard()
        {
            InitializeComponent();
            
        }

        public void LoadLicenseCardInfo(int licenseID)
        {
            _LicenseID = licenseID;
            _License = clsLicense.Find(_LicenseID);
            if (_License == null)
            {
                _ResetLicenseCard();
                return;
            }
            else
                _FillLicenseCard();
        }

        private void _FillLicenseCard()
        {
            int personId = clsApplication.Find(_License.ApplicationId).ApplicantApplicationID;
            _Person = clsPerson.Find(personId);
            _ClassName = clsLicenseClass.Find(_License.LicenseClassID).ClassName;

            if (_Person == null)
                return;

            lblLicenseID.Text = _LicenseID.ToString();
            lblClassName.Text = _ClassName;
            lblName.Text = _Person.FullName();
            lblNationalNo.Text = _Person.NationalNo;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblGender.Text = _Person.Gender == 0?"Male" : "Female";
            
            if (_Person.Gender == 1)
                pbGender.ImageLocation = _ImagePath + "Woman 32.png";
            else
                pbGender.ImageLocation = _ImagePath + "Man 32.png";
            
            _SetPersonalImage(_Person.ImagePath);

            lblDriverID.Text =_License.DriverID.ToString();
            lblIsActive.Text = _License.IsActive == true ? "Yes" : "No";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblIssueReason.Text = SetIssueReason(_License.IssueReason);
            if(string.IsNullOrEmpty(_License.Notes))
                lblNotes.Text = "No Notes";
            else
                lblNotes.Text = _License.Notes;

        }

        private void _SetPersonalImage(string imagePath)
        {
            if (File.Exists(imagePath))
                pbPersonalImage.ImageLocation = imagePath;
            else
            {
                if (_Person.Gender == 1)
                    pbPersonalImage.ImageLocation = _ImagePath + "Female 512.png";
                else
                    pbPersonalImage.ImageLocation = _ImagePath + "Male 512.png";
            }
        }

        private string SetIssueReason(short issueReason)
        {
            switch (issueReason)
            {
                case 1:
                    return "First Time";
            }
            return "";
        }

        private void _ResetLicenseCard()
        {
            lblClassName.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblDriverID.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            lblGender.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblIssueReason.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblNotes.Text = "[????]";
            _Person.Gender = 1;
            _SetPersonalImage("");
        }

    }
}
