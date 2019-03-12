using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project___Look_Arch_Job_Managment
{
    public partial class frmCreateProject : Form
    {
        public frmCreateProject()
        {
            InitializeComponent();
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


        private bool regexValidation(string condition, string pattern)
        {
            var preg = new Regex(pattern, RegexOptions.IgnoreCase);

            foreach (var xElement in condition)
            {
                if (!preg.IsMatch(condition))
                {
                    return true;
                }
            }

            return false;
        }

        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        private void sendValues()
        {
            string cmdStr = null;
            clsDBConnector dbConnector = new clsDBConnector();

            if (txtBoxProjectID.Text == "LEAVE FOR AUTO NUM" || txtBoxProjectID.Text == "" || txtBoxProjectID.Text == "0")
            {
                cmdStr = "INSERT INTO lookarchjobs.Projects (ProjectID, ProjectTitle, HouseNum, RoadName, TownCity, Country, PostCode, StatusRunning) " +

                "VALUES ('" + "" + "' , '" + txtBoxProjectName.Text + "' , '" + txtBoxHouseNum.Text + "' " +
                ", '" + txtBoxRoadName.Text + "' , '" + txtBoxTownCity.Text + "' , '" + txtBoxCounty.Text + "' , '" + txtBoxPostCode.Text + "' , '" + comboBoxRunningStatus.Text + "')";
            }

            else
            {
                cmdStr = "INSERT INTO lookarchjobs.Projects (ProjectID, ProjectTitle, HouseNum, RoadName, TownCity, Country, PostCode, StatusRunning) " +

               "VALUES ('" + txtBoxProjectID.Text + "' , '" + txtBoxProjectName.Text + "' , '" + txtBoxHouseNum.Text + "' " +
               ", '" + txtBoxRoadName.Text + "' , '" + txtBoxTownCity.Text + "' , '" + txtBoxCounty.Text + "' , '" + txtBoxPostCode.Text + "' , '" + comboBoxRunningStatus.Text + "')";
            }


            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);

            dbConnector.close();
            (Application.OpenForms["frmProject"] as frmProject).displayData();
            this.Close();
        }


        private void btnAddProject_Click(object sender, EventArgs e)
        {
            bool spaceCheck = false;
            bool runSendValues = true;

            if (allControlsFilled(this) == false)
            {
                MessageBox.Show("Please, input in all boxes");
            }

            else
            {
                if (!txtBoxPostCode.Text.Contains(" "))
                {
                    MessageBox.Show("Input Space In Postcode");
                    spaceCheck = true;
                    runSendValues = false;
                }

                else if (regexValidation(txtBoxPostCode.Text, "^([A-Z]{1,2})([0-9][0-9A-Z]?) ([0-9])([ABDEFGHJLNPQRSTUWXYZ]{2})$") == true && spaceCheck == false)
                {
                    MessageBox.Show("Please, input the postcode in the correct format");
                    runSendValues = false;
                }

                if (regexValidation(txtBoxHouseNum.Text, "^[0-9]+$"))
                {
                    MessageBox.Show("Only use numbers for House Number");
                    runSendValues = false;
                }


                if (runSendValues == true)
                {
                    sendValues();
                }
            }
           
        }

    }
}
