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
        DataTable _dtApplicationTypes;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtApplicationTypes = clsApplicationType.GetAll();
            dgvListApplicationTypes.DataSource = _dtApplicationTypes;
            lblRecordsCount.Text = dgvListApplicationTypes.Rows.Count.ToString();   
            if(dgvListApplicationTypes.Rows.Count>0)
            {
				dgvListApplicationTypes.Columns[0].HeaderText = "ID";
				dgvListApplicationTypes.Columns[0].Width = 100;

				dgvListApplicationTypes.Columns[1].HeaderText = "Title";
				dgvListApplicationTypes.Columns[1].Width = 400;

				dgvListApplicationTypes.Columns[2].HeaderText = "Fees";
				dgvListApplicationTypes.Columns[2].Width = 100;
			}
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditApplicationTypeInfo_Click(object sender, EventArgs e)
        {

            frmAddEditAplicationType addEdit = new frmAddEditAplicationType((int)dgvListApplicationTypes.CurrentRow.Cells[0].Value);
            addEdit.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }
    }
}
