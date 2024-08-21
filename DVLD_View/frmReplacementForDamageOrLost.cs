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
    public partial class frmReplacementForDamageOrLost : Form
    {
        public frmReplacementForDamageOrLost()
        {
            InitializeComponent();
        }

        private void rbDamageLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblMode.Text = "Replacement For Damage License";
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblMode.Text = "Replacement For Lost License";

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Issued button clicked!");
        }

        private void frmReplacementForDamageOrLost_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseCardWithFilter1.txtSearchLicenseID.Focus();

        }
    }
}
