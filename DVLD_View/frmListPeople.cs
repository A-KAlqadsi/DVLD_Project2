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
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private DataView _DataView;
        private DataTable _DataTable;

        private void _RefreshPeople(DataView dv)
        {
            dgvListPeople.Rows.Clear();
            string gender;
            string countryName;
            int counter = 0;
            DateTime birthOfDate;

                if(dv != null)
                counter = dv.Count;

            for (int i = 0; i < dv.Count; i++) 
            {
                countryName = clsCountry.Find(Convert.ToInt32(dv[i]["NationalityCountryID"])).CountryName;
                birthOfDate = Convert.ToDateTime(dv[i]["DateOfBirth"]);
                gender = (Convert.ToInt16(dv[i]["Gender"]) == 0) ? "Male" : "Female";

                dgvListPeople.Rows.Add(dv[i]["PersonID"], dv[i]["NationalNo"], dv[i]["FirstName"], dv[i]["SecondName"],
                    dv[i]["ThirdName"], dv[i]["LastName"], gender, birthOfDate.ToShortDateString(), countryName, dv[i]["Phone"], dv[i]["Email"]);
            }

            
            lblRecordsCount.Text = counter.ToString();

        }

        private  void _LoadAllPeople()
        {
            _DataTable = clsPerson.GetAll();
             
            _DataView = _DataTable.DefaultView;
            _DataView.Sort = "PersonID DESC"; // sorting inside the dataview
            
            _RefreshPeople(_DataView);
        }

        private void _ResetFilter()
        {
            _LoadAllPeople();

            cbFilterPeople.SelectedIndex = 0;
            cbGenderFilter.SelectedIndex = 0;
            txtFilter.Clear();
            txtFilter.Visible= false;
            cbGenderFilter.Visible= false;
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _ResetFilter();            
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("show person details will be here");
            int personID =(int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmPersonDetails personDetails = new frmPersonDetails(personID);
            personDetails.ShowDialog();
            personDetails.StartPosition = FormStartPosition.CenterParent;
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("add new person will be here");
            frmAddEditPerson addEditPerson = new frmAddEditPerson(-1);
            addEditPerson.ShowDialog();
            _LoadAllPeople();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("edit person will be here");
            int iD = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmAddEditPerson addEdit = new frmAddEditPerson(iD);
            addEdit.ShowDialog();
            _LoadAllPeople();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Delete person will be here");
            int iD = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            
            if(MessageBox.Show($"Are you sure you want to delete Person with ID=[{iD}]","Confirm Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)== DialogResult.OK)
            {
                if (clsPerson.Delete(iD))
                {
                    MessageBox.Show($"Delete person with ID = [{iD}] success!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadAllPeople();
                }
                else
                {
                    MessageBox.Show($"Delete person with ID = [{iD}] fail!", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("send email to person will be here");

        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("call phone to person will be here");

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("add new person will be here");
            frmAddEditPerson addEditPerson = new frmAddEditPerson(-1);
            addEditPerson.ShowDialog();
            _LoadAllPeople();
        }

        //Filter part
        private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbFilterPeople.SelectedItem == "None")
            {
                _ResetFilter();
            }
            else if (cbFilterPeople.SelectedItem == "Gender")
            {
                _LoadAllPeople();
                cbGenderFilter.Visible = true;
                txtFilter.Visible = false;
            }
            else
            {
                cbGenderFilter.SelectedIndex = 0;
                txtFilter.Visible = true;
                cbGenderFilter.Visible = false;
            }
            
        }

        private void cbGenderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbGenderFilter.SelectedIndex)
            {
                case 0:
                    _LoadAllPeople();
                    break;
                case 1:
                    _FilterByGender(0);
                    break;
                case 2:
                    _FilterByGender(1);
                    break;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilterPeople.SelectedIndex) 
            {
                case 1:
                    {
                        
                        if (txtFilter.Text == "")
                        {
                            _LoadAllPeople();
                            return;
                        }

                        if (int.TryParse(txtFilter.Text.ToString(), out int personID))
                            _FilterByPersonID(personID);
                         
                    }
                    break;
                case 2:
                    _FilterByNationalNo(txtFilter.Text);
                    break;
                case 3:
                    _FilterByFirstName(txtFilter.Text);
                    break;
                case 4:
                    _FilterBySecondName(txtFilter.Text);
                    break;
                case 5:
                    _FilterByThirdName(txtFilter.Text);
                    break;
                case 6:
                    _FilterByLastName(txtFilter.Text);
                    break;
                case 8:
                    // nationality filter
                    break;
                case 9:
                    _FilterByPhone(txtFilter.Text);
                    break;
                case 10:
                    _FilterByEmail(txtFilter.Text);
                    break;
            }
        }

        private void _FilterByGender(short gender=0)
        {
            _DataView.RowFilter = $"Gender = {gender}";
            _RefreshPeople(_DataView);
            
        }

        private void _FilterByPersonID(int personID)
        {
            _DataView.RowFilter = $"PersonID ={personID}";
            _RefreshPeople(_DataView);
            _DataView = _DataTable.DefaultView;
        }

        private void _FilterByNationalNo(string nationalNo)
        {
            _DataView.RowFilter = $"NationalNo LIKE '{nationalNo}%'";
            _RefreshPeople(_DataView);
        }

        private void _FilterByFirstName(string firstName)
        {
            
            _DataView.RowFilter = $"FirstName LIKE '{firstName}%'";
            _RefreshPeople(_DataView);
        }

        private void _FilterBySecondName(string secondName)
        {      
            _DataView.RowFilter = $"SecondName LIKE '{secondName}%'";
            _RefreshPeople(_DataView);
        }

        private void _FilterByThirdName(string thirdName)
        {
            _DataView.RowFilter = $"ThirdName LIKE '{thirdName}%'";
            _RefreshPeople(_DataView);
        }

        private void _FilterByLastName(string lastName)
        {
            _DataView.RowFilter = $"LastName LIKE '{lastName}%'";
            _RefreshPeople(_DataView);
        }

        private void _FilterByPhone(string phone)
        {
            _DataView.RowFilter = $"Phone LIKE '{phone}%'";
            _RefreshPeople(_DataView);
        }

        private void _FilterByEmail(string email)
        {
            _DataView.RowFilter = $"Email LIKE '{email}%'";
            _RefreshPeople(_DataView);
        }

        // end filter part

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // filter validate 
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _FilterValidate(e);
        }

        private void _FilterValidate(KeyPressEventArgs e)
        {
            if(cbFilterPeople.SelectedIndex == 1 || cbFilterPeople.SelectedIndex ==9)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
