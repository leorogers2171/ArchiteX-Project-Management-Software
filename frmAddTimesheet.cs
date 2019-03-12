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
    public partial class frmAddTimesheet : Form
    {
        bool timerActivated = false;

        public frmAddTimesheet()
        {
            InitializeComponent();
            populateProjectName();
            populateStaffName();
            populateWorkType();

        }

        private void btnAddTimesheet_Click(object sender, EventArgs e)
        {
            
            if (allControlsFilled(this) == false)
            {
                MessageBox.Show("Please, input in all fields");
            }

            else
            {
                sendValues();

                (Application.OpenForms["frmTimeSheet"] as frmTimeSheet).displayData();

                if (timerActivated == true)
                {
                    this.Close();
                }

                else if (timerActivated == false)
                {
                    clearControlls();
                }
            }

        }


        private void clearControlls()
        {
            this.Hide();
            comboBoxWorkstage.Text = "Stage 1 - Planning (RIBA 1, 2, 3)";
            txtBoxHoursSpent.Text = "";
            dateTimesheet.Value = DateTime.Now;
            txtBoxRate.Text = "";
            comboBoxChargable.Text = "Yes";
            comboBoxExtraTime.Text = "No";

            populateProjectName();
            populateStaffName();
            populateWorkType();
            this.Show();
        }

        private bool allControlsFilled(Control parent)
        {

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        return false;
                    }
                }

                if (c.GetType() == typeof(ComboBox))
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        return false;
                    }
                }

                else
                {

                }
            }

            return true;
        }


        private void sendValues()
        {
            string cmdStr = null;
            clsDBConnector dbConnector = new clsDBConnector();

            int workstageSelected = comboBoxWorkstage.SelectedIndex + 1;

            cmdStr = "INSERT INTO lookarchjobs.TimeSheet2 ( TimeSheetID, ProjectID, StaffID, WorkstageID, HoursSpent, Date, WorkTypeID, Rate, ExtraTime, Billable) " +

            "VALUES (' ', '" + comboBoxProjectName.SelectedValue.ToString() + "' , '" + comboBoxStaffName.SelectedValue.ToString() + "' , '" + workstageSelected + "' , '" + txtBoxHoursSpent.Text +
            "' , '" + dateTimesheet.Value.Date.ToString("yyyy-MM-dd HH:mm") + "' , '" + comboBoxWorkType.SelectedValue.ToString() + "' , '" + txtBoxRate.Text + "' , '" + comboBoxChargable.Text + "' , '" + comboBoxExtraTime.Text + "')";


            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);

            dbConnector.close();
        }

        private void populateProjectName()
        {

            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ProjectID, ProjectTitle FROM Projects ";
            dr = dbConnector.DoSQL(sqlStr);
            List<ProjectClass> ProjectList = new List<ProjectClass>();

            while (dr.Read())
            {
                ProjectList.Add(new ProjectClass { ProjectID = Convert.ToInt32(dr[0]), ProjectName = dr[1].ToString() });

            }

            comboBoxProjectName.DisplayMember = "ProjectName";
            comboBoxProjectName.ValueMember = "ProjectID";
            comboBoxProjectName.DataSource = ProjectList;

        }

        private void populateStaffName()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT StaffID, FirstName, LastName FROM StaffMembers";
            dr = dbConnector.DoSQL(sqlStr);
            List<ProjectClass> StaffList = new List<ProjectClass>();

            while (dr.Read())
            {
                StaffList.Add(new ProjectClass { ProjectID = Convert.ToInt32(dr[0]), ProjectName = dr[1].ToString() + " " + dr[2].ToString() });

            }

            comboBoxStaffName.DisplayMember = "ProjectName";
            comboBoxStaffName.ValueMember = "ProjectID";
            comboBoxStaffName.DataSource = StaffList;
        }

        private void populateWorkType()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT WorkTypeID, WorkType FROM WorkType";
            dr = dbConnector.DoSQL(sqlStr);
            List<ProjectClass> WorkTypeList = new List<ProjectClass>();

            while (dr.Read())
            {
                WorkTypeList.Add(new ProjectClass { ProjectID = Convert.ToInt32(dr[0]), ProjectName = dr[1].ToString()});

            }

            comboBoxWorkType.DisplayMember = "ProjectName";
            comboBoxWorkType.ValueMember = "ProjectID";
            comboBoxWorkType.DataSource = WorkTypeList;
        }

        public void addRecordedTime(double recordedTime)
        {
            timerActivated = true;

            txtBoxHoursSpent.ReadOnly = true;   
            txtBoxHoursSpent.Text = recordedTime.ToString();

            populateProjectName();
            populateStaffName();
            populateWorkType();
        }


    }
}
