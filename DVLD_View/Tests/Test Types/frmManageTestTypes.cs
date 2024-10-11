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
    public partial class frmManageTestTypes : Form
    {
        DataTable _dtTestTypes;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _dtTestTypes = clsTestType.GetAll();
            dgvListTestTypes.DataSource = _dtTestTypes;
            lblRecordsCount.Text = dgvListTestTypes.Rows.Count.ToString();

            if(dgvListTestTypes.Rows.Count > 0)
            {
                dgvListTestTypes.Columns[0].HeaderText = "Id";
                dgvListTestTypes.Columns[0].Width = 90;

				dgvListTestTypes.Columns[1].HeaderText = "Title";
				dgvListTestTypes.Columns[1].Width = 200;

				dgvListTestTypes.Columns[2].HeaderText = "Description";
				dgvListTestTypes.Columns[2].Width = 400;

				dgvListTestTypes.Columns[3].HeaderText = "Fees";
				dgvListTestTypes.Columns[3].Width = 90;

			}

            
        }

        private void tsmiEditApplicationTypeInfo_Click(object sender, EventArgs e)
        {
            frmAddEditTestType testType = new frmAddEditTestType((int)dgvListTestTypes.CurrentRow.Cells[0].Value);
            testType.ShowDialog();
            frmManageTestTypes_Load(null, null);
        }
    }
}
