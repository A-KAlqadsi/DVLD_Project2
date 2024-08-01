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
    public partial class ctrlApplicationCard : UserControl
    {

        private clsApplication _Application;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;
        private int _PersonID = -1;
        public int LocalDrivingLicenseAppID
        {
            get
            {
                return _LocalDrivingLicenseAppID;
            }
        }

        public ctrlApplicationCard()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int localDrivingLicenseAppID)
        {
            _LocalDrivingLicenseAppID = localDrivingLicenseAppID;
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseAppID);
            if(_LocalDrivingLicenseApp != null )
            {
                _Application = clsApplication.Find(_LocalDrivingLicenseApp.ApplicationID);
                if (_Application != null)
                {
                    _FillApplicationCardInfo();
                }
                else
                {
                    _ResetApplicationCardInfo();
                    MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApp.ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _ResetApplicationCardInfo();
                MessageBox.Show("No Local Driving License Application with ID = " + localDrivingLicenseAppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }

        private void _ResetApplicationCardInfo()
        {
            lblDLAppID.Text = "[????]";
            lblAppDate.Text = "[????]";
            lblAppFees.Text = "[????]";
            lblAppID.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblAppStatus.Text = "[????]";
            lblAppType.Text = "[????]";
            lblClassName.Text = "[????]";
            lblLastStatusDate.Text = "[????]";
            lblPassedTests.Text = "[????]";
            lblUsername.Text = "[????]";
        }

        private void _FillApplicationCardInfo()
        {
            lblDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            lblClassName.Text = clsLicenseClass.Find(_LocalDrivingLicenseApp.LicenseClassID).ClassName;
            lblPassedTests.Text = $"{clsTest.CountPassedTest(_LocalDrivingLicenseAppID)}/3";

            lblAppID.Text = _Application.ApplicationID.ToString();
            lblAppDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblAppFees.Text = _Application.PaidFees.ToString();
            lblApplicant.Text = clsPerson.Find(_Application.ApplicantApplicationID).FullName();
            _PersonID =_Application.ApplicantApplicationID;
            lblAppStatus.Text = (_Application.ApplicationStatus == 1)? "New" : (_Application.ApplicationStatus == 2)?"Cancelled":"Completed";
            lblAppType.Text = clsApplicationType.Find(_Application.ApplicationTypeID).ApplicationTitle;
            lblLastStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            lblUsername.Text = clsUser.Find(_Application.UserID).Username;
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(_PersonID);
            personDetails.ShowDialog();
        }
    }
}
