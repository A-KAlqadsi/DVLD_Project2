using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_View
{
    public partial class frmLoginScreen : Form
    {
        private bool _isEmpty = false;
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsEmpty()
        {
            epLoginValidate.Clear();
            if (txtUsername.Text.Trim() == "")
            {
                _isEmpty = true;
                epLoginValidate.SetError(txtUsername, "Username is required!");
            }
            if (txtPassword.Text.Trim() == "")
            {
                _isEmpty = true;
                epLoginValidate.SetError(txtPassword, "Password is required!");
            }
            return _isEmpty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_IsEmpty())
            {
                _isEmpty = false;
                MessageBox.Show("Username/Password is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUser.IsUsernameAndPasswordTrue(txtUsername.Text, txtPassword.Text))
            {                
                if (clsUser.IsUserActive(txtUsername.Text))
                {
                    frmMain main = new frmMain(txtUsername.Text);
                    main.ShowDialog();
                }
                else
                {
                    //epLoginValidate.SetError(txtUsername, "Username is not active,contact your admin!");
                    MessageBox.Show("Username is not active contact your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // epLoginValidate.SetError(txtUsername, "Username/Password is not true!,try again!");
                MessageBox.Show("Username/Password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    
    
    }
}
