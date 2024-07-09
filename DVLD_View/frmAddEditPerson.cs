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
    public partial class frmAddEditPerson : Form
    {
        public frmAddEditPerson()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Set image will be here!");

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Remove image will be here!");

        }


        //Validating will be here
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
