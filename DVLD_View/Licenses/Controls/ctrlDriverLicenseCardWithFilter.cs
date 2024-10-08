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

        // define a custom event handler delegate with paramters
        public event Action<int> OnLicenseSelected;
        
        protected virtual void LicenseSelected(int licenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(licenseID);
            }
        }

        public bool IsFound ;
        public bool IsDetained;
        public bool IsClass3;
        public int LocalLicenseID;
        public bool IsActive;


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
            ctrlDriverLicenseCard1.LocalLicenseInfoBack += CtrlDriverLicenseCard1_LocalLicenseInfoBack;
            ctrlDriverLicenseCard1.LoadLicenseCardInfo(licenseId);

            if (OnLicenseSelected != null)
                OnLicenseSelected(ctrlDriverLicenseCard1.LocalLicenseID);

            
        }

        private void CtrlDriverLicenseCard1_LocalLicenseInfoBack(object sender, int localLicenseID, bool isFound, bool isActive, bool isClass3, bool isDetained)
        {
            IsFound = isFound;
            IsActive = isActive;
            IsClass3 = isClass3;
            LocalLicenseID = localLicenseID;
            IsDetained = isDetained;

        }

        private void txtSearchLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ctrlDriverLicenseCardWithFilter_Load(object sender, EventArgs e)
        {
            txtSearchLicenseID.Focus();
        }
    }
}
