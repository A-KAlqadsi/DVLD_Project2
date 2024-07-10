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
    public partial class frmAddEditUser : Form
    {
        public frmAddEditUser()
        {
            InitializeComponent();
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a person will be here ");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next button will be here ");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save user will be here ");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
