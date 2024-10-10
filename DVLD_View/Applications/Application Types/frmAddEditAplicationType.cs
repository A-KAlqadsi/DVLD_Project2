using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVLD_Business;

namespace DVLD_View
{
    public partial class frmAddEditAplicationType : Form
    {
        
        private int _AppTypeID;
        private clsApplicationType _AppType;
        public frmAddEditAplicationType(int appTypeID)
        {
            InitializeComponent();
            _AppTypeID  = appTypeID;
        }


        private void frmAddEditAplicationType_Load(object sender, EventArgs e)
        {
			_AppType = clsApplicationType.Find(_AppTypeID);

			if (_AppType == null)
			{
				MessageBox.Show($"This screen will be closed because no application Type with Id=[{_AppTypeID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			lblAppTypeID.Text = _AppType.ApplicationTypeID.ToString();
			txtTitle.Text = _AppType.ApplicationTitle;
			txtFees.Text = _AppType.ApplicationFees.ToString();
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
			_AppType.ApplicationTitle = txtTitle.Text;
            _AppType.ApplicationFees = Convert.ToSingle(txtFees.Text);

            if (_AppType.Save())
                MessageBox.Show("Application type saved successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Application type save fail", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

		private void txtTitle_Validating(object sender, CancelEventArgs e)
		{
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                epValidateInput.SetError(txtTitle, "Title is required!");
            }
            else
                epValidateInput.SetError(txtTitle, null);
		}

		private void txtFees_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtFees.Text.Trim()))
			{
				e.Cancel = true;
				epValidateInput.SetError(txtFees, "Fees is required!");
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
