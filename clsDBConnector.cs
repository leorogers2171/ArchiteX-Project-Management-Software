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
    class clsDBConnector
    {
        MySqlConnection conn = new MySqlConnection();
        string dbProvider;
        string dbSource;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string sslMode;

        public void Connect()
        {
            server = "euve260091.serverprofi24.net";
            database = "lookarchjobs";
            uid = "lookleo";
            password = "ipodipod2171";
            sslMode = "none";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SslMode=" + sslMode;


            // dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
            // dbSource = "Data Source =dbStudentlates.accdb";
            // conn.ConnectionString = dbProvider + dbSource;
            conn.ConnectionString = connectionString;
            conn.Open();
        }

        public void close()
        {
            conn.Close();
        }

        public void DoDML(string dmlString)
        {
            MySqlCommand cmd;
            cmd = new MySqlCommand(dmlString, conn);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader DoSQL(string sqlString)
        {
            MySqlCommand cmd;
            cmd = new MySqlCommand(sqlString, conn);
            return cmd.ExecuteReader();
        }
    }
}
