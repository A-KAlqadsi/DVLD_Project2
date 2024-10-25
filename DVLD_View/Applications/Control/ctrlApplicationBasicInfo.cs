using DVLD_Business;
using DVLD_View.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_View.Applications.Control
{
	public partial class ctrlApplicationBasicInfo : UserControl
	{
		private clsApplication _Application;
		private int _ApplicationID = -1;	
		public int ApplicationID
		{
			get { return _ApplicationID; }
		}

		public ctrlApplicationBasicInfo()
		{
			InitializeComponent();
		}

		public void LoadApplicationInfo(int applicationId)
		{
			_Application = clsApplication.FindBaseApplication(applicationId);
			if (_Application == null)
			{
				_ResetApplicationInfo();
				MessageBox.Show("No Application with ID = " + _Application.ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else
				_FillApplicationInfo();
		}

		private void _FillApplicationInfo()
		{
			llViewPersonInfo.Enabled = true;
			_ApplicationID = _Application.ApplicationID;
			lblAppID.Text = _Application.ApplicationID.ToString();
			lblAppDate.Text = Format.DateToShort(_Application.ApplicationDate);
			lblAppFees.Text = _Application.PaidFees.ToString();
			lblApplicant.Text = _Application.PersonInfo.FullName;
			lblAppStatus.Text = (_Application.ApplicationStatus == clsApplication.enApplicationStatus.New)
								? "New" : (_Application.ApplicationStatus == clsApplication.enApplicationStatus.Cancelled)
								? "Cancelled" : "Completed";
			lblAppType.Text = clsApplicationType.Find((int)_Application.ApplicationTypeID).ApplicationTitle;
			lblLastStatusDate.Text = Format.DateToShort(_Application.LastStatusDate);
			lblUsername.Text = Global.CurrentUser.Username;

		}
		private void _ResetApplicationInfo()
		{
			_ApplicationID = -1;
			llViewPersonInfo.Enabled = false;
			lblAppDate.Text = "[????]";
			lblAppFees.Text = "[????]";
			lblAppID.Text = "[????]";
			lblApplicant.Text = "[????]";
			lblAppStatus.Text = "[????]";
			lblAppType.Text = "[????]";
			lblLastStatusDate.Text = "[????]";
			lblUsername.Text = "[????]";
		}

		private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

			frmPersonDetails personInfo = new frmPersonDetails(_Application.ApplicantPersonID);
			personInfo.ShowDialog();

			LoadApplicationInfo(_ApplicationID);
		}
	}
}
