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
    public partial class frmTimeSheet : Form
    {
        frmExportTimesheet formExportTimesheet = null;
        frmAddTimesheet formAddTimesheet = null;
        frmUpdateTimeshet formUpdateTimesheet = null;

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        public frmTimeSheet()
        {
            InitializeComponent();

        }

        private void btnTimers_Click(object sender, EventArgs e)
        {
            frmTimers formTimers = new frmTimers();

            formTimers.Show();
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (formAddTimesheet == null || formAddTimesheet.Text == "")
            {
                formAddTimesheet = new frmAddTimesheet();
                formAddTimesheet.Dock = DockStyle.Fill;
                formAddTimesheet.Show();
            }
            else if (CheckOpened(formAddTimesheet.Text))
            {
                formAddTimesheet.WindowState = FormWindowState.Normal;
                formAddTimesheet.Dock = DockStyle.Fill;
                formAddTimesheet.Show();
                formAddTimesheet.Focus();
            }
        }

        private void btnUpdateTime_Click(object sender, EventArgs e)
        {
            if (formUpdateTimesheet == null || formUpdateTimesheet.Text == "")
            {
                formUpdateTimesheet = new frmUpdateTimeshet();
                formUpdateTimesheet.Dock = DockStyle.Fill;
                formUpdateTimesheet.Show();
            }
            else if (CheckOpened(formUpdateTimesheet.Text))
            {
                formUpdateTimesheet.WindowState = FormWindowState.Normal;
                formUpdateTimesheet.Dock = DockStyle.Fill;
                formUpdateTimesheet.Show();
                formUpdateTimesheet.Focus();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (formExportTimesheet == null || formExportTimesheet.Text == "")
            {
                formExportTimesheet = new frmExportTimesheet();
                formExportTimesheet.Dock = DockStyle.Fill;
                formExportTimesheet.Show();
            }
            else if (CheckOpened(formExportTimesheet.Text))
            {
                formExportTimesheet.WindowState = FormWindowState.Normal;
                formExportTimesheet.Dock = DockStyle.Fill;
                formExportTimesheet.Show();
                formExportTimesheet.Focus();
            }
        }
    }
}
