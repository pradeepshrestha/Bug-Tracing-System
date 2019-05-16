using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BugTrackingSoftware
{
    class DBConnection
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection Db_Connect()
        {
            server = "localhost";
            database = "bug_tracking_system";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            // this function opens the connection
            connection.Open();
            // this function returns the connection
            return connection;
        }

        // this function closes the connection
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}