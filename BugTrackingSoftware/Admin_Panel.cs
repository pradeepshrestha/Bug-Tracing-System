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
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BugTrackingSoftware
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
            usidpassth = Login.usridpass;
            String utypepass = Login.usrtypepass;
            lbl_ApLUserName.Text = Login.usrnamepass + " (" + utypepass + ")";
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            try
            {
                //loading datagrid data at the page load
                DBConnection con1 = new DBConnection();
                string sql_Usrlist = "Select User_Id,UserName from tbl_userlogin";
                MySqlCommand cmd1 = new MySqlCommand(sql_Usrlist, con1.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda1.Fill(dt);
                dataGridView_ApUserList.DataSource = dt;
                con1.CloseConnection();



                //loading new buglist with no solution reply
                DBConnection con = new DBConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug where B_Update=''";
                MySqlCommand cmd = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt1 = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt1.Clear();
                msda.Fill(dt1);
                dataGridView_APBGL.DataSource = dt1;
                con.CloseConnection();


                //loading solved buglist with  solution reply
                DBConnection con2 = new DBConnection();
                string sql_BuglistSolve = "Select B_Id,B_Subject from tbl_bug where B_Update!=''";
                MySqlCommand cmd2 = new MySqlCommand(sql_BuglistSolve, con2.Db_Connect());

                DataTable dt2 = new DataTable();
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd2);
                dt2.Clear();
                msda2.Fill(dt2);
                dataGridView_APBGS.DataSource = dt2;
                con2.CloseConnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void AdminPanelfun()
        {
            try
            {

                //loading data in datagrid view in page load
                DBConnection con1 = new DBConnection();
                string sql_Usrlist = "Select User_Id,UserName from tbl_userlogin";
                MySqlCommand cmd1 = new MySqlCommand(sql_Usrlist, con1.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda1.Fill(dt);
                dataGridView_ApUserList.DataSource = dt;
                con1.CloseConnection();



                //loading new buglist with no solution reply
                DBConnection con = new DBConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug where B_Update=''";
                MySqlCommand cmd = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt1 = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt1.Clear();
                msda.Fill(dt1);
                dataGridView_APBGL.DataSource = dt1;
                con.CloseConnection();


                //loading solved buglist with  solution reply
                DBConnection con2 = new DBConnection();
                string sql_BuglistSolve = "Select B_Id,B_Subject from tbl_bug where B_Update!=''";
                MySqlCommand cmd2 = new MySqlCommand(sql_BuglistSolve, con2.Db_Connect());

                DataTable dt2 = new DataTable();
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd2);
                dt2.Clear();
                msda2.Fill(dt2);
                dataGridView_APBGS.DataSource = dt2;
                con2.CloseConnection();



            }
            catch (Exception ex)
            {


            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_ApUser_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_ApUser_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox_Changepassword_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage_ApAccount_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_ApUserList_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void btn_ApEdit_Click(object sender, EventArgs e)
        {

        }

        private void btn_ApView_Click(object sender, EventArgs e)
        {
            //creating upcomming userdetailview form object in this form
            //UserDetail frm = new UserDetailView();
            //load data from datagridview to UserDetailView form in label
            //frm.lbl_UdUsrId.Text = this.dataGridView_ApUserList.CurrentRow.Cells[0].Value.ToString();
            //frm.Show();
        }

        private void btn_connectgitlab_Click(object sender, EventArgs e)
        {

        }
    }
}
