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
    public partial class frmManageLocalDrivingLicenseApp : Form
    {
        private int _LocalDrivingLicenseID;
        private DataTable _dtLocalDrivingLicenses;

        public frmManageLocalDrivingLicenseApp()
        {
            InitializeComponent();
        }
        
        
        private void frmManageLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            
            _dtLocalDrivingLicenses = clsLocalDrivingLicenseApp.GetAll();

            dgvListLocalDrivingLicenseApps.DataSource = _dtLocalDrivingLicenses;

            lblRecordsCount.Text = dgvListLocalDrivingLicenseApps.Rows.Count.ToString();

            if(dgvListLocalDrivingLicenseApps.Rows.Count>0)
            {
                dgvListLocalDrivingLicenseApps.Columns[0].HeaderText = "L.D.L AppID";
                dgvListLocalDrivingLicenseApps.Columns[0].Width = 125;

				dgvListLocalDrivingLicenseApps.Columns[1].HeaderText = "Driving Class";
				dgvListLocalDrivingLicenseApps.Columns[1].Width = 280;

				dgvListLocalDrivingLicenseApps.Columns[2].HeaderText = "National No";
				dgvListLocalDrivingLicenseApps.Columns[2].Width = 125;

				dgvListLocalDrivingLicenseApps.Columns[3].HeaderText = "Full Name";
				dgvListLocalDrivingLicenseApps.Columns[3].Width = 300;

				dgvListLocalDrivingLicenseApps.Columns[4].HeaderText = "Application Date";
				dgvListLocalDrivingLicenseApps.Columns[4].Width = 155;

				dgvListLocalDrivingLicenseApps.Columns[5].HeaderText = "Passed Tests";
				dgvListLocalDrivingLicenseApps.Columns[5].Width = 125;

				dgvListLocalDrivingLicenseApps.Columns[6].HeaderText = "Status";
				dgvListLocalDrivingLicenseApps.Columns[6].Width = 125;
			}
			cbFilterLocalDrivingLicenseApps.SelectedIndex = 0;

		}

		private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApp addEdit = new frmAddEditLocalDrivingLicenseApp();
            addEdit.ShowDialog();
            frmManageLocalDrivingLicenseApp_Load(null, null);

		}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Filter part
        private void cbFilterLocalDrivingLicenseApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilterLocalDrivingLicenseApps.Text != "None");

            if(txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
            _dtLocalDrivingLicenses.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListLocalDrivingLicenseApps.Rows.Count.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
			
			string filterColumn = "";
            switch(cbFilterLocalDrivingLicenseApps.Text)
            {
                case "L.D.L AppID":
                    filterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "Driving Class":
                    filterColumn = "ClassName";
                    break;
				case "National No":
					filterColumn = "NationalNo";
					break;
                case "Full Name":
					filterColumn = "FullName";
					break;
                case "Passed Tests":
					filterColumn = "PassedTests";
					break;
                case "Status":
					filterColumn = "Status";
					break;
                default:
                    filterColumn = "None";
                    break;
			}

            if(filterColumn == "None" || txtFilter.Text.Trim()== "")
            {
				_dtLocalDrivingLicenses.DefaultView.RowFilter = "";
				lblRecordsCount.Text = dgvListLocalDrivingLicenseApps.Rows.Count.ToString();
                return;
			}
            if(filterColumn== "LocalDrivingLicenseApplicationID" || filterColumn =="PassedTests")
            {
                _dtLocalDrivingLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
                
			}
            else
				_dtLocalDrivingLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilter.Text.Trim());

			lblRecordsCount.Text = dgvListLocalDrivingLicenseApps.Rows.Count.ToString();
		}

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterLocalDrivingLicenseApps.Text == "L.D.L AppID" ||
                    cbFilterLocalDrivingLicenseApps.Text == "PassedTests")

                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

        private void tsmiScheduleVisionTest_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int) dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmTestAppointment testAppointment = new frmTestAppointment(lDLAppID,clsTestType.enTestType.VisionTest);
            testAppointment.ShowDialog();
			frmManageLocalDrivingLicenseApp_Load(null, null);
		}

		private void tsmiScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmTestAppointment testAppointment = new frmTestAppointment(lDLAppID, clsTestType.enTestType.WrittenTest);
            testAppointment.ShowDialog();

			frmManageLocalDrivingLicenseApp_Load(null, null);
		}
		private void tsmiScheduleStreetTest_Click(object sender, EventArgs e)
        {
            
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmTestAppointment testAppointment = new frmTestAppointment(lDLAppID, clsTestType.enTestType.StreetTest);
            testAppointment.ShowDialog();

            if (clsTest.CountPassedTest(lDLAppID) == 3)
                clsApplication.UpdateApplicationStatus(clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID, 3);

			frmManageLocalDrivingLicenseApp_Load(null, null);
		}

		private void _ValidateTestOrders()
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;           
            
            if(clsTest.CountPassedTest(lDLAppID) == 3)
            {
                tsmiScheduleTests.Enabled = false;
                if (clsLicense.IsApplicationHasLicense(clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID))
                    tsmiIssueDrivingLicense.Enabled = false;
                else
                    tsmiIssueDrivingLicense.Enabled = true;
            }
            else 
                tsmiScheduleTests.Enabled =true;

            
            
            if (clsTest.IsTestPassed(lDLAppID, 1))
            {
                tsmiScheduleVisionTest.Enabled = false;
            }
            else
                tsmiScheduleVisionTest.Enabled = true;



            if (clsTest.IsTestPassed(lDLAppID,1) && !clsTest.IsTestPassed(lDLAppID, 2))
            {
                tsmiScheduleWrittenTest.Enabled = true;
            }
            else
                tsmiScheduleWrittenTest.Enabled = false;


            if (clsTest.IsTestPassed(lDLAppID, 1) && clsTest.IsTestPassed(lDLAppID, 2) && !clsTest.IsTestPassed(lDLAppID, 3))
            {
                tsmiScheduleStreetTest.Enabled = true;
            }
            else
            {
                tsmiScheduleStreetTest.Enabled = false;
            }
        }

        private void dgvListLocalDrivingLicenseApps_SelectionChanged(object sender, EventArgs e)
        {
            _LocalDrivingLicenseID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            if (clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseID) == null)
                return;
            int applicatoinID = clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseID).ApplicationID;
            if (clsApplication.GetStatus(applicatoinID) == 2)
            {
                tsmiCancelApplication.Enabled = false;
                tsmiEditApplication.Enabled = false;
                tsmiScheduleTests.Enabled = false;
                tsmiShowLicense.Enabled = false;
                tsmiDeleteApplication.Enabled = true;
                return;
            }
            else
            {
                tsmiCancelApplication.Enabled = true;
                tsmiEditApplication.Enabled = true;
                tsmiScheduleTests.Enabled = true;
                tsmiShowLicense.Enabled = true;
                tsmiDeleteApplication.Enabled = true;
            }
            

            if (clsTest.CountPassedTest(_LocalDrivingLicenseID) == 3 && !clsLicense.IsApplicationHasLicense(applicatoinID))
                tsmiIssueDrivingLicense.Enabled = true;
            else
                tsmiIssueDrivingLicense.Enabled = false;

            if (clsLicense.IsApplicationHasLicense(applicatoinID))
            {
                tsmiShowLicense.Enabled = true;
                tsmiCancelApplication.Enabled = false;
                tsmiDeleteApplication.Enabled = false;
                tsmiEditApplication.Enabled = false;
            }
            else
            {
                tsmiShowLicense.Enabled = false;
                tsmiCancelApplication.Enabled = true;
                tsmiDeleteApplication.Enabled = true;
                tsmiEditApplication.Enabled = true;
            }

            _ValidateTestOrders();
        }

        private void tsmiIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmIssueDrivingLicense isseLicense = new frmIssueDrivingLicense(lDLAppID);
            isseLicense.ShowDialog();

            if (clsLicense.IsApplicationHasLicense(clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID))
            {
                tsmiIssueDrivingLicense.Enabled = false;
                tsmiShowLicense.Enabled = true;
            }
            else
                tsmiIssueDrivingLicense.Enabled = true;
        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            int applicationID = clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID;
            int licenseId; 
            clsLicense license =  clsLicense.FindByApplicationID(applicationID);
            if (license == null)
                licenseId = -1;
            else
                licenseId = license.LicenseID;

            frmShowLicenseCard licenseCard = new frmShowLicenseCard(licenseId);
            licenseCard.ShowDialog();

        }

        private void tsmiEditApplication_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmAddEditLocalDrivingLicenseApp frm = new frmAddEditLocalDrivingLicenseApp(lDLAppID);
            frm.ShowDialog();
			frmManageLocalDrivingLicenseApp_Load(null, null);
		}

		private void tsmiCancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            clsLocalDrivingLicenseApp application = 
                clsLocalDrivingLicenseApp.Find((int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value);
            
            if (application != null)
            {
                if (application.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageLocalDrivingLicenseApp_Load(null, null);

                }
                else
                    MessageBox.Show("Couldn't cancel this application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}   
		}

        private void tsmiDeleteApplication_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            int applicationID = clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID;

            if (clsTest.CountPassedTest(lDLAppID) == 0 && !clsTestAppointment.IsPersonHasTestAppointment(lDLAppID))
            {

                if (MessageBox.Show("Are you sure you want to delete this application", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsLocalDrivingLicenseApp.Delete(lDLAppID))
                    {
                        if (clsApplication.Delete(applicationID))
                        {
                            MessageBox.Show("Application deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
							frmManageLocalDrivingLicenseApp_Load(null, null);
						}
					}

                }
            }
            else
                MessageBox.Show("You cannot delete this application because it has connections in other resources!!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void tsmiShowAppDetails_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;

            frmShowApplicationInfo showAppInfo = new frmShowApplicationInfo(lDLAppID);
            showAppInfo.ShowDialog();
            // refresh
            frmManageLocalDrivingLicenseApp_Load(null, null);
        }

        private void tsmiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            int applicationID = clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID;
            int personId = clsApplication.FindBaseApplication(applicationID).ApplicantPersonID;
            //int driverID = clsDriver.FindByPersonID(applicationID).DriverID;
            frmLicenseHistory licenesHistory = new frmLicenseHistory(personId);
            licenesHistory.ShowDialog();

            //MessageBox.Show("Person license history will be here!");
        }

		private void cmsManageLocalDrivingLicenseApp_Opening(object sender, CancelEventArgs e)
		{
            int localDrivingLicenseId = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApp localLicenseApp = clsLocalDrivingLicenseApp.Find(localDrivingLicenseId);

            int totalPassedTests = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[5].Value;

            bool LicenseExists = localLicenseApp.IsLicenseIssued();


            // enable only if the tests passed 3 and license not Exists
            tsmiIssueDrivingLicense.Enabled = (totalPassedTests == 3) && !LicenseExists;

			tsmiShowLicense.Enabled = LicenseExists;
			tsmiEditApplication.Enabled = !LicenseExists && localLicenseApp.ApplicationStatus == clsApplication.enApplicationStatus.New;
            tsmiCancelApplication.Enabled = ( localLicenseApp.ApplicationStatus == clsApplication.enApplicationStatus.New);
            tsmiScheduleTests.Enabled = !LicenseExists;

            tsmiDeleteApplication.Enabled = (localLicenseApp.ApplicationStatus == clsApplication.enApplicationStatus.New);

			bool passedVisionTest = localLicenseApp.DoesPassTestType(clsTestType.enTestType.VisionTest);
			bool passedWrittenTest = localLicenseApp.DoesPassTestType(clsTestType.enTestType.WrittenTest);
			bool passedStreetTest = localLicenseApp.DoesPassTestType(clsTestType.enTestType.StreetTest);

            tsmiScheduleTests.Enabled = (!passedVisionTest || !passedWrittenTest || !passedStreetTest)
                && (localLicenseApp.ApplicationStatus == clsApplication.enApplicationStatus.New);
            if(tsmiScheduleTests.Enabled)
            {
                tsmiScheduleVisionTest.Enabled = !passedVisionTest;
                tsmiScheduleWrittenTest.Enabled = passedVisionTest && !passedWrittenTest;
                tsmiScheduleStreetTest.Enabled = passedVisionTest && passedWrittenTest && !passedStreetTest;
            }

		}
	}
}
