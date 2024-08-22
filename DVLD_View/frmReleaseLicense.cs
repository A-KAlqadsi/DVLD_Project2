using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_View
{
    public partial class frmReleaseLicense : Form
    {

        private bool _IsDetained;
        private bool _IsFound;
        private int _LocalLicenseID;
        private int _DetainID = -1;
        private int _PersonID = -1;
        clsDetainedLicense _DetainedLicense;
        clsReleaseLicense _ReleaseLicense;
        private int _ReleaseID = -1;
        clsApplication _Application;
        private int _ApplicationID = -1;
        private const int _ApplicationType = 5;
        private float _TotalFees;
        private float _AppFees;
        private float _FineFees;
        
        enum enReleaseMode {Search =1, PassLicenseID =2}
        enReleaseMode _ReleaseMode;
        public frmReleaseLicense(int licenesID)
        {
            InitializeComponent();
            _LocalLicenseID = licenesID;
            if(_LocalLicenseID == -1)
                _ReleaseMode = enReleaseMode.Search;
            else
                _ReleaseMode= enReleaseMode.PassLicenseID;

        }

        private void _LoadData()
        {
            if(_ReleaseMode == enReleaseMode.PassLicenseID)
            {
                ctrlDriverLicenseCardWithFilter1.txtSearchLicenseID.Text = _LocalLicenseID.ToString();
                ctrlDriverLicenseCardWithFilter1.btnSearch.PerformClick();
                ctrlDriverLicenseCardWithFilter1.gbFilter.Enabled = false;
            }
            else
            {
                ctrlDriverLicenseCardWithFilter1.txtSearchLicenseID.Clear();
                ctrlDriverLicenseCardWithFilter1.gbFilter.Enabled = true;
                ctrlDriverLicenseCardWithFilter1.txtSearchLicenseID.Focus();
            }
        }

        private void SetDefaults()
        {
            _AppFees= clsApplicationType.Find(_ApplicationType).ApplicationFees;
            lblApplicationFees.Text = _AppFees.ToString();
            if(_DetainedLicense != null)
            {
                lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
                lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                _FineFees = _DetainedLicense.FineFees;
                lblFineFees.Text = _FineFees.ToString();
                lblLicenseID.Text = _DetainedLicense.LicenseID.ToString();
                lblUsername.Text = clsLoginUser.LoginUser;
                lblTotalFees.Text = (_AppFees + _FineFees).ToString();
            }

        }
        private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            _LocalLicenseID = obj;
            _IsFound = ctrlDriverLicenseCardWithFilter1.IsFound;
            _IsDetained = ctrlDriverLicenseCardWithFilter1.IsDetained;

            if (!_IsFound)
                return;

            llShowLicenseHistory.Enabled = true;

            int driverID = clsLicense.Find(_LocalLicenseID).DriverID;
            _PersonID = clsDriver.Find(driverID).PersonID;
            int userID = clsUser.Find(clsLoginUser.LoginUser).UserID;
            

            if (_IsFound && _IsDetained)
            {
                btnRelease.Enabled = true;
            }
            else
            {
                btnRelease.Enabled = false;
            }

            if (!_IsDetained)
            {
                MessageBox.Show($"License with ID=[{_LocalLicenseID}] is not Detained", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DetainID = clsLicense.IsLicenseDetained(_LocalLicenseID);
            _DetainedLicense = clsDetainedLicense.Find(_DetainID);
            SetDefaults();

            _Application = new clsApplication();
            _ReleaseLicense = new clsReleaseLicense();


            btnRelease.Enabled = true; // make the release button enabled!


            // application data
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationType;
            _Application.UserID = userID;
            _Application.ApplicantApplicationID = _PersonID;
            _Application.PaidFees = _AppFees;
            _Application.LastStatusDate = DateTime.Now;
            _Application.ApplicationStatus = 1;

            // local license ID;
            _ReleaseLicense.ReleaseDate = DateTime.Now;
            _ReleaseLicense.UserID = userID;

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            int applicationID = -1;
            
            if (clsLicense.IsLicenseDetained(_LocalLicenseID) == -1)
            {
                MessageBox.Show($"Selected license is not detained!, select another one!", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            if (MessageBox.Show($"Are you sure you want to release license for licenseID={_LocalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (_Application.Save())
            {
                applicationID = _Application.ApplicationID;
            }

            if (applicationID != -1)
                _ReleaseLicense.ApplicationID = applicationID;
            else
            {
                MessageBox.Show("Failed to release local license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ReleaseLicense.Save())
            {
                lblRelAppID.Text = applicationID.ToString();

                MessageBox.Show($"License with ID={_LocalLicenseID} released successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsApplication.UpdateApplicationStatus(applicationID, 3);
                _DetainedLicense.ReleaseID = _ReleaseLicense.ReleaseID;
                _DetainedLicense.Save(); // add the release license ID into detaind licenses 
                llShowLicense.Enabled = true;
            }
            else
                MessageBox.Show($"Fail to release local license", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseCard license = new frmShowLicenseCard(_LocalLicenseID);
            license.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(_PersonID);
            licenseHistory.ShowDialog();
        }

        
        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
