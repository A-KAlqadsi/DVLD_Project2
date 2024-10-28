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
    public partial class frmTakeTest : Form
    {
        clsTestType.enTestType _TestTypeId;
        clsTest _Test;
        int _TestID;
        int _TestAppointmentID;

        public frmTakeTest(int testAppointmentID, clsTestType.enTestType testTypeID)
        {
            InitializeComponent();

			_TestTypeId = testTypeID;
            _TestAppointmentID = testAppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestTypeId = _TestTypeId;
            ctrlScheduledTest1.LoadInfo(_TestAppointmentID);

            if(ctrlScheduledTest1.TestAppointmentId == -1)
                btnSave.Enabled = false;
            else 
                btnSave.Enabled = true;

            _TestID = ctrlScheduledTest1.TestId;
            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;
                txtNotes.Text = _Test.Notes;

                lblUserMessage.Visible = true;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                txtNotes.Enabled = false;
                btnSave.Enabled = false;
            }
            else
                _Test = new clsTest();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
					 "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
			)
			{
				return;
			}

			_Test.TestAppointmentID = _TestAppointmentID;
            _Test.UserID = Globals.Global.CurrentUser.UserID;
            _Test.TestResult = rbPass.Checked;

            _Test.Notes = txtNotes.Text.Trim();
            
            if (_Test.Save())
            {
                MessageBox.Show("Test result added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlScheduledTest1.LoadInfo(_Test.TestAppointmentID);
                btnSave.Enabled = false;
			}
            else
				MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
