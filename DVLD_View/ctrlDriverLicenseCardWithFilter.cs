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
        public bool IsFound ;
        public bool IsDetained;
        public ctrlDriverLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            epFindLicenseValidate.Clear();
            if (txtSearchLicenseID.Text.Trim() == "")
            {
                epFindLicenseValidate.SetError(txtSearchLicenseID, "Please enter license ID");
                return;
            }
            int licenseId = Convert.ToInt32(txtSearchLicenseID.Text);
            ctrlDriverLicenseCard1.LoadLicenseCardInfo(licenseId);
            IsFound = ctrlDriverLicenseCard1.IsFound;
            IsDetained =ctrlDriverLicenseCard1.IsDetained;
        }

        private void txtSearchLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        

    }
}
