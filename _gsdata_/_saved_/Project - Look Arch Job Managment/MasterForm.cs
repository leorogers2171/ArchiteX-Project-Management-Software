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

    public partial class MasterForm : Form
    {
        DatabaseConnection connectDB = new DatabaseConnection();


        frmDashboard FormDashboard = new frmDashboard();
        frmProject FormProject = new frmProject();


        public MasterForm()
        {
           InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            connectDB.ConnectDatabase();

            FormDashboard.MdiParent = this;
            FormDashboard.Dock = DockStyle.Fill;

            //Panel Show

            formsPanel.Controls.Clear();
            FormDashboard.TopLevel = false;
            formsPanel.Controls.Add(FormDashboard);
            FormDashboard.Show();

        }

        private void switchPanelFormColor(string btnClicked)
        {

            var btnList = new List<Button> { btnDashboard, btnProjects, btnTimeSheet, btnStaffMembers, btnExpenses, btnReports };


            for (int i = 0; i < btnList.Count; i++)
            {
                if (btnList[i].Name != btnClicked)
                {
                    btnList[i].BackColor = Color.FromArgb(35, 35, 35);
                    btnList[i].ForeColor = Color.White;

                }
                if ( btnList[i].Name == btnClicked)
                {
                    btnList[i].BackColor = Color.LightGray;
                    btnList[i].ForeColor = Color.Black;
                }
            }
        }

        private void swichPanelForm(string btnClicked)
        {

            Form[] formArray = new Form[6];
            formArray[0] = new frmDashboard();
            formArray[1] = new frmProject();
            formArray[2] = new frmTimeSheet();
            formArray[3] = new frmStaffMembers();
            formArray[4] = new frmExpenses();
            formArray[5] = new frmReports();


            for (int i = 0; i < formArray.Length; i++)
            {
                if (formArray[i].Name == btnClicked)
                {
                    formArray[i].MdiParent = this;
                    formArray[i].Dock = DockStyle.Fill;


                    formsPanel.Controls.Clear();
                    FormProject.TopLevel = false;
                    formsPanel.Controls.Add(formArray[i]);
                    formArray[i].Show();
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            switchPanelFormColor("btnDashboard");
            swichPanelForm("frmDashboard");
        }

 

        private void btnProjects_Click(object sender, EventArgs e)
        {
            switchPanelFormColor("btnProjects");
            swichPanelForm("frmProject");
        }



        private void btnTimeSheet_Click(object sender, EventArgs e)
        {
            switchPanelFormColor("btnTimeSheet");
            swichPanelForm("frmTimeSheet");
        }

        private void formsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaffMembers_Click(object sender, EventArgs e)
        {
            switchPanelFormColor("btnStaffMembers");
            swichPanelForm("frmStaffMembers");
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            switchPanelFormColor("btnExpenses");
            swichPanelForm("frmExpenses");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            switchPanelFormColor("btnReports");
            swichPanelForm("frmReports");
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {

            var formSupport = new frmSupport();

            formSupport.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
