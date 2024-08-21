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
    public partial class ctrlRenewLicenseApplicationInfo : UserControl
    {
        private int appTypeID = 2; //  Renew license application type

        public int AppTypeID { get { return appTypeID; } private set { } }

        public ctrlRenewLicenseApplicationInfo()
        {
            InitializeComponent();
        }
    }
}
