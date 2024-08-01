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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        private int _PersonID;
        public int PersonID = -1;
        private clsPerson _Person;
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbPersonFilters.SelectedIndex = 0;
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson addEdit = new frmAddEditPerson(-1);
            addEdit.evPersonIDBack += _evPersonIDBack; // subscripe to the event
            addEdit.ShowDialog();
        }

        private void _evPersonIDBack(int personID)
        {
            if(personID != -1)
            {
                cbPersonFilters.SelectedIndex = 1;
                PersonID = personID;
                txtSearch.Text = personID.ToString();
                ctrlPersonCard1.LoadPersonInfo(personID);
            }
        }


        private void btnFind_Click_1(object sender, EventArgs e)
        {
            epFilterValidating.Clear();
            if (txtSearch.Text.Trim() == "")
            {
                epFilterValidating.SetError(txtSearch, "Search field is Empty!!");
                return;
            }

            if (cbPersonFilters.SelectedIndex == 0)
            {
                if (!int.TryParse(txtSearch.Text.ToString(), out _PersonID))
                {
                    epFilterValidating.SetError(txtSearch, "Person ID is not valid,only digits!");
                    return;
                }
            }

            switch (cbPersonFilters.SelectedIndex)
            {
                case 0:
                    {
                        _Person = clsPerson.Find(_PersonID);
                        if (_Person != null)
                        {
                            PersonID = _Person.PersonID;
                            ctrlPersonCard1.LoadPersonInfo(_Person.PersonID);

                        }
                        else
                            MessageBox.Show($"Person with ID = [{_PersonID}] is not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    {
                        _Person = clsPerson.Find(txtSearch.Text);
                        if (_Person != null)
                        {
                            PersonID = _Person.PersonID;
                            ctrlPersonCard1.LoadPersonInfo(_Person.NationalNo);
                        }
                        else
                            MessageBox.Show($"Person with National No = [{txtSearch.Text}] is not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    break;
            }

        }
    
    }
}
