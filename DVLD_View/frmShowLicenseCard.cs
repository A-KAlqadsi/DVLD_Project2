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
    public partial class frmShowLicenseCard : Form
    {
        private int _LicenseID;
        public frmShowLicenseCard(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void frmShowLicenseCard_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseCard1.LoadLicenseCardInfo(_LicenseID);
        }
    }
}
