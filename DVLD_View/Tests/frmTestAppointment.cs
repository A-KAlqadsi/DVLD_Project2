using DVLD_Business;
using DVLD_View.Properties;
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
    public partial class frmTestAppointment : Form
    {
        clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
                
        int _LDLAppId;
        DataTable _dtTestAppointments;

        public frmTestAppointment(int lDLAppId, clsTestType.enTestType testTypeID)
        {
            InitializeComponent();
            _LDLAppId = lDLAppId;
            _TestTypeID = testTypeID;
            
        }

        private void _LoadTestAppointmentTitle()
        {
           switch(_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
					lblMode.Text = "Vision Test Appointment";
					this.Text = "Vision Test Appointment";
                    pbTestAppointment.Image = Resources.Vision_512;
                    break;
                case clsTestType.enTestType.WrittenTest:
                    {
						lblMode.Text = "Written Test Appointment";
						this.Text = "Written Test Appointment";
                        pbTestAppointment.Image = Resources.Written_Test_512;
					}
                    break;
                case clsTestType.enTestType.StreetTest:
                    {
						lblMode.Text = "Street Test Appointment";
						this.Text = "Street Test Appointment";
						pbTestAppointment.Image = Resources.driving_test_512;
					}
                    break;
			}
           
        }

        private void frmVisionTestAppointment_Load(object sender, EventArgs e)
        {
			_LoadTestAppointmentTitle();
			ctrlApplicationCard1.LoadApplicationInfo(_LDLAppId);

			_dtTestAppointments = clsTestAppointment.GetAllTestAppointmentPerTestType(_LDLAppId, _TestTypeID);

            dgvListAllTestAppointments.DataSource = _dtTestAppointments;

            lblRecordsCount.Text = dgvListAllTestAppointments.Rows.Count.ToString();
            if(dgvListAllTestAppointments.Rows.Count >0)
            {
                dgvListAllTestAppointments.Columns[0].HeaderText = "Appointment Id";
                dgvListAllTestAppointments.Columns[0].Width = 160;

				dgvListAllTestAppointments.Columns[1].HeaderText = "Appointment Date";
				dgvListAllTestAppointments.Columns[1].Width = 180;

				dgvListAllTestAppointments.Columns[2].HeaderText = "Paid Fees";
				dgvListAllTestAppointments.Columns[2].Width = 125;

				dgvListAllTestAppointments.Columns[3].HeaderText = "Is Locked";
				dgvListAllTestAppointments.Columns[3].Width = 100;
				
			}



		}


        private void btnAddAppointment_Click(object sender, EventArgs e)
        {


            clsLocalDrivingLicenseApp localDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LDLAppId);
            if(localDrivingLicenseApp.IsThereAnActiveScheduleTest(_TestTypeID))
            {
				MessageBox.Show($"Person Already has an active appointment for this test, you{Environment.NewLine}cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            // here still have code logic will be added soon

            if(clsTest.IsTestPassed(_LDLAppId,(int)_TestTypeID))
            {
                MessageBox.Show($"This person already passed this test before, you can only {Environment.NewLine} add apointment for new or failed tests", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest scheduleTest = new frmScheduleTest(_LDLAppId,(clsTestType.enTestType)_TestTypeID,-1);
            scheduleTest.ShowDialog();
            frmVisionTestAppointment_Load(null, null);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditTestAppointment_Click(object sender, EventArgs e)
        {
            int iD = (int)dgvListAllTestAppointments.CurrentRow.Cells[0].Value;
            frmScheduleTest scheduleTest = new frmScheduleTest(_LDLAppId, _TestTypeID, iD);
            scheduleTest.ShowDialog();

			frmVisionTestAppointment_Load(null, null);
		}

		private void tsmiTakeTest_Click(object sender, EventArgs e)
        {
            int iD = (int)dgvListAllTestAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest takeTest = new frmTakeTest(iD, _TestTypeID);
            takeTest.ShowDialog();
			frmVisionTestAppointment_Load(null, null);
		}
	}
}
