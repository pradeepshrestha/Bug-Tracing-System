using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BugTrackingSoftware
{
    public partial class LoginForm : Form
    {
        //declaring variable to pass the value to the trackerpannel and programmer panel
        /// <summary>
        /// declaring variable to pass the value to the trackerpannel and programmer panel
        /// Declaring Public static String
        /// </summary> 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            New_User newUser = new New_User();
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
    }
}
