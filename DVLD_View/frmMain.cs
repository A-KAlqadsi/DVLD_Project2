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
    public partial class frmMain : Form
    {
        private string _Username;
        public frmMain(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void _CenterPictureBox()
        {
            pbDVLDLogo.Left = (this.ClientSize.Width - pbDVLDLogo.Width) / 2;
            pbDVLDLogo.Top = (this.ClientSize.Height - pbDVLDLogo.Height) / 2;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLoginUser.Text = $"Login Username is:[{_Username}]";
            _CenterPictureBox();
        }

        private void tsmiPeople_Click(object sender, EventArgs e)
        {
            frmListPeople managePeople = new frmListPeople();
            managePeople.ShowDialog();
        }
    }
}
