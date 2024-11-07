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
    public partial class ctrlDriverLicenses : UserControl
    {
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;
        private clsDriver _Driver;
        private int _DriverId;
        
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

		private void _LoadLocalLicenseInfo()
		{
			_dtDriverLocalLicensesHistory = _Driver.GetDriverLicense();
			dgvListLocalLicenses.DataSource = _dtDriverLocalLicensesHistory;

			lblLocalLicenseCount.Text = dgvListLocalLicenses.Rows.Count.ToString();
			if (dgvListLocalLicenses.Rows.Count > 0)
			{
				dgvListLocalLicenses.Columns[0].HeaderText = "Lic.ID";
				dgvListLocalLicenses.Columns[0].Width = 90;

				dgvListLocalLicenses.Columns[1].HeaderText = "App.ID";
				dgvListLocalLicenses.Columns[1].Width = 90;

				dgvListLocalLicenses.Columns[2].HeaderText = "Class Name";
				dgvListLocalLicenses.Columns[2].Width = 250;

				dgvListLocalLicenses.Columns[3].HeaderText = "Issue Date";
				dgvListLocalLicenses.Columns[3].Width = 140;

				dgvListLocalLicenses.Columns[4].HeaderText = "Expiration Date";
				dgvListLocalLicenses.Columns[4].Width = 140;

				dgvListLocalLicenses.Columns[5].HeaderText = "Is Active";
				dgvListLocalLicenses.Columns[5].Width = 110;

			}
		}

		private void _LoadInternationalLicenseInfo()
		{
			_dtDriverInternationalLicensesHistory = _Driver.GetDriverInternationalLicenses();

			dgvListInternationalLicenses.DataSource = _dtDriverInternationalLicensesHistory;
			lblInternationalLicensesCount.Text = _dtDriverInternationalLicensesHistory.Rows.Count.ToString();

			if (_dtDriverInternationalLicensesHistory.Rows.Count > 0)
			{
				dgvListInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
				dgvListInternationalLicenses.Columns[0].Width = 130;

				dgvListInternationalLicenses.Columns[1].HeaderText = "Application ID";
				dgvListInternationalLicenses.Columns[1].Width = 130;

				dgvListInternationalLicenses.Columns[2].HeaderText = "L.License ID";
				dgvListInternationalLicenses.Columns[2].Width = 130;

				dgvListInternationalLicenses.Columns[3].HeaderText = "Issue Date";
				dgvListInternationalLicenses.Columns[3].Width = 140;

				dgvListInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
				dgvListInternationalLicenses.Columns[4].Width = 140;

				dgvListInternationalLicenses.Columns[5].HeaderText = "Is Active";
				dgvListInternationalLicenses.Columns[5].Width = 120;
			}

		}

		public void LoadInfo(int driverId)
        {
            _Driver = clsDriver.Find(driverId);
            if(_Driver == null)
            {
                MessageBox.Show($"There is no Driver with Id= {driverId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			_DriverId = _Driver.DriverID;

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

		}

		public void LoadInfoByPersonId(int personId)
        {
			_Driver = clsDriver.FindByPersonID(personId);
			if (_Driver == null)
			{
				MessageBox.Show($"There is no Driver linked with Person Id= {personId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_DriverId = _Driver.DriverID;

			_LoadLocalLicenseInfo();
			_LoadInternationalLicenseInfo();

		}

        private void tsmiShowLocalLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowLicenseCard card = new frmShowLicenseCard((int)dgvListLocalLicenses.CurrentRow.Cells[0].Value);
            card.ShowDialog();
        }

		public void Clear()
		{
			dgvListInternationalLicenses.Rows.Clear();
			dgvListLocalLicenses.Rows.Clear();
		}

        private void tsmiShowInterLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseCard card = new frmShowInternationalLicenseCard((int)dgvListInternationalLicenses.CurrentRow.Cells[0].Value);
            card.ShowDialog();
        }
	}
}
