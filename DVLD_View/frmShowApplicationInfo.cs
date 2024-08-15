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
    public partial class frmShowApplicationInfo : Form
    {
        private int _LocalDrivingLicenseAppID;
        public frmShowApplicationInfo(int localDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = localDrivingLicenseAppID;
        }

        private void frmShowApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlApplicationCard1.LoadApplicationInfo(_LocalDrivingLicenseAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
