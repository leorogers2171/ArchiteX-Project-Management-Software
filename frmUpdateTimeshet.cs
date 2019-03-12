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
    public partial class frmUpdateTimeshet : Form
    {
        public frmUpdateTimeshet()
        {
            InitializeComponent();
            populateProjectName();
            populateStaffName();
            populateWorkType();
        }

        public void bindProjectname(int timesheetID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ProjectID, StaffID, WorkstageID, HoursSpent, Date, WorkTypeID, Rate, ExtraTime, Billable" +
                " FROM lookarchjobs.TimeSheet2" + " WHERE TimeSheetID = " + timesheetID;
            dr = dbConnector.DoSQL(sqlStr);

            dr.Read();

            txtBoxTimesheetID.Text = timesheetID.ToString();

            int workStageTestID = Convert.ToInt32(dr[2]);

            comboBoxWorkstage.SelectedIndex = (Convert.ToInt32(dr[2])-1); //Use Timesheet ID SQL Query in frmTimeSheet


            txtBoxHoursSpent.Text = dr[3].ToString();
            dateTimesheet.Value = Convert.ToDateTime(dr[4]);
            txtBoxRate.Text = dr[6].ToString();
            comboBoxChargable.Text = dr[8].ToString();
            comboBoxExtraTime.Text = dr[7].ToString();
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
                WorkTypeList.Add(new ProjectClass { ProjectID = Convert.ToInt32(dr[0]), ProjectName = dr[1].ToString() });

            }

            comboBoxWorkType.DisplayMember = "ProjectName";
            comboBoxWorkType.ValueMember = "ProjectID";
            comboBoxWorkType.DataSource = WorkTypeList;
        }

        private void btnUpdateTimesheet_Click(object sender, EventArgs e)
        {
            //Update Database
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();

            sqlStr = "UPDATE lookarchjobs.TimeSheet2 " + "SET ProjectID = '" + comboBoxProjectName.SelectedValue.ToString() + "', StaffID = '" + comboBoxStaffName.SelectedValue.ToString()
                + "', WorkstageID = '" + (comboBoxWorkstage.SelectedIndex + 1) + "', HoursSpent = '" + txtBoxHoursSpent.Text + "', Date = '" + dateTimesheet.Value.Date.ToString("yyyy-MM-dd HH:mm") + "', WorkTypeID = '" + comboBoxWorkType.SelectedValue.ToString()
                + "', Rate ='" + txtBoxRate.Text + "', ExtraTime = '" + comboBoxExtraTime.Text + "', Billable = '" + comboBoxChargable.Text + "' WHERE TimeSheetID = '" + txtBoxTimesheetID.Text + "'";
            dr = dbConnector.DoSQL(sqlStr);

            (Application.OpenForms["frmTimeSheet"] as frmTimeSheet).displayData();
            this.Close();
        }
    }


}
