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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshApplicationTypes()
        {
            DataTable dt = clsApplicationType.GetAll();
            int counter = dt.Rows.Count;
            foreach (DataRow dr in dt.Rows)
            {
                dgvListApplicationTypes.Rows.Add(dr["ApplicationTypeID"], dr["ApplicationTypeTitle"], dr["ApplicationFees"]);
            }
            lblRecordsCount.Text = counter.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
