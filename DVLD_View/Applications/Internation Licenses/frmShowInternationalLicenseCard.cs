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
    public partial class frmShowInternationalLicenseCard : Form
    {
        int _InternationalLicenseID = -1;
        public frmShowInternationalLicenseCard(int internationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = internationalLicenseID;
        }

        private void frmShowInternationalLicenseCard_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseCard1.LoadInfo(_InternationalLicenseID);
        }
    }
}
