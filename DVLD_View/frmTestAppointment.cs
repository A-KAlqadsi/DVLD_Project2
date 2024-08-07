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
        public frmTestAppointment(int testTypeID)
        {
            InitializeComponent();
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
            ctrlApplicationCard1.LoadApplicationInfo(30);
            _InitializeTestAppointmentTypes();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            frmScheduleTest scheduleTest = new frmScheduleTest(_TestTypeID);
            scheduleTest.ShowDialog();
        }
    }
}
