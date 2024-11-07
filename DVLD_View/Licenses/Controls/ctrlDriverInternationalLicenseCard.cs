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
    public partial class ctrlDriverInternationalLicenseCard : UserControl
    {
		private int _InternationalLicenseID;
		private clsInternationalLicense _InternationalLicense;
		public ctrlDriverInternationalLicenseCard()
        {
            InitializeComponent();
        }

		public int InternationalLicenseID
		{
			get { return _InternationalLicenseID; }
		}

		private void _LoadPersonImage()
		{
			if (_InternationalLicense.DriverInfo.PersonInfo.Gender == 0)
				pbPersonalImage.Image = Resources.Male_512;
			else
				pbPersonalImage.Image = Resources.Female_512;

			string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

			if (ImagePath != "")
				if (File.Exists(ImagePath))
					pbPersonalImage.Load(ImagePath);
				else
					MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		public void LoadInfo(int interLicenseID)
        {
			_InternationalLicenseID = InternationalLicenseID;
			_InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
			if (_InternationalLicense == null)
			{
				MessageBox.Show("Could not find International License ID = " + _InternationalLicenseID.ToString(),
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_InternationalLicenseID = -1;
				return;
			}

			lblIntLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
			lblAppID.Text = _InternationalLicense.ApplicationID.ToString();
			lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
			lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
			lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
			lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
			lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
			lblDateOfBirth.Text = Format.DateToShort(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);

			lblDriverID.Text = _InternationalLicense.DriverID.ToString();
			lblIssueDate.Text = Format.DateToShort(_InternationalLicense.IssueDate);
			lblExpirationDate.Text = Format.DateToShort(_InternationalLicense.ExpirationDate);

			_LoadPersonImage();

		}


    }
}
