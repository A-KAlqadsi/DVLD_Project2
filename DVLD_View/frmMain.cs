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

namespace DVLD_View
{
    public partial class frmMain : Form
    {
        frmLoginScreen _LoginScreen;
        public frmMain(frmLoginScreen frm)
        {
            InitializeComponent();
            _LoginScreen = frm;
        }

        private void _CenterPictureBox()
        {
            pbDVLDLogo.Left = (this.ClientSize.Width - pbDVLDLogo.Width) / 2;
            pbDVLDLogo.Top = (this.ClientSize.Height - pbDVLDLogo.Height) / 2;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            _CenterPictureBox();
        }

        private void tsmiPeople_Click(object sender, EventArgs e)
        {
            frmListPeople managePeople = new frmListPeople();
            managePeople.ShowDialog();
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers manageUsers = new frmManageUsers();
            manageUsers.ShowDialog();
        }

        private void tsmiCurrentUserInfo_Click(object sender, EventArgs e)
        {
            
            frmUserDetails userDetails  = new frmUserDetails(Globals.Global.CurrentUser.UserID);
            userDetails.ShowDialog();
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            int userID =clsUser.Find(clsLoginUser.LoginUser).UserID;
            frmChangePassword changePassword =new frmChangePassword(userID);
            changePassword.ShowDialog();
        }

        private void tsmiManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes appTypes = new frmManageApplicationTypes();
            appTypes.ShowDialog();
        }

        private void tsmiSignOut_Click(object sender, EventArgs e)
        {
             Globals.Global.CurrentUser = null;
            _LoginScreen.Show();
            this.Close();
        }

        private void tsmiManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes manageTestTypes = new frmManageTestTypes();
            manageTestTypes.ShowDialog();
        }

        private void tsmiNewLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApp frm = new frmAddEditLocalDrivingLicenseApp();
            frm.ShowDialog();
        }

        private void tsmiLocalDrivingLicenseApps_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApp manageApps = new frmManageLocalDrivingLicenseApp();
            manageApps.ShowDialog();
        }

        private void tsmiDrivers_Click(object sender, EventArgs e)
        {
            frmListDrivers drivers = new frmListDrivers();
            drivers.ShowDialog();
        }

        private void tsmiNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApp interLicense = new frmAddNewInternationalLicenseApp();
            interLicense.ShowDialog();
        }

        private void tsmiInternationalLicenseApps_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenseApp international = new frmManageInternationalLicenseApp();
            international.ShowDialog();
        }

        private void tsmiRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense renewLicense = new frmRenewLocalDrivingLicense();
            renewLicense.ShowDialog();
        }

        private void tsmiLicenseReplacement_Click(object sender, EventArgs e)
        {
            frmReplacementForDamageOrLost replacement = new frmReplacementForDamageOrLost();
            replacement.ShowDialog();
        }

        private void tsmiRetakeTest_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApp localLicenses = new frmManageLocalDrivingLicenseApp();
            localLicenses.ShowDialog();
        }

        private void tsmiManageDetainedLicense_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses detainedLicenses = new frmManageDetainedLicenses();
            detainedLicenses.ShowDialog();
        }

        private void tsmiDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();
            detainLicense.ShowDialog();
        }

        private void tsmiReleaseDetainLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicense = new frmReleaseLicense();
            releaseLicense.ShowDialog();
        }

        private void tsmiReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicense = new frmReleaseLicense();
            releaseLicense.ShowDialog();
        }
    }
}
