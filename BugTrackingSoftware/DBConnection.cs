using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BugTrackingSoftware
{
    class DBConnection
    {
        MySqlConnection conn = new MySqlConnection ("server=localhost;port=3306;username=root;password=;database=bug_tracking_system");

        // this function opens the connection
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // this function closes the connection
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // this function returns the connection
        public MySqlConnection getConnection()
        {
            return conn;
        }


        }
    }
