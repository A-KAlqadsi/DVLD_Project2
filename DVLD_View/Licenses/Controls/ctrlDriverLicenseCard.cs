using DVLD_Business;
using DVLD_View.Globals;
using DVLD_View.Properties;
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
        private int _LicenseID;

        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
        }
        public clsLicense SelectedLicenseInfo
        {
            get
            {
                return _License;
            }
        }

        public ctrlDriverLicenseCard()
        {
            InitializeComponent();          
        }

        public void LoadInfo(int licenseID)
        {
            
            _License = clsLicense.Find(licenseID);

            if(_License == null)
            {
				MessageBox.Show($"No license with ID={licenseID}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
			}
            _LicenseID = _License.LicenseID;

            lblClassName.Text = _License.LicenseClassInfo.ClassName;
			lblDateOfBirth.Text = Globals.Format.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);

            lblDriverID.Text = _License.DriverID.ToString();
			lblExpirationDate.Text = Format.DateToShort(_License.ExpirationDate);

			lblGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male": "Female";
			lblIsActive.Text = _License.IsActive ? "Yes":"No";
			lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
			lblIssueDate.Text = Format.DateToShort(_License.IssueDate);
            lblIssueReason.Text = _License.IssueReasonText;
			lblLicenseID.Text = _License.LicenseID.ToString();
			lblName.Text = _License.DriverInfo.PersonInfo.FullName;
			lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            
            _LoadImage();

		}


        private void _LoadImage()
        {

            if (_License.DriverInfo.PersonInfo.Gender == 0)
            {
				pbPersonalImage.Image = Resources.Male_512;
                pbGender.Image = Resources.Man_32;
			}
			else
            {
				pbPersonalImage.Image = Resources.Female_512;
                pbGender.Image = Resources.Woman_32;
			}

			string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

			if (ImagePath != "")
				if (File.Exists(ImagePath))
					pbPersonalImage.Load(ImagePath);
				else
					MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}


	}
}
