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
    public partial class frmDashboard : Form
    {
        

        frmProject formProject;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {

            frmProject project = new frmProject();

            //project.ShowDialog();
            //Hide();
            //project.Close();


            if (formProject == null)
            {
                formProject = new frmProject();   //Create form if not created
                //formProject.FormClosed += formProject_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            formProject.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

