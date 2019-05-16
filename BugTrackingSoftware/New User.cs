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
    public partial class NewUser : Form
    {
        public NewUser()
        {
           //InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbURole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void New_User_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             DBConnection con = new DBConnection();
            string sql_LUserlist = "Select UserName from tbl_userlogin";
            MySqlCommand cmd1 = new MySqlCommand(sql_LUserlist, con.Db_Connect());
            MySqlDataReader r = cmd1.ExecuteReader();

            if (r.Read())
            {
                String UserNameCheck = r.GetString("UserName");
                if (txtUname.Text != UserNameCheck)
                {
                    try
                    {
                        
                        if (txtCPass.Text == txtPass.Text)
                        {
                            //Connecting to the database for checking unique username
                            String sql_insertusr = "INSERT INTO tbl_userlogin(UserName, Password, Usr_Type,Request_Verified) VALUES ('" + txtUname.Text + "','" + txtPass.Text + "','Tracker','No')";
                            MySqlCommand cmd2 = new MySqlCommand(sql_insertusr, con.Db_Connect());
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("User " + txtUname.Text + " successfully Created!!!");

                            txtUname.Clear();
                            txtPass.Clear();
                            txtCPass.Clear();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password do not match.");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("User Name already exists.");
                        txtUname.Clear();
                        txtPass.Clear();
                        txtCPass.Clear();                     
                    }
                }

                else
                {
                    MessageBox.Show("UserName already exist!!!");
                }
            }
            else
            {

            }

        }
      }
    }
