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

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int localLicenseID, bool isFound, bool isActive, bool isClass3, bool isDetained);

        // Declare an event using the delegate
        public event DataBackEventHandler LocalLicenseInfoBack;

        public bool IsFound = false;
        public bool IsDetained = false;
        public bool IsClass3 = false;
        public int LocalLicenseID = -1;
        public bool IsActive = false;
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
            {
                LocalLicenseID = licenseID;
                _FillLicenseCard();
            }
        }

        private void _FillLicenseCard()
        {
            clsLicense license;
            
            bool gender = false;
            string imagePath = "";
            
            foreach (DataRow row in _LicenseInfo.Rows)
            {
                IsFound = true;
                //LocalLicenseID = Convert.ToInt32(row["LicenseID"]);
                license = clsLicense.Find(LocalLicenseID);

                if (license != null)
                {
                    LocalLicenseID = license.LicenseID;
                    if (license.LicenseClassID == 3)
                        IsClass3 = true;
                    else
                        IsClass3 = false;
                }
                else
                {
                    IsFound = false;
                    return;
                }

                lblClassName.Text = row["ClassName"].ToString();
                lblDateOfBirth.Text =Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString();
                lblDriverID.Text = row["DriverID"].ToString();
                lblExpirationDate.Text = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
                lblGender.Text = row["GenderTitle"].ToString();
                IsActive = Convert.ToBoolean(row["IsActive"]);
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
                // fire the event
                LocalLicenseInfoBack?.Invoke(this,LocalLicenseID, IsFound, IsActive, IsClass3, IsDetained);
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
