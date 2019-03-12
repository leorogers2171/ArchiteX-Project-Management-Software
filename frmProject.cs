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
    public partial class frmProject : Form
    {
        DBConnect DBConnect = new DBConnect();

        frmDashboard formDashboard;

        frmProject formProject;

        public frmProject()
        {
            InitializeComponent();

            this.formDashboard = new frmDashboard();
            //form2.Show();
            formDashboard.Hide();
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
            sqlStr = "SELECT ProjectID, ProjectTitle, HouseNum, RoadName, TownCity, Country, PostCode, StatusRunning FROM lookarchjobs.Projects";
            dr = dbConnector.DoSQL(sqlStr);
            listView1.Items.Clear();
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[1].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[2].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[3].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[4].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[5].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[6].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[7].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (formDashboard == null)
            {
                formDashboard = new frmDashboard();   //Create form if not created
                //formDashboard.FormClosed += formDashboard_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            formDashboard.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmCreateProject formCreateProject = new frmCreateProject();

            formCreateProject.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formUpdateProject = new frmUpdateProject();

            formUpdateProject.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formExportProjects = new frmExportProjects();

            formExportProjects.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void listView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    string recordToRemove = listView1.SelectedItems[i].SubItems[0].Text;


                    DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        clsDBConnector dbConnector = new clsDBConnector();
                        MySqlDataReader dr;
                        string sqlStr;
                        dbConnector.Connect();
                        sqlStr = "DELETE FROM lookarchjobs.Projects WHERE " + recordToRemove + " = ProjectID";
                        dr = dbConnector.DoSQL(sqlStr);

                        displayData();
                    }

                }
            }

            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string recordToRemove = listView1.SelectedItems[0].SubItems[0].Text;
            var formUpdateProject = new frmUpdateProject();
            formUpdateProject.bindProjectname(Convert.ToInt32(recordToRemove));
            formUpdateProject.Show();

        }
    }
}

