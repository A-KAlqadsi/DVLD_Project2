using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_View
{
    public partial class ctrlRenewLicenseApplicationInfo : UserControl
    {
        private int _AppTypeID = 2; //  Renew license application type
        private int _OldLicenseID;
        public int ClassID = -1;
        public float LicenseFees;
        public float AppFees;

        public int AppTypeID { get { return _AppTypeID; } private set { } }

        public ctrlRenewLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadInitialData(int OldLicenseID)
        {
            DateTime issueDate = DateTime.Now;
            DateTime expireDate;
            int validityLength;
            clsLicenseClass licenseClass;

            _OldLicenseID = OldLicenseID;

            if (_OldLicenseID == -1)
                return;

            lblOldLicenseID.Text = OldLicenseID.ToString();
            AppFees = clsApplicationType.Find(_AppTypeID).ApplicationFees;
            lblAppFees.Text = AppFees.ToString();
            ClassID = clsLicense.Find(OldLicenseID).LicenseClassID;
            licenseClass = clsLicenseClass.Find(ClassID);

            validityLength = licenseClass.ValidityLength;
            LicenseFees = licenseClass.ClassFees;
            expireDate = issueDate.AddYears(validityLength);
            lblIssueDate.Text = issueDate.ToShortDateString();
            lblExpirationDate.Text = expireDate.ToShortDateString();
            lblUsername.Text = clsLoginUser.LoginUser;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
        }

    }
}
