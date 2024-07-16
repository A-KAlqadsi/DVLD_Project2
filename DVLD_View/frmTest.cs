using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DVLD_View
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "this is required!");
            }
            else
                errorProvider1.SetError(textBox1, "");
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = "C:\\DVLD-People-Images\\7902477d-3f0e-41ab-bc22-1103a2eb4232.jpg";
            File.Delete(location);
        }
    }
}
