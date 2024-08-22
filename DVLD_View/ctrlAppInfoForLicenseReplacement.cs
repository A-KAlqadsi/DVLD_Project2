using DVLD_Business;
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
    public partial class ctrlAppInfoForLicenseReplacement : UserControl
    {
        
        private int _AppTypeID = 3; // replace for lost application type,4 damage
        private int _OldLicenseID;
        public float AppFees;
        
        public int AppTypeID { get { return _AppTypeID; } private set { } }
        public ctrlAppInfoForLicenseReplacement()
        {
            InitializeComponent();
        }

        public void LoadInitialData(int OldLicenseID,int appTypeID)
        {

            _OldLicenseID = OldLicenseID;
            _AppTypeID = appTypeID;

            if (_OldLicenseID == -1 || _AppTypeID ==-1)
                return;

            lblOldLicenseID.Text = OldLicenseID.ToString();
            AppFees = clsApplicationType.Find(_AppTypeID).ApplicationFees;
            lblAppFees.Text = AppFees.ToString();
            
            lblUsername.Text = clsLoginUser.LoginUser;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
        }


    }
}
