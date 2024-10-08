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
    public partial class ctrlInternationalApplicationInfo : UserControl
    {
        private int appTypeID = 6; //  international license application type
        
        public int AppTypeID { get { return appTypeID;  } private set { } }
        const int licenseClassID = 3; // class 3 only can be international 
        public ctrlInternationalApplicationInfo()
        {
            InitializeComponent();
        }

        private void ctrlInternationalApplicationInfo_Load(object sender, EventArgs e)
        {
            clsApplicationType appType = clsApplicationType.Find(appTypeID);
            clsLicenseClass licenseClass = clsLicenseClass.Find(licenseClassID);

            if (appType == null || licenseClass == null)
            {
                MessageBox.Show($"there is error in ctrlInternationalApplicationInfo, when loading the data");
                return;
            }
            
            DateTime issueDate = DateTime.Now;
            DateTime expireDate = issueDate.AddYears(licenseClass.ValidityLength);

            lblAppFees.Text = appType.ApplicationFees.ToString();
            lblApplicationDate.Text = DateTime.Now.ToString("d");
            lblIssueDate.Text = issueDate.ToString("d");
            lblExpirationDate.Text = expireDate.ToString("d");
            lblUsername.Text = clsLoginUser.LoginUser; 

        }
    }
}
