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
    public partial class frmAdministration : Form
    {
        public frmAdministration()
        {
            InitializeComponent();
            displayData();
            populateComboBox();
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
            sqlStr = "SELECT * FROM `WorkType`";
            dr = dbConnector.DoSQL(sqlStr);
            listView1.Items.Clear();
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[1].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[2].ToString());
            }
        }

        private void populateComboBox()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT * FROM `WorkType`";
            dr = dbConnector.DoSQL(sqlStr);

            List<ProjectClass> ProjectList = new List<ProjectClass>();

            while (dr.Read())
            {
                ProjectList.Add(new ProjectClass { ProjectID = Convert.ToInt32(dr[0]), ProjectName = dr[1].ToString() });

            }

            comboBoxWorktypeID.DisplayMember = "ProjectID";
            comboBoxWorktypeID.ValueMember = "ProjectName";
            comboBoxWorktypeID.DataSource = ProjectList;
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxWorktypeID_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT * FROM `WorkType`" + " WHERE WorkTypeID = " + (Convert.ToInt32(comboBoxWorktypeID.SelectedIndex) + 1).ToString();
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                textBoxUWorktype.Text = dr[1].ToString();
                textBoxUDescription.Text = dr[2].ToString();
            }
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems[0].ToString());
            string updtaeRecord = listView1.SelectedItems[0].SubItems[0].Text;
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT * FROM `WorkType`" + " WHERE WorkTypeID = " + updtaeRecord;
            dr = dbConnector.DoSQL(sqlStr);

            dr.Read();

            comboBoxWorktypeID.Text = updtaeRecord;
            textBoxUWorktype.Text = dr[1].ToString();
            textBoxUDescription.Text = dr[2].ToString();
        }

        private void buttonAAddWorktype_Click(object sender, EventArgs e)
        {
            string cmdStr = null;
            clsDBConnector dbConnector = new clsDBConnector();

            if (textBoxAWorktypeID.Text == "LEAVE FOR AUTO NUM" || textBoxAWorktypeID.Text == "" || textBoxAWorktypeID.Text == "0")
            {
                cmdStr = "INSERT INTO lookarchjobs.WorkType (WorkTypeID, WorkType, Description) " +

                "VALUES ('" + "" + "' , '" + textBoxAWorktype.Text + "' , '" + textBoxADescription.Text + "')";
            }

            else
            {
                cmdStr = "INSERT INTO lookarchjobs.WorkType (WorkTypeID, WorkType, Description) " +

                "VALUES ('" + textBoxAWorktypeID.Text + "' , '" + textBoxAWorktype.Text + "' , '" + textBoxADescription.Text + "')";
            }


            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);

            dbConnector.close();
            displayData();
        }

        private void buttonUUpdateworktype_Click(object sender, EventArgs e)
        {
            //Update Database
            clsDBConnector dbConnector = new clsDBConnector();
            MySqlDataReader dr;
            string sqlStr;
            dbConnector.Connect();

            sqlStr = "UPDATE lookarchjobs.WorkType " + "SET WorkType = '" + textBoxUWorktype.Text
                + "', Description = '" + textBoxUDescription.Text + "' WHERE WorkTypeID = '" + comboBoxWorktypeID.Text + "'";
            dr = dbConnector.DoSQL(sqlStr);
            displayData();
            //(Application.OpenForms["frmProject"] as frmProject).displayData();
            //this.Close();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
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
                        sqlStr = "DELETE FROM lookarchjobs.WorkType WHERE " + recordToRemove + " = WorkTypeID";
                        dr = dbConnector.DoSQL(sqlStr);

                        displayData();
                    }

                }
            }
        }
    }
}
