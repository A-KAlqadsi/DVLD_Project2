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
    public partial class frmIssueDrivingLicense : Form
    {
        private int _LocalDrivingLicenseAppID;
        private clsLicense _License;
        private int _LicenseID;
        private clsDriver _Driver;
        private int _LicenseClassID;
        private int _ApplicationID;
        private clsLicenseClass _LicenseClass;

        public frmIssueDrivingLicense(int localDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = localDrivingLicenseAppID;
        }

        private void _LoadData()
        {
            ctrlApplicationCard1.LoadApplicationInfo(_LocalDrivingLicenseAppID);

            _License = new clsLicense();
            _Driver = new clsDriver();
            _LicenseClassID = ctrlApplicationCard1.LicenseClassID;
            _LicenseClass = clsLicenseClass.Find(_LicenseClassID);
            _ApplicationID = Convert.ToInt32(ctrlApplicationCard1.lblAppID.Text.ToString().Trim());

            if(_LicenseClass != null)
            {
                lblLicenseFees.Text = _LicenseClass.ClassFees.ToString();
            }

            
            
        }
        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int userId = clsUser.Find(clsLoginUser.LoginUser).UserID;
            int personId = clsApplication.FindBaseApplication(_ApplicationID).ApplicantPersonID;
            _License.ApplicationId = _ApplicationID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.ValidityLength);
            _License.IssueReason = 1;
            _License.PaidFees = _LicenseClass.ClassFees;
            _License.UserID = userId;
            _License.LicenseClassID = _LicenseClass.ClassID;
            _License.IsActive = true;
            _License.Notes = txtNotes.Text;

            _Driver.PersonID = personId;
            _Driver.UserID = userId;
            _Driver.CreateDate = DateTime.Now;
            if (!clsDriver.IsPersonADriver(personId))
            {
                if (_Driver.Save())
                    _License.DriverID = _Driver.DriverID;
                else
                    MessageBox.Show("Adding new local driving license failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _License.DriverID = clsDriver.FindByPersonID(personId).DriverID;
            }
            if (_License.Save())
                MessageBox.Show($"New local driving license added successfully with LicenesId=[{_License.LicenseID}]", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Adding new local driving license failed!2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }
    }
}
