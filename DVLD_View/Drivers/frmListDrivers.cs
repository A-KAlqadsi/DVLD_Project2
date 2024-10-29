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
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private DataView _DataView;
        private DataTable _DataTable;

        private void _RefreshDrivers(DataView dv)
        {
            dgvListDrivers.Rows.Clear();
            int counter = 0;
            
            if (dv != null)
                counter = dv.Count;

            for (int i = 0; i < dv.Count; i++)
            {  
                dgvListDrivers.Rows.Add(dv[i]["DriverID"],dv[i]["PersonID"], dv[i]["NationalNo"],dv[i]["FullName"], dv[i]["CreatedDate"] , dv[i]["NumberOfActiveLicenses"]);
            }


            lblRecordsCount.Text = counter.ToString();

        }

        private void _LoadAllDrivers()
        {
            _DataTable = clsDriver.GetAll();

            _DataView = _DataTable.DefaultView;
            _DataView.Sort = "DriverID DESC"; // sorting inside the dataview

            _RefreshDrivers(_DataView);
        }

        private void _ResetFilter()
        {
            _LoadAllDrivers();

            cbFilterDrivers.SelectedIndex = 0;            
            txtFilter.Clear();
            txtFilter.Visible = false;
            
        }


        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _ResetFilter();
        }

        private void cbFilterDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterDrivers.SelectedItem == "None")
            {
                _ResetFilter();
            }
           
            else
            {
                txtFilter.Visible = true;
                txtFilter.Focus();
                
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilterDrivers.SelectedIndex)
            {
                case 1:
                    {

                        if (txtFilter.Text == "")
                        {
                            _LoadAllDrivers();
                            return;
                        }

                        if (int.TryParse(txtFilter.Text.ToString(), out int driverID))
                            _FilterByID("DriverID", driverID);

                    }
                    break;
                case 2:
                    if (txtFilter.Text == "")
                    {
                        _LoadAllDrivers();
                        return;
                    }

                    if (int.TryParse(txtFilter.Text.ToString(), out int personID))
                        _FilterByID("PersonID", personID);
                    break;
                case 3:
                    _FilterByString("NationalNo",txtFilter.Text);
                    break;
                case 4:
                    _FilterByString("FullName", txtFilter.Text);
                    break;
                case 5:
                    if (txtFilter.Text == "")
                    {
                        _LoadAllDrivers();
                        return;
                    }

                    if (int.TryParse(txtFilter.Text.ToString(), out int activeLicenses))
                        _FilterByID("NumberOfActiveLicenses", activeLicenses);
                    break;
                
            }
            

        }

        private void _FilterByID(string colName ,int personID)
        {
            _DataView.RowFilter = $"{colName} ={personID}";
            _RefreshDrivers(_DataView);
            _DataView = _DataTable.DefaultView;
        }

        private void _FilterByString(string colName ,string nationalNo)
        {
            _DataView.RowFilter = $"{colName} LIKE '{nationalNo}%'";
            _RefreshDrivers(_DataView);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _FilterValidate(e);
        }
        private void _FilterValidate(KeyPressEventArgs e)
        {
            if (cbFilterDrivers.SelectedIndex == 1 || cbFilterDrivers.SelectedIndex == 2 || cbFilterDrivers.SelectedIndex == 5)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
