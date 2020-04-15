using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.OleDb;

namespace Project___Look_Arch_Job_Managment
{
    public partial class frmProject : Form
    {
        DatabaseConnection connectDB = new DatabaseConnection();

        frmDashboard formDashboard;

        frmProject formProject;

        public frmProject()
        {
            InitializeComponent();

            this.formDashboard = new frmDashboard();
            //form2.Show();
            formDashboard.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectDB.ConnectDatabase();


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
    }
}

