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
        private int _DriverID;

        public frmLicenseHistory(int personId)
        {
            InitializeComponent();
            _PersonID = personId;
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            _DriverID = clsDriver.FindByPersonID(_PersonID).DriverID;
            ctrlDriverLicenses1.LoadLocalLicenseHistory(_DriverID);
            ctrlDriverLicenses1.LoadInternatioalLicenseHistory(_DriverID);
            ctrlPersonCardWithFilter1.cbPersonFilters.SelectedIndex = 0;
            ctrlPersonCardWithFilter1.txtSearch.Text = _PersonID.ToString();
            ctrlPersonCardWithFilter1.gbFilter.Enabled = false;
            ctrlPersonCardWithFilter1.ctrlPersonCard1.LoadPersonInfo(_PersonID);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
