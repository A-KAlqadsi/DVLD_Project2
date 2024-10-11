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
    public partial class frmAddEditTestType : Form
    {
      
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;
        

        public frmAddEditTestType(clsTestType.enTestType testTypeID)
        {
            InitializeComponent();
            _TestTypeID = testTypeID;          
        }


        private void frmAddEditTestType_Load(object sender, EventArgs e)
        {
			_TestType = clsTestType.Find(_TestTypeID);

			if (_TestType == null)
			{
				MessageBox.Show($"This screen will be closed because no test Type with Id=[{_TestTypeID}]", "TestType Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			lblMode.Text = "Update Test Type";
			this.Text = "Update Test Type";

			lblTestTypeID.Text = ((int)_TestTypeID).ToString();
			txtTitle.Text = _TestType.TestTypeTitle;
			txtDescription.Text = _TestType.TestTypeDescription;
			txtFees.Text = _TestType.TestTypeFees.ToString();

		}

		private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (!this.ValidateChildren())
			{
				//Here we dont continue becuase the form is not valid
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription=txtDescription.Text;
            _TestType.TestTypeFees = Convert.ToSingle(txtFees.Text.Trim());

            if (_TestType.Save())
                MessageBox.Show("Test type saved successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Test type save fail", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
			if (string.IsNullOrEmpty(temp.Text.Trim()))
			{
				e.Cancel = true;
				epValidateInput.SetError(temp, "This field is required!");
			}
			else
				epValidateInput.SetError(temp, null);
		}

		private void txtFees_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtFees.Text.Trim()))
			{
				e.Cancel = true;
				epValidateInput.SetError(txtFees, "Fees field is required!");
                return;
            }
			else
				epValidateInput.SetError(txtFees, null);

            if (!Globals.Validation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                epValidateInput.SetError(txtFees, "Invalid Number!");
            }
            else
                epValidateInput.SetError(txtFees, null);

		}
	}
}
