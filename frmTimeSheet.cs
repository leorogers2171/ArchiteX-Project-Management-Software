using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Project___Look_Arch_Job_Managment
{
    public partial class frmTimeSheet : Form
    {
        frmExportTimesheet formExportTimesheet = null;
        frmAddTimesheet formAddTimesheet = null;
        frmUpdateTimeshet formUpdateTimesheet = null;
        frmAdministration formAdministration = null;
    

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
            displayData();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (formAdministration == null || formAdministration.Text == "")
            {
                formAdministration = new frmAdministration();
                formAdministration.Dock = DockStyle.Fill;
                formAdministration.Show();
            }
            else if (CheckOpened(formAddTimesheet.Text))
            {
                formAdministration.WindowState = FormWindowState.Normal;
                formAdministration.Dock = DockStyle.Fill;
                formAdministration.Show();
                formAdministration.Focus();
            }
        }

        public void displayData()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[0].Remove();
            }
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT TimeSheet2.TimeSheetID, TimeSheet2.ProjectID, Projects.ProjectTitle, StaffMembers.FirstName, " +
                "StaffMembers.LastName, TimeSheet2.WorkstageID, TimeSheet2.Date, TimeSheet2.Billable, TimeSheet2.HoursSpent " +
                "FROM TimeSheet2, Projects, StaffMembers WHERE TimeSheet2.ProjectID = Projects.ProjectID " +
                "AND StaffMembers.StaffID = TimeSheet2.StaffID";
            dr = dbConnector.DoSQL(sqlStr);
            listView1.Items.Clear();
            while (dr.Read())
            {
                DateTime dt = DateTime.Parse(dr[6].ToString());
                listView1.Items.Add(dr[1].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[2].ToString());

                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[3].ToString() + " " + dr[3].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[5].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dt.ToString("MM / dd / yyyy"));
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[7].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[8].ToString());

                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[0].ToString());
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            string recordToRemove = listView1.SelectedItems[0].SubItems[7].Text;

            var formUpdateTimesheet = new frmUpdateTimeshet();
            formUpdateTimesheet.bindProjectname(Convert.ToInt32(recordToRemove));
            formUpdateTimesheet.Show();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    string recordToRemove = listView1.SelectedItems[0].SubItems[7].Text;


                    DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        clsDBConnector dbConnector = new clsDBConnector();
                        MySqlDataReader dr;
                        string sqlStr;
                        dbConnector.Connect();
                        sqlStr = "DELETE FROM lookarchjobs.TimeSheet2 WHERE " + recordToRemove + " = TimeSheetID";
                        dr = dbConnector.DoSQL(sqlStr);

                        displayData();
                    }

                }
            }
        }
    }
}
