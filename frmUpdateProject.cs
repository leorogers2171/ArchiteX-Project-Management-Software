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
    public partial class frmUpdateProject : Form
    {
        public frmUpdateProject()
        {
            InitializeComponent();
        }

        private void frmUpdateProject_Load(object sender, EventArgs e)
        {
            if (current == 0)
            {
                populateProjectName();
            }
            //bindProjectname();
        }
        int current = 0;
        public void bindProjectname(int projectID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ProjectTitle, StatusRunning, HouseNum, RoadName, TownCity, Country, PostCode" +
                " FROM lookarchjobs.Projects" + " WHERE ProjectID = " + projectID;
            dr = dbConnector.DoSQL(sqlStr);

            dr.Read();

            List<ProjectClass> ProjectList = new List<ProjectClass>();
            ProjectList.Add(new ProjectClass { ProjectID = projectID, ProjectName = dr[0].ToString() });

            comboBoxProjectName.DisplayMember = "ProjectName";
            comboBoxProjectName.ValueMember = "ProjectID";
            comboBoxProjectName.DataSource = ProjectList;


            comboBoxRunningStatus.Text = dr[1].ToString();
            txtBoxHouseNum.Text = dr[2].ToString();
            txtBoxRoadName.Text = dr[3].ToString();
            txtBoxTownCity.Text = dr[4].ToString();
            txtBoxCounty.Text = dr[5].ToString();
            txtBoxPostCode.Text = dr[6].ToString();
            current = 1;
            comboBoxProjectName.DropDownStyle = ComboBoxStyle.Simple;
        }


        private void populateProjectName()
        {

            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ProjectID, ProjectTitle, HouseNum, RoadName, TownCity, Country, PostCode, StatusRunning" +
                " FROM lookarchjobs.Projects";
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

       

        private void comboBoxProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxProjectID.Text = comboBoxProjectName.SelectedValue.ToString();

            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ProjectID, StatusRunning, HouseNum, RoadName, TownCity, Country, PostCode" +
                " FROM lookarchjobs.Projects" + " WHERE ProjectID = " + comboBoxProjectName.SelectedValue.ToString();
            dr = dbConnector.DoSQL(sqlStr);

            dr.Read();

            comboBoxRunningStatus.Text = dr[1].ToString();
            txtBoxHouseNum.Text = dr[2].ToString();
            txtBoxRoadName.Text = dr[3].ToString();
            txtBoxTownCity.Text = dr[4].ToString();
            txtBoxCounty.Text = dr[5].ToString();
            txtBoxPostCode.Text = dr[6].ToString();

        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            //Update Database
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();

            sqlStr = "UPDATE lookarchjobs.Projects " + "SET ProjectTitle = '" + comboBoxProjectName.Text + "', StatusRunning = '" + comboBoxRunningStatus.Text 
                + "', HouseNum = '" + txtBoxHouseNum.Text + "', RoadName = '" + txtBoxRoadName.Text + "', TownCity = '" + txtBoxTownCity.Text + "', Country = '" + txtBoxCounty.Text 
                + "', PostCode ='" + txtBoxPostCode.Text + "' WHERE ProjectID = '" + txtBoxProjectID.Text + "'";
            dr = dbConnector.DoSQL(sqlStr);

            (Application.OpenForms["frmProject"] as frmProject).displayData();
            this.Close();
        }

    }
    class ProjectClass

    {

        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

    }


}