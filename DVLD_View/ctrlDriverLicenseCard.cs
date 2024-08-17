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
        public bool IsFound = false;
        public bool IsDetained = false;
        DataTable _LicenseInfo;
        private string _ImagePath = @"C:\Users\Abdulkarim\source\Abu-Hadhoud\19 DVLD\DVLD_View\Icons\";

        public ctrlDriverLicenseCard()
        {
            InitializeComponent();          
        }

        public void LoadLicenseCardInfo(int licenseID)
        {
            _LicenseInfo = clsLicense.FindMaster(licenseID);

            if (_LicenseInfo.Rows.Count == 0)
            {
                _ResetLicenseCard();
                MessageBox.Show($"No license with ID={licenseID}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillLicenseCard();
        }

        private void _FillLicenseCard()
        {
            bool gender = false;
            string imagePath = "";
            foreach (DataRow row in _LicenseInfo.Rows)
            {
                IsFound = true;
                lblClassName.Text = row["ClassName"].ToString();
                lblDateOfBirth.Text =Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString();
                lblDriverID.Text = row["DriverID"].ToString();
                lblExpirationDate.Text = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
                lblGender.Text = row["GenderTitle"].ToString();
                lblIsActive.Text = Convert.ToBoolean(row["IsActive"]) ==true ? "Yes" : "No";
                lblIsDetained.Text = row["IsDetained"] == DBNull.Value ? "No" : "Yes";
                lblIssueDate.Text = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
                lblIssueReason.Text = row["IssueReasonTitle"].ToString();
                lblLicenseID.Text = row["LicenseID"].ToString();
                lblName.Text = row["FullName"].ToString();
                lblNationalNo.Text = row["NationalNo"].ToString();
                lblNotes.Text = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : "No Notes";

                if (lblIsDetained.Text == "Yes")
                    IsDetained = true;
                else
                    IsDetained = false;

                gender = lblGender.Text == "Male"?false:true;
                imagePath = row["ImagePath"] != DBNull.Value ? row["ImagePath"].ToString() : "";
                
                if (gender)
                    pbGender.ImageLocation = _ImagePath + "Woman 32.png";
                else
                    pbGender.ImageLocation = _ImagePath + "Man 32.png";
                _SetPersonalImage(imagePath, gender);
            }
        }

        private void _SetPersonalImage(string imagePath, bool gender)
        {
            if (File.Exists(imagePath))
                pbPersonalImage.ImageLocation = imagePath;
            else
            {
                if (gender)
                    pbPersonalImage.ImageLocation = _ImagePath + "Female 512.png";
                else
                    pbPersonalImage.ImageLocation = _ImagePath + "Male 512.png";
            }
        }

        private void _ResetLicenseCard()
        {
            lblClassName.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblDriverID.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            lblGender.Text = "[????]";
            lblIsDetained.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblIssueReason.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblNotes.Text = "[????]";
            _SetPersonalImage("",false);
        }

    }
}
