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
    public partial class frmAddEditTestType : Form
    {
        private enum enMode { AddNew =1,Update=2}
        private enMode _Mode;
        private int _TestTypeID;
        private clsTestType _TestType;
        private float _Fees;
        private bool _IsEmpty = false;

        public frmAddEditTestType(int testTypeID)
        {
            InitializeComponent();
            _TestTypeID = testTypeID;
            if(_TestTypeID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            if(_Mode == enMode.AddNew)
            {
                this.Text = "Add Test Type";
                lblMode.Text = "Add New Test Type";
                _TestType = new clsTestType();
                return;
            }

            _TestType = clsTestType.Find(_TestTypeID);

            if(_TestType == null )
            {
                MessageBox.Show($"This screen will be closed because no test Type with Id=[{_TestTypeID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblMode.Text = "Update Test Type";
            this.Text = "Edit Test Type";

            lblTestTypeID.Text = _TestType.TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text= _TestType.TestTypeFees.ToString();


        }

        private void frmAddEditTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsFieldEmpty()
        {
            epValidateInput.Clear();
            if(txtTitle.Text.Trim() == "")
            {
                _IsEmpty = true;
                epValidateInput.SetError(txtTitle, "Title is reqired!");
                
            }
            if (txtDescription.Text.Trim() == "")
            {
                _IsEmpty = true;
                epValidateInput.SetError(txtDescription, "Description is reqired!");
            }
            if(txtFees.Text.Trim()== "")
            {
                _IsEmpty = true;
                epValidateInput.SetError(txtFees, "Fees is reqired!");
            }

            return _IsEmpty;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_IsFieldEmpty())
            {
                
                _IsEmpty = false;
                return;
            }

            if (!float.TryParse(txtFees.Text.ToString(), out _Fees))
            {
                epValidateInput.SetError(txtFees, "Fees is not valid!");
                return;
            }

            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription=txtDescription.Text;
            _TestType.TestTypeFees = _Fees;

            if (_TestType.Save())
                MessageBox.Show("Test type saved successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Test type save fail", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lblTestTypeID.Text = _TestType.TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestTypeFees.ToString();



        }
    }
}
