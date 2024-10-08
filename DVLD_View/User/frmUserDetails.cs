﻿using DVLD_Business;
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
    public partial class frmUserDetails : Form
    {
        private int _UserID;
        public frmUserDetails(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        public frmUserDetails(string userName)
        {
            InitializeComponent();

            _UserID = clsUser.Find(userName).UserID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlUserPersonCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}