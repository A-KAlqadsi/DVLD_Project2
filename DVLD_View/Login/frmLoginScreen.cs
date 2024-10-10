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
using DVLD_View.Globals;

namespace DVLD_View
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindByUserNameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {                
                if(chkRememberMe.Checked)
                    Global.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                else
					Global.RememberUsernameAndPassword("", "");

                if(!user.IsActive)
                {
					txtUsername.Focus();
					MessageBox.Show("Your account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

                Global.CurrentUser = user;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
			else
            {
                MessageBox.Show("Username/Password is wrong!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

		private void frmLoginScreen_Load(object sender, EventArgs e)
		{
            string userName = "", password = "";
            if (Global.GetStoredCredential(ref userName, ref password))
            {
                txtUsername.Text = userName;
                txtPassword.Text = password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
		}
	}
}
