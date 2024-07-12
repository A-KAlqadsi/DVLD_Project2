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
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshTestTypes()
        {
            dgvListTestTypes.Rows.Clear();
            int counter = 0;
            DataTable dt = clsTestType.GetAll();

            if(dt!= null)
                counter = dt.Rows.Count;
            foreach (DataRow row in dt.Rows)
            {
                dgvListTestTypes.Rows.Add(row["TestTypeID"], row["TestTypeTitle"], row["TestTypeDescription"], row["TestTypeFees"]);
            }

            lblRecordsCount.Text = counter.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }

        private void tsmiEditApplicationTypeInfo_Click(object sender, EventArgs e)
        {
            int iD = (int)dgvListTestTypes.CurrentRow.Cells[0].Value;
            frmAddEditTestType testType = new frmAddEditTestType(iD);
            testType.ShowDialog();
            _RefreshTestTypes();
        }
    }
}
