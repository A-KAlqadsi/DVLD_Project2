﻿using System;
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
    public partial class frmVisionTestAppointment : Form
    {
        public frmVisionTestAppointment()
        {
            InitializeComponent();
        }

        private void frmVisionTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlApplicationCard1.LoadApplicationInfo(30);
        }
    }
}
