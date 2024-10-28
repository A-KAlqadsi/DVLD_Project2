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
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseId = -1;
        private int _TestAppointmentId = -1;
        private clsTestType.enTestType _TestTypeId = clsTestType.enTestType.VisionTest;

        public frmScheduleTest(int localDrivingLicenseId, clsTestType.enTestType testTypeID, int testAppointmentID =-1)
        {
            InitializeComponent();
            _LocalDrivingLicenseId = localDrivingLicenseId;
            _TestAppointmentId = testAppointmentID;
            _TestTypeId = testTypeID;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeId = _TestTypeId;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseId, _TestAppointmentId);          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
