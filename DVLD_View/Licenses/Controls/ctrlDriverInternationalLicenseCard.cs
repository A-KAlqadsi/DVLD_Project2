﻿using DVLD_Business;
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
        DataTable _InterLicense;
        private string _ImagePath = @"C:\Users\Abdulkarim\source\Abu-Hadhoud\19 DVLD\DVLD_View\Icons\";

        public ctrlDriverInternationalLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadLicenseCardInfo(int interLicenseID)
        {
            _InterLicense = clsInternationalLicense.FindMaster(interLicenseID);

            if (_InterLicense.Rows.Count == 0)
            {
                _ResetLicenseCard();
                return;
            }
            else
                _FillLicenseCard();
        }

        private void _FillLicenseCard()
        {
           
            bool gender = false;
            string imagePath = "";
            foreach (DataRow row in _InterLicense.Rows)
            {

                lblIntLicenseID.Text = row["InternationalLicenseID"].ToString();
                lblAppID.Text = row["ApplicationID"].ToString();
                lblDateOfBirth.Text = Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString();
                lblDriverID.Text = row["DriverID"].ToString();
                lblExpirationDate.Text = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
                lblGender.Text = row["GenderTitle"].ToString();
                lblIsActive.Text = Convert.ToBoolean(row["IsActive"]) == true ? "Yes" : "No";
                lblIssueDate.Text = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
                lblLicenseID.Text = row["LicenseID"].ToString();
                lblName.Text = row["FullName"].ToString();
                lblNationalNo.Text = row["NationalNo"].ToString();

               

                gender = lblGender.Text == "Male" ? false : true;
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
            
            lblDateOfBirth.Text = "[????]";
            lblDriverID.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            lblGender.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblIssueDate.Text = "[????]";      
            lblLicenseID.Text = "[????]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
           
            _SetPersonalImage("", false);
        }



    }
}
