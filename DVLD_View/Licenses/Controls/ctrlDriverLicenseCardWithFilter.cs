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
    public partial class ctrlDriverLicenseCardWithFilter : UserControl
    {

        public class OnLicenseSelectedEventArgs:EventArgs
        {
            public int LicenseID { get; set; }
			public OnLicenseSelectedEventArgs(int licenseId)
			{
                LicenseID = licenseId;
			}
		}

		public event EventHandler<OnLicenseSelectedEventArgs> OnLicenseSelected;

		public void RaiseOnLicenseSelected(int licenseId)
		{
			RaiseOnLicenseSelected(new OnLicenseSelectedEventArgs(licenseId));
		}

		protected virtual void RaiseOnLicenseSelected(OnLicenseSelectedEventArgs e)
		{
			OnLicenseSelected?.Invoke(this, e);
		}

		

        public ctrlDriverLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private int _LicenseId;
        public int LicenseID
        {
            get { return ctrlDriverLicenseCard1.LicenseID; }
            
        }
        
        public clsLicense SelectedLicenseInfo
        {
            get { return ctrlDriverLicenseCard1.SelectedLicenseInfo; }
        }

        public void LoadLicenseInfo(int licenseId)
        {
            txtSearchLicenseID.Text = licenseId.ToString();
			ctrlDriverLicenseCard1.LoadInfo(licenseId);
			_LicenseId = ctrlDriverLicenseCard1.LicenseID;
			if (OnLicenseSelected != null && FilterEnabled)
				// Raise the event with a parameter
				RaiseOnLicenseSelected(_LicenseId);

		}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
				//Here we dont continue becuase the form is not valid
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtSearchLicenseID.Focus();
				return;
			}

            _LicenseId = int.Parse(txtSearchLicenseID.Text.Trim());
            LoadLicenseInfo(_LicenseId);
		}


        private void txtSearchLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

			// Check if the pressed key is Enter (character code 13)
			if (e.KeyChar == (char)13)
			{
				btnSearch.PerformClick();
			}
		}

        private void ctrlDriverLicenseCardWithFilter_Load(object sender, EventArgs e)
        {
            txtLicenseIDFocus();
        }

		public void txtLicenseIDFocus()
		{
			txtSearchLicenseID.Focus();
		}


		private void txtSearchLicenseID_Validating(object sender, CancelEventArgs e)
		{
            if(string.IsNullOrEmpty(txtSearchLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                epFindLicenseValidate.SetError(txtSearchLicenseID, "license Id is required!");
            }
            else
            {
                epFindLicenseValidate.SetError(txtSearchLicenseID, null);
            }
		}
	}
}
