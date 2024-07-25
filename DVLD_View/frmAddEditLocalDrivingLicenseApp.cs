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
    public partial class frmAddEditLocalDrivingLicenseApp : Form
    {
        enum enMode { AddNew =1,Update =2}
        enMode _Mode;
        private int _LLicenseAppID;
        private int _PersonID;
        private clsApplication _Application;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;

        public frmAddEditLocalDrivingLicenseApp(int lLicenseAppID)
        {
            InitializeComponent();

            _LLicenseAppID = lLicenseAppID;
            if(_LLicenseAppID == -1)
                _Mode=enMode.AddNew;
            else 
                _Mode=enMode.Update;

        }

        private void _LoadLicenseClasses()
        {
            DataTable dt = clsLicenseClass.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbLicenseClasses.Items.Add(dr["ClassName"]);
            }
            cbLicenseClasses.SelectedIndex = 2;
        }

        private void _LoadData()
        {
            _LoadLicenseClasses();

            if(_Mode ==enMode.AddNew)
            {
                _Application = new clsApplication();
                _LocalDrivingLicenseApp = new clsLocalDrivingLicenseApp();
                return;
            }


        }

        private void frmAddEditLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _PersonID = ctrlPersonCardWithFilter1.PersonID;
            if(_PersonID == -1)
            {
                MessageBox.Show($"Choose Person Info First!", "Person Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;   
            }

            tcLocalDrivingLicenseInfo.SelectedTab = tpApplicationInfo;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcLocalDrivingLicenseInfo.SelectedTab = tpPersonalInfo;
        }
    }
}
