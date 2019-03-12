using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___Look_Arch_Job_Managment
{
    public partial class frmSupport : Form
    {
        public frmSupport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:mail@icustomweb.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.icustomweb.com");
        }

        private void frmSupport_Load(object sender, EventArgs e)
        {

            lblFormError.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxReportBug.Text == "Frequency" || textBoxDescription.Text == "")
            {
                lblFormError.Text = "Please Fill All Options";
            }


        }
    }
}
