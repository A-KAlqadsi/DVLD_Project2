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
using System.IO;

namespace DVLD_View
{
    public partial class ctrlUserPersonCard : UserControl
    {
        private clsUser _User;

        private int _UserID = -1;
        public int UserID
        {
            get
            {
                return _UserID;
            }
                
        }

        public ctrlUserPersonCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int userID)
        {
            _User = clsUser.Find(userID);
            if (_User == null)
            {
                _ResetUserInfo();
                MessageBox.Show("No user with userID = " + userID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillUserInfo();

        }

        private void _ResetUserInfo()
        {
            
            lblUserID.Text = "????";
            lblUsername.Text = "????";
            lblIsActive.Text = "????";

        }
        
        private void _FillUserInfo()
        {
            _UserID =_User.UserID;
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text= _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblIsActive.Text = (_User.IsActive == true) ? "Yes" : "No";
            
        }

    }
}
