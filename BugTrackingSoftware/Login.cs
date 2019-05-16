using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BugTrackingSoftware
{
    public partial class Login : Form
    {
        //declaring variable to pass the value to the Bug Entry Form and Bug Solution Form
        /// <summary>
        /// declaring variable to pass the value to the Bug Entry Form and Bug Solution Form
        /// Declaring Public static String
        /// </summary> 
        public static String usridpass, usrnamepass, usrtypepass;

        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// calling nest pannel by making object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
            this.Hide();
        }

        private void txt_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        //function for database calling
        /// <summary>
        /// database calling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {

            DBConnection dc = new DBConnection();
            String sql_login = "SELECT * FROM tbl_userlogin WHERE UserName = '" + txtUserName.Text + "' AND Password= '" + txtPass.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql_login, dc.Db_Connect());
            MySqlDataReader r = cmd.ExecuteReader();


            if (r.Read())
            {

                //retrieveing value from column and sending value to the top declare variable(line 18) for Bug Entry Form.
                String idpass = r.GetString("User_Id");
                usridpass = idpass;


                String unamepass = r.GetString("UserName");
                usrnamepass = unamepass;

                String usertype = r.GetString("Usr_Type");
                usrtypepass = usertype;
                //Checking User Types
                switch (usertype)
                {

                    case "Developer":
                        MessageBox.Show("welcome to Bug Tracking System (Developer)");
                        BugSolutionForm pp = new BugSolutionForm();
                        pp.Show();
                        break;

                    case "Admin":
                        MessageBox.Show("welcome to Bug Tracking System (Admin)");
                        Admin_Panel ap = new Admin_Panel();
                        ap.Show();
                        break;

                    case "Tester":
                        MessageBox.Show("welcome to Bug Tracking System (Tester)");
                        BugEntryForm tp = new BugEntryForm();
                        tp.Show();

                        //  tp.lbl_Usershow.Text = idpass;

                        break;
                    default:
                        MessageBox.Show(usertype);
                        MessageBox.Show("welcome to BugTracking System (error!!!!!!)");
                        BugEntryForm err = new BugEntryForm();
                        err.Show();
                        break;
                }

                //for hiding loginpanel
                this.Hide();

                //for closing database connection
                dc.CloseConnection();
            }

            else
            {
                MessageBox.Show("Username or Password incorrect!!!");
            }

        }

    }
}
