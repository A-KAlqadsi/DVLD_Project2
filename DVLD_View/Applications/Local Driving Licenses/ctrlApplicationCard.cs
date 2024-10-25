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

        
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;
		public int LocalDrivingLicenseAppID
		{
			get
			{
				return _LocalDrivingLicenseAppID;
			}
		}
		public int ApplicationId
        {
            get { return ctrlApplicationBasicInfo1.ApplicationID; }
        }
        
        public int LicenseClassID { get; private set; }
        

        public ctrlApplicationCard()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int localDrivingLicenseAppID)
        {
             
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(localDrivingLicenseAppID);
            if(_LocalDrivingLicenseApp != null )
            {
                ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApp.ApplicationID);
                _FillLocalDrivingLicenseApplicationInfo();
			}
            else
            {
                _ResetApplicationCardInfo();
                MessageBox.Show("No Local Driving License Application with ID = " + localDrivingLicenseAppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }

		public void LoadApplicationInfoByApplicationId(int applicationId)
		{

			_LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.FindByApplicationId(applicationId);
			if (_LocalDrivingLicenseApp != null)
			{
				ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApp.ApplicationID);
				_FillLocalDrivingLicenseApplicationInfo();
			}
			else
			{
				_ResetApplicationCardInfo();
				MessageBox.Show("No Local Driving License Application with ID = " + applicationId.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _ResetApplicationCardInfo()
        {
            _LocalDrivingLicenseAppID = -1;
            lblDLAppID.Text = "[????]";            
            lblClassName.Text = "[????]";
            lblPassedTests.Text = "[????]";
        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            llShowLicenseInfo.Enabled = _LocalDrivingLicenseApp.GetActiveLicenseId() != -1;

            _LocalDrivingLicenseAppID = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID;
			lblDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            LicenseClassID = _LocalDrivingLicenseApp.LicenseClassID;
            lblClassName.Text = clsLicenseClass.Find(_LocalDrivingLicenseApp.LicenseClassID).ClassName;
            lblPassedTests.Text = $"{clsTest.CountPassedTest(_LocalDrivingLicenseAppID)}/3";

        }

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            frmShowLicenseCard license = new frmShowLicenseCard(_LocalDrivingLicenseApp.GetActiveLicenseId());
            license.ShowDialog();
        }
	}
}
