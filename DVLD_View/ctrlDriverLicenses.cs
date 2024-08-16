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
            string issueDate;
            string expirDate;
            bool isActive;

            if (driverLicenses.Rows.Count > 0)
                lblLocalLicenseCount.Text = driverLicenses.Rows.Count.ToString();
            foreach(DataRow row in driverLicenses.Rows)
            {
                issueDate = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
                expirDate = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
                isActive = Convert.ToBoolean(row["IsActive"]);
                dgvListLocalLicenses.Rows.Add(row["LicenseID"], row["ApplicationID"], row["ClassName"], issueDate,expirDate,isActive);
            }

        }

        public void LoadInternatioalLicenseHistory(int driverId)
        {
            dgvListInternationalLicenses.Rows.Clear();
            DataTable driverLicenses = clsInternationalLicense.GetAllDriverLicenses(driverId);
            string issueDate;
            string expirDate;
            bool isActive;

            if (driverLicenses.Rows.Count > 0)
                lblInternationalLicensesCount.Text = driverLicenses.Rows.Count.ToString();
            foreach (DataRow row in driverLicenses.Rows)
            {
                issueDate = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
                expirDate = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();
                isActive = Convert.ToBoolean(row["IsActive"]);
                dgvListInternationalLicenses.Rows.Add(row["InternationalLicenseID"], row["ApplicationID"], row["IssuedUsingLocalLicenseID"], issueDate, expirDate, isActive);
            }

        }



    }
}
