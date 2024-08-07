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
    public partial class frmScheduleTest : Form
    {
        enum enTestType { Vision = 1, Written=2,Street=3}
        enTestType _TestType;
        int _TestOrder;
        public frmScheduleTest(int testOrder)
        {
            InitializeComponent();
            _TestOrder = testOrder;
            if (_TestOrder == 1)
                _TestType = enTestType.Vision;
            else if (_TestOrder == 2)
                _TestType = enTestType.Written;
            else 
                _TestType = enTestType.Street;
            
        }

        private void _MakeDateInFuture()
        {
            dtpTestDate.MinDate=DateTime.Now;
        }

        private void _InitilizeTestTypeDefaults()
        {
            if (_TestType == enTestType.Vision)
            {
                gbTestType.Text = "Vision Test";

            }
            else if (_TestType == enTestType.Written)
            {
                gbTestType.Text = "Written Test";
            }
            else
            {
                gbTestType.Text = "Street Test";
            }
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _MakeDateInFuture();
            _InitilizeTestTypeDefaults();
        }
    }
}
