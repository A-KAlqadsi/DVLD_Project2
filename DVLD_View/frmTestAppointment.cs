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
    public partial class frmTestAppointment : Form
    {
        enum enTestType { Vision = 1, Written = 2, Street = 3 }
        enTestType _TestType;
        int _TestTypeID;
        int _LDLAppId;
        public frmTestAppointment(int lDLAppId, int testTypeID)
        {
            InitializeComponent();
            _LDLAppId = lDLAppId;
            _TestTypeID = testTypeID;
            if (_TestTypeID == 1)
                _TestType = enTestType.Vision;
            else if (_TestTypeID == 2)
                _TestType = enTestType.Written;
            else
                _TestType = enTestType.Street;
        }

        private void _InitializeTestAppointmentTypes()
        {
            if (_TestType == enTestType.Vision)
            {
                lblMode.Text = "Vision Test Appointment";
                this.Text = "Vision Test Appointment";

            }
            else if (_TestType == enTestType.Written)
            {
                lblMode.Text = "Written Test Appointment";
                this.Text = "Written Test Appointment";
            }
            else
            {
                lblMode.Text = "Street Test Appointment";
                this.Text =  "Street Test Appointment";
            }
        }

        private void frmVisionTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlApplicationCard1.LoadApplicationInfo(_LDLAppId);
            _InitializeTestAppointmentTypes();
            _RefreshTestAppointments();
        }

        private void _RefreshTestAppointments()
        {
            dgvListAllTestAppointments.Rows.Clear();
            DataView dv = clsTestAppointment.GetAll().DefaultView;
            
            dv.RowFilter = $"LocalDrivingLicenseApplicationID = {_LDLAppId} And TestTypeID={_TestTypeID}";
            dgvListAllTestAppointments.Visible = dv.Count > 0;

            for (int i = 0; i < dv.Count; i++)
            {
                dgvListAllTestAppointments.Rows.Add(dv[i]["TestAppointmentID"], dv[i]["AppointmentDate"], dv[i]["PaidFees"], dv[i]["IsLocked"]);
            }

            
            lblRecordsCount.Text = dv.Count.ToString();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if(clsTest.IsTestPassed(_LDLAppId,_TestTypeID))
            {
                MessageBox.Show($"This person already passed this test before, you can only {Environment.NewLine} add apointment for new or failed tests", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsTestAppointment.IsPersonHasActiveTestAppointment(_LDLAppId)) 
            {
                MessageBox.Show($"Person Already has an active appointment for this test, you{Environment.NewLine}cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            frmScheduleTest scheduleTest = new frmScheduleTest(_LDLAppId, _TestTypeID,-1);
            scheduleTest.ShowDialog();
            _RefreshTestAppointments();
            
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

            _RefreshTestAppointments();
        }

        private void tsmiTakeTest_Click(object sender, EventArgs e)
        {
            int iD = (int)dgvListAllTestAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest takeTest = new frmTakeTest(iD, _TestTypeID);
            takeTest.ShowDialog();
            _RefreshTestAppointments();
        }
    }
}
