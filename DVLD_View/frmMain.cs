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
       
        public frmMain(string username)
        {
            InitializeComponent();
            clsLoginUser.LoginUser = username;

        }

        private void _CenterPictureBox()
        {
            pbDVLDLogo.Left = (this.ClientSize.Width - pbDVLDLogo.Width) / 2;
            pbDVLDLogo.Top = (this.ClientSize.Height - pbDVLDLogo.Height) / 2;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLoginUser.Text = $"Login Username is:[{clsLoginUser.LoginUser}]";
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
            int userID = clsUser.Find(clsLoginUser.LoginUser).UserID;

            frmUserDetails userDetails  = new frmUserDetails(userID);
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
            this.Close();
        }

        private void tsmiManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes manageTestTypes = new frmManageTestTypes();
            manageTestTypes.ShowDialog();
        }

        private void tsmiNewLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApp frm = new frmAddEditLocalDrivingLicenseApp(-1);
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
    }
}
