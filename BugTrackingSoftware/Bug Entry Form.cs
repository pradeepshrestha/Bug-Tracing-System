﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace BugTrackingSoftware
{
    public partial class BugEntryForm : Form
    {
        String imglocation = "";

        public BugEntryForm()
        {
            InitializeComponent();

            //receiving value from the login panel and displaying in label.
            String utypepass = Login.usrtypepass;
            lbl_UserIdDisplay.Text = Login.usridpass;
            lbl_Usershow.Text = Login.usrnamepass + " (" + utypepass + ")";

        }

        private void BugEntryForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection con = new DBConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug";
                MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_Bug.DataSource = dt;
                con.CloseConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tab_Add_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Bugid_Click(object sender, EventArgs e)
        {

        }

        private void Bug_Entry_Form_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection con = new DBConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug";
                MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_Bug.DataSource = dt;
                con.CloseConnection();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                //converting image to byte
                byte[] images = null;
                //first declare using system.io; then
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);


                if (rtxt_Code.Text != "" && rtxt_Describe.Text != "" && txt_Subject.Text != "" && txt_Imageurl.Text != "")
                {
                    //Inserting data to the database
                    DBConnection con = new DBConnection();
                    String sql_insertbug = "INSERT INTO tbl_bug(User_Id,B_Subject,B_Describe,B_Code,B_Image,B_Update,Date, Project) VALUES ('" + lbl_UserIdDisplay.Text + "','" + txt_Subject.Text + "','" + rtxt_Describe.Text + "','" + rtxt_Code.Text + "','" + images + "','','" + dateTimePicker_Tracker.Text + "','" + comboBox_Project.Text + "')";
                    MySqlCommand cmd1 = new MySqlCommand(sql_insertbug, con.Db_Connect());
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Bug have been reported");
                    con.CloseConnection();

                    //clearing all the values from the field
                    pictureBox_Bug.Image = null;
                    txt_Imageurl.Clear();
                    txt_Subject.Clear();
                    rtxt_Describe.Clear();
                    rtxt_Code.Clear();
                }
                else
                {
                    MessageBox.Show("Fill all the empty Field!!");
                }

                try
                {
                    DBConnection con = new DBConnection();
                    string sql_Buglist = "Select B_Id,B_Subject from tbl_bug";
                    MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());

                    DataTable dt = new DataTable();
                    MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
                    dt.Clear();
                    msda.Fill(dt);
                    dataGridView_Bug.DataSource = dt;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for image upload
            OpenFileDialog openimg = new OpenFileDialog();
            openimg.Filter = "image only |*.jpg; *.jpeg; *.png";
            DialogResult dr = openimg.ShowDialog();
            pictureBox_Bug.Image = Image.FromFile(openimg.FileName);
            txt_Imageurl.Text = openimg.FileName;
            imglocation = openimg.FileName.ToString();
        }

        private void dataGridView_Bug_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //showing data to field after clicking the row
                DataGridViewRow row = dataGridView_Bug.SelectedRows[0];
                lbl_BugIdDisplay.Text = row.Cells["B_Id"].Value.ToString();
                txt_ListSubject.Text = row.Cells["B_Subject"].Value.ToString();

                DBConnection con = new DBConnection();
                string sql_Buglist = "Select * from tbl_bug where B_Id ='" + lbl_BugIdDisplay.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());
                MySqlDataReader r = cmd1.ExecuteReader();

                if (r.Read())
                {
                    rtxt_ListCode.Text = r.GetString("B_Code");
                    rtxt_ListDescribtion.Text = r.GetString("B_Describe");

                }
                else
                {
                    MessageBox.Show("error !!!!!!   B_Code aand B_Describe not shown" + sql_Buglist);

                }
            }
            catch (Exception ex)
            {


            }

        }

        private void dataGridView_Bug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void rtxt_ListCode_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            int index = rtxt_Code.SelectionStart;

            foreach (Match m in rx.Matches(rtxt_Code.Text))
            {
                rtxt_Code.Select(m.Index, m.Value.Length);
                rtxt_Code.SelectionColor = Color.Blue;
                rtxt_Code.SelectionStart = index;
                rtxt_Code.SelectionColor = Color.Black;
            }

            Regex rx1 = new Regex("String");
            int index1 = rtxt_Code.SelectionStart;

            foreach (Match m1 in rx1.Matches(rtxt_Code.Text))
            {
                rtxt_Code.Select(m1.Index, m1.Value.Length);
                rtxt_Code.SelectionColor = Color.Green;
                rtxt_Code.SelectionStart = index;
                rtxt_Code.SelectionColor = Color.Black;
            }

            Regex rx2 = new Regex("private");
            int index2 = rtxt_Code.SelectionStart;

            foreach (Match m2 in rx2.Matches(rtxt_Code.Text))
            {
                rtxt_Code.Select(m2.Index, m2.Value.Length);
                rtxt_Code.SelectionColor = Color.BlueViolet;
                rtxt_Code.SelectionStart = index;
                rtxt_Code.SelectionColor = Color.Black;
            }
        }

        private void btn_ListDone_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            string sql_updateBug = "UPDATE tbl_Bug SET B_Subject= '" + txt_ListSubject.Text + "', B_Code='" + rtxt_ListCode.Text + "', B_Describe='" + rtxt_ListDescribtion.Text + "' WHERE B_Id= '" + lbl_BugIdDisplay.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql_updateBug, con.Db_Connect());
            cmd.ExecuteNonQuery();


            MessageBox.Show("Update Successful");
            txt_ListSubject.Clear();
            rtxt_ListCode.Clear();
            rtxt_ListDescribtion.Clear();



            string sql_Buglist = "Select B_Id,B_Subject from tbl_bug";
            MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());

            DataTable dt = new DataTable();
            MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
            dt.Clear();
            msda.Fill(dt);
            dataGridView_Bug.DataSource = dt;
            con.CloseConnection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_ListSubject.Clear();
            rtxt_ListCode.Clear();
            rtxt_ListDescribtion.Clear();
        }

        private void pictureBox_Bug_Click(object sender, EventArgs e)
        {

        }
    }
}
