using MySql.Data.MySqlClient;

namespace Project___Look_Arch_Job_Managment
{
    public class DatabaseConnection
    {
        public void ConnectDatabase()
        {
            MySqlConnection connection = null;
            string databaseName = "lookarchjobs";
            string connstring = string.Format("Server=euve260091.serverprofi24.net; database={0}; UID=lookleo; password=ipodipod2171; SslMode=none", databaseName);
            connection = new MySqlConnection(connstring);
            connection.Open();
        }
    }
}

