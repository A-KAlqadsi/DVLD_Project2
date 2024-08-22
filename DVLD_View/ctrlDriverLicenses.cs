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
        
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        
        public void LoadLocalLicenseHistory(int driverId)
        {
            dgvListLocalLicenses.Rows.Clear();
            DataTable driverLicenses = clsLicense.GetAllDriverLicenses(driverId);
            DataView licensesView = driverLicenses.DefaultView;
            licensesView.Sort = "LicenseID DESC";
           
            string issueDate;
            string expirDate;
            bool isActive;

            if (licensesView.Count > 0)
                lblLocalLicenseCount.Text = licensesView.Count.ToString();


            for (int i = 0;i<licensesView.Count;i++)
            {
                issueDate = Convert.ToDateTime(licensesView[i]["IssueDate"]).ToShortDateString();
                expirDate = Convert.ToDateTime(licensesView[i]["ExpirationDate"]).ToShortDateString();
                isActive = Convert.ToBoolean(licensesView[i]["IsActive"]);
                dgvListLocalLicenses.Rows.Add(licensesView[i]["LicenseID"], licensesView[i]["ApplicationID"], licensesView[i]["ClassName"], issueDate, expirDate, isActive);
            }
        

            //if (driverLicenses.Rows.Count > 0)
            //    lblLocalLicenseCount.Text = driverLicenses.Rows.Count.ToString();
            //foreach(DataRow row in driverLicenses.Rows)
            //{
            //    issueDate = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
            //    expirDate = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
            //    isActive = Convert.ToBoolean(row["IsActive"]);
            //    dgvListLocalLicenses.Rows.Add(row["LicenseID"], row["ApplicationID"], row["ClassName"], issueDate,expirDate,isActive);
            //}

        }

        public void LoadInternatioalLicenseHistory(int driverId)
        {
            dgvListInternationalLicenses.Rows.Clear();
            DataTable driverLicenses = clsInternationalLicense.GetAllDriverLicenses(driverId);
            string issueDate;
            string expirDate;
            bool isActive;

            DataView licensesView = driverLicenses.DefaultView;
            licensesView.Sort = "InternationalLicenseID DESC";

            
            if (licensesView.Count > 0)
                lblInternationalLicensesCount.Text = licensesView.Count.ToString();


            for (int i = 0; i < licensesView.Count; i++)
            {
                issueDate = Convert.ToDateTime(licensesView[i]["IssueDate"]).ToShortDateString();
                expirDate = Convert.ToDateTime(licensesView[i]["ExpirationDate"]).ToShortDateString();
                isActive = Convert.ToBoolean(licensesView[i]["IsActive"]);
                dgvListInternationalLicenses.Rows.Add(licensesView[i]["InternationalLicenseID"], licensesView[i]["ApplicationID"], licensesView[i]["IssuedUsingLocalLicenseID"], issueDate, expirDate, isActive);
            }


            //if (driverLicenses.Rows.Count > 0)
            //    lblInternationalLicensesCount.Text = driverLicenses.Rows.Count.ToString();
            //foreach (DataRow row in driverLicenses.Rows)
            //{
            //    issueDate = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
            //    expirDate = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
            //    isActive = Convert.ToBoolean(row["IsActive"]);
            //    dgvListInternationalLicenses.Rows.Add(row["InternationalLicenseID"], row["ApplicationID"], row["IssuedUsingLocalLicenseID"], issueDate, expirDate, isActive);
            //}

        }

        private void tsmiShowLocalLicenseInfo_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvListLocalLicenses.CurrentRow.Cells[0].Value;
            frmShowLicenseCard card = new frmShowLicenseCard(licenseId);
            card.ShowDialog();
        }

        private void tsmiShowInterLicenseInfo_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvListInternationalLicenses.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseCard card = new frmShowInternationalLicenseCard(licenseId);
            card.ShowDialog();
        }
    }
}
