using DVLD_Business;
using DVLD_View.People.Controls.Events;
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
    public partial class ctrlPersonCardWithFilter : UserControl
    {

		//define the event 
		public event EventHandler<OnPersonSelectedEventArgs> OnPersonSelected;

		public void RaisOnPersonSelected(int personId)
		{
			RaisOnPersonSelected(new OnPersonSelectedEventArgs(personId));
		}

		protected virtual void RaisOnPersonSelected(OnPersonSelectedEventArgs e)
		{
			OnPersonSelected?.Invoke(this, e);
		}

		private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddNew.Visible = _ShowAddPerson;
            }
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

		private int _PersonID = -1;

		public int PersonID
		{
			get
			{
				return ctrlPersonCard1.PersonID;
			}
		}

		public clsPerson SelectedPersonInfo
		{
			get
			{
				return ctrlPersonCard1.SelectedPersonInfo;
			}
		}


		public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personId)
        {
            txtSearch.Text = personId.ToString();
            cbPersonFilters.SelectedIndex = 0;
            FindNow();
        }

        public void FindNow()
        {
            switch(cbPersonFilters.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtSearch.Text));
                    break;
                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtSearch.Text);
                    break;
                default:
                    break;
			}

            if (OnPersonSelected != null && FilterEnabled)
                RaisOnPersonSelected(ctrlPersonCard1.PersonID);
        }
        
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbPersonFilters.SelectedIndex = 1;
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson addEdit = new frmAddEditPerson();
            addEdit.evPersonIDBack += _evPersonIDBack; // subscripe to the event
            addEdit.ShowDialog();
        }

        private void _evPersonIDBack(int personID)
        {
            _PersonID = personID;
            LoadPersonInfo(_PersonID);
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
			if (!this.ValidateChildren())
			{
				//Here we dont continue becuase the form is not valid
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			FindNow();
		}

		private void cbPersonFilters_SelectedIndexChanged(object sender, EventArgs e)
		{
            txtSearch.Text = "";
            txtSearch.Focus();
		}

		private void txtSearch_Validating(object sender, CancelEventArgs e)
		{
            if(string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                e.Cancel = true;
                epFilterValidating.SetError(txtSearch, "Field is required!");
            }
            else
            {
                epFilterValidating.SetError(txtSearch, null);
            }
		}

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }

            if (cbPersonFilters.Text == "Person ID" )
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		}
	}
}
