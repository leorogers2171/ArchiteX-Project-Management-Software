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
    public partial class frmStaffMembers : Form
    {
        frmAddStaff formAddStaff = null;
        frmUpdateStaff formUpdateStaff = null;
        public frmStaffMembers()
        {
            InitializeComponent();
        }

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

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (formAddStaff == null || formAddStaff.Text == "")
            {
                formAddStaff = new frmAddStaff();
                formAddStaff.Dock = DockStyle.Fill;
                formAddStaff.Show();
            }
            else if (CheckOpened(formAddStaff.Text))
            {
                formAddStaff.WindowState = FormWindowState.Normal;
                formAddStaff.Dock = DockStyle.Fill;
                formAddStaff.Show();
                formAddStaff.Focus();
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (formUpdateStaff == null || formUpdateStaff.Text == "")
            {
                formUpdateStaff = new frmUpdateStaff();
                formUpdateStaff.Dock = DockStyle.Fill;
                formUpdateStaff.Show();
            }
            else if (CheckOpened(formAddStaff.Text))
            {
                formUpdateStaff.WindowState = FormWindowState.Normal;
                formUpdateStaff.Dock = DockStyle.Fill;
                formUpdateStaff.Show();
                formUpdateStaff.Focus();
            }
        }
    }
}
