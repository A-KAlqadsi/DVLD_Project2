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
    public partial class frmAddEditAplicationType : Form
    {
        enum enMode { AddNew =1,Update =2}
        enMode _Mode;
        private bool _IsEmpty = false;
        private int _AppTypeID;
        private float _Fees;
        private clsApplicationType _AppType;
        public frmAddEditAplicationType(int appTypeID)
        {
            InitializeComponent();

            _AppTypeID = appTypeID;
            if(_AppTypeID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add Application Type";
                lblMode.Text = "Add New Application Type";
                _AppType = new clsApplicationType();
                return;
            }

            _AppType = clsApplicationType.Find(_AppTypeID);

            if (_AppType == null)
            {
                MessageBox.Show($"This screen will be closed because no application Type with Id=[{_AppTypeID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAppTypeID.Text = _AppType.ApplicationTypeID.ToString();
            txtTitle.Text = _AppType.ApplicationTitle;
            txtFees.Text = _AppType.ApplicationFees.ToString();

        }

        private void frmAddEditAplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsFieldsEmpty()
        {
            epValidateInput.Clear();
            if(txtTitle.Text.Trim() == "")
            {
                _IsEmpty =true;
                epValidateInput.SetError(txtTitle, "Title is required!");
            }

            if (txtFees.Text.Trim() == "")
            {
                _IsEmpty = true;
                epValidateInput.SetError(txtFees, "Fees is required!");
            }

            return _IsEmpty;    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_IsFieldsEmpty())
            {
                _IsEmpty= false;
                return;
            }

            if(!float.TryParse(txtFees.Text.ToString(),out  _Fees))
            {
                epValidateInput.SetError(txtFees, "Fees is not valid!");
                return;
            }

            _AppType.ApplicationTitle = txtTitle.Text;
            _AppType.ApplicationFees = _Fees;

            if (_AppType.Save())
                MessageBox.Show("Application type saved successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Application type save fail", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lblAppTypeID.Text = _AppType.ApplicationTypeID.ToString();
            txtTitle.Text = _AppType.ApplicationTitle;
            txtFees.Text = _AppType.ApplicationFees.ToString();
           
        }
    }
}
