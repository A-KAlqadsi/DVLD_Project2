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
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID;
        
        public frmLicenseHistory(int personId)
        {
            InitializeComponent();
            _PersonID = personId;
        }

		public frmLicenseHistory()
		{
			InitializeComponent();
			
		}

		private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
           if(_PersonID != -1)
            {
				ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
				ctrlPersonCardWithFilter1.FilterEnabled = false;
				ctrlDriverLicenses1.LoadInfoByPersonId(_PersonID);
			}
           else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();

			}
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, People.Controls.Events.OnPersonSelectedEventArgs e)
		{
            _PersonID = e.PersonId;
            if (_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
                ctrlDriverLicenses1.LoadInfoByPersonId(_PersonID);
		}
	}
}
