namespace BugTrackingSoftware
{
    partial class BugEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugEntryForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Add = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_Tracker = new System.Windows.Forms.DateTimePicker();
            this.lbl_UserIdDisplay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Usershow = new System.Windows.Forms.Label();
            this.txt_Imageurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_Bug = new System.Windows.Forms.PictureBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxt_Code = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_Describe = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Project = new System.Windows.Forms.ComboBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tab_List = new System.Windows.Forms.TabPage();
            this.lbl_BugIdDisplay = new System.Windows.Forms.Label();
            this.lbl_Bugid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ListSubject = new System.Windows.Forms.TextBox();
            this.dataGridView_Bug = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_ListDone = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxt_ListDescribtion = new System.Windows.Forms.RichTextBox();
            this.rtxt_ListCode = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bug)).BeginInit();
            this.tab_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bug)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tab_Add);
            this.tabControl1.Controls.Add(this.tab_List);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 664);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Add
            // 
            this.tab_Add.Controls.Add(this.textBox1);
            this.tab_Add.Controls.Add(this.btnUpdate);
            this.tab_Add.Controls.Add(this.btnDelete);
            this.tab_Add.Controls.Add(this.label11);
            this.tab_Add.Controls.Add(this.dateTimePicker_Tracker);
            this.tab_Add.Controls.Add(this.lbl_UserIdDisplay);
            this.tab_Add.Controls.Add(this.label10);
            this.tab_Add.Controls.Add(this.lbl_Usershow);
            this.tab_Add.Controls.Add(this.txt_Imageurl);
            this.tab_Add.Controls.Add(this.label1);
            this.tab_Add.Controls.Add(this.button1);
            this.tab_Add.Controls.Add(this.pictureBox_Bug);
            this.tab_Add.Controls.Add(this.btn_Submit);
            this.tab_Add.Controls.Add(this.label5);
            this.tab_Add.Controls.Add(this.rtxt_Code);
            this.tab_Add.Controls.Add(this.label4);
            this.tab_Add.Controls.Add(this.rtxt_Describe);
            this.tab_Add.Controls.Add(this.label3);
            this.tab_Add.Controls.Add(this.comboBox_Project);
            this.tab_Add.Controls.Add(this.txt_Subject);
            this.tab_Add.Controls.Add(this.label2);
            this.tab_Add.Controls.Add(this.lbl_Username);
            this.tab_Add.Location = new System.Drawing.Point(4, 31);
            this.tab_Add.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Add.Name = "tab_Add";
            this.tab_Add.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Add.Size = new System.Drawing.Size(934, 629);
            this.tab_Add.TabIndex = 0;
            this.tab_Add.Text = "Add";
            this.tab_Add.UseVisualStyleBackColor = true;
            this.tab_Add.Click += new System.EventHandler(this.tab_Add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 26);
            this.textBox1.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(600, 539);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 73);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update Bug Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(778, 539);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 73);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Bug Details";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Line Number:";
            // 
            // dateTimePicker_Tracker
            // 
            this.dateTimePicker_Tracker.Location = new System.Drawing.Point(653, 18);
            this.dateTimePicker_Tracker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_Tracker.Name = "dateTimePicker_Tracker";
            this.dateTimePicker_Tracker.Size = new System.Drawing.Size(273, 26);
            this.dateTimePicker_Tracker.TabIndex = 18;
            // 
            // lbl_UserIdDisplay
            // 
            this.lbl_UserIdDisplay.AutoSize = true;
            this.lbl_UserIdDisplay.Location = new System.Drawing.Point(508, 18);
            this.lbl_UserIdDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserIdDisplay.Name = "lbl_UserIdDisplay";
            this.lbl_UserIdDisplay.Size = new System.Drawing.Size(72, 19);
            this.lbl_UserIdDisplay.TabIndex = 17;
            this.lbl_UserIdDisplay.Text = "<Userid>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "User Id:";
            // 
            // lbl_Usershow
            // 
            this.lbl_Usershow.AutoSize = true;
            this.lbl_Usershow.Location = new System.Drawing.Point(122, 18);
            this.lbl_Usershow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Usershow.Name = "lbl_Usershow";
            this.lbl_Usershow.Size = new System.Drawing.Size(127, 19);
            this.lbl_Usershow.TabIndex = 15;
            this.lbl_Usershow.Text = "<Usernametype>";
            // 
            // txt_Imageurl
            // 
            this.txt_Imageurl.Location = new System.Drawing.Point(22, 302);
            this.txt_Imageurl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Imageurl.Name = "txt_Imageurl";
            this.txt_Imageurl.ReadOnly = true;
            this.txt_Imageurl.Size = new System.Drawing.Size(230, 26);
            this.txt_Imageurl.TabIndex = 14;
            this.txt_Imageurl.Text = "Image Url";
            this.txt_Imageurl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_Bug
            // 
            this.pictureBox_Bug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Bug.Location = new System.Drawing.Point(22, 158);
            this.pictureBox_Bug.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Bug.Name = "pictureBox_Bug";
            this.pictureBox_Bug.Size = new System.Drawing.Size(385, 136);
            this.pictureBox_Bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bug.TabIndex = 11;
            this.pictureBox_Bug.TabStop = false;
            this.pictureBox_Bug.Click += new System.EventHandler(this.pictureBox_Bug_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(441, 539);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(139, 73);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "ADD Bug Details";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "CODE:";
            // 
            // rtxt_Code
            // 
            this.rtxt_Code.Location = new System.Drawing.Point(441, 123);
            this.rtxt_Code.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_Code.Name = "rtxt_Code";
            this.rtxt_Code.Size = new System.Drawing.Size(485, 408);
            this.rtxt_Code.TabIndex = 7;
            this.rtxt_Code.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Describe";
            // 
            // rtxt_Describe
            // 
            this.rtxt_Describe.Location = new System.Drawing.Point(22, 369);
            this.rtxt_Describe.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_Describe.Name = "rtxt_Describe";
            this.rtxt_Describe.Size = new System.Drawing.Size(385, 239);
            this.rtxt_Describe.TabIndex = 5;
            this.rtxt_Describe.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Subject";
            // 
            // comboBox_Project
            // 
            this.comboBox_Project.FormattingEnabled = true;
            this.comboBox_Project.Items.AddRange(new object[] {
            "BugTracker",
            "Social media",
            "other project"});
            this.comboBox_Project.Location = new System.Drawing.Point(136, 57);
            this.comboBox_Project.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Project.Name = "comboBox_Project";
            this.comboBox_Project.Size = new System.Drawing.Size(260, 27);
            this.comboBox_Project.TabIndex = 3;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(22, 123);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(385, 26);
            this.txt_Subject.TabIndex = 2;
            this.txt_Subject.Text = "Enter Subject";
            this.txt_Subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Project :";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(18, 18);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(89, 19);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "User Name:";
            // 
            // tab_List
            // 
            this.tab_List.Controls.Add(this.lbl_BugIdDisplay);
            this.tab_List.Controls.Add(this.lbl_Bugid);
            this.tab_List.Controls.Add(this.label9);
            this.tab_List.Controls.Add(this.txt_ListSubject);
            this.tab_List.Controls.Add(this.dataGridView_Bug);
            this.tab_List.Controls.Add(this.button5);
            this.tab_List.Controls.Add(this.button4);
            this.tab_List.Controls.Add(this.btn_ListDone);
            this.tab_List.Controls.Add(this.label8);
            this.tab_List.Controls.Add(this.label7);
            this.tab_List.Controls.Add(this.rtxt_ListDescribtion);
            this.tab_List.Controls.Add(this.rtxt_ListCode);
            this.tab_List.Controls.Add(this.label6);
            this.tab_List.Location = new System.Drawing.Point(4, 31);
            this.tab_List.Margin = new System.Windows.Forms.Padding(4);
            this.tab_List.Name = "tab_List";
            this.tab_List.Padding = new System.Windows.Forms.Padding(4);
            this.tab_List.Size = new System.Drawing.Size(934, 629);
            this.tab_List.TabIndex = 1;
            this.tab_List.Text = "List";
            this.tab_List.UseVisualStyleBackColor = true;
            // 
            // lbl_BugIdDisplay
            // 
            this.lbl_BugIdDisplay.AutoSize = true;
            this.lbl_BugIdDisplay.Location = new System.Drawing.Point(462, 4);
            this.lbl_BugIdDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BugIdDisplay.Name = "lbl_BugIdDisplay";
            this.lbl_BugIdDisplay.Size = new System.Drawing.Size(78, 19);
            this.lbl_BugIdDisplay.TabIndex = 16;
            this.lbl_BugIdDisplay.Text = "<Display>";
            // 
            // lbl_Bugid
            // 
            this.lbl_Bugid.AutoSize = true;
            this.lbl_Bugid.Location = new System.Drawing.Point(396, 4);
            this.lbl_Bugid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bugid.Name = "lbl_Bugid";
            this.lbl_Bugid.Size = new System.Drawing.Size(58, 19);
            this.lbl_Bugid.TabIndex = 15;
            this.lbl_Bugid.Text = "Bug Id:";
            this.lbl_Bugid.Click += new System.EventHandler(this.lbl_Bugid_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Subject";
            // 
            // txt_ListSubject
            // 
            this.txt_ListSubject.Location = new System.Drawing.Point(466, 40);
            this.txt_ListSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ListSubject.Name = "txt_ListSubject";
            this.txt_ListSubject.Size = new System.Drawing.Size(452, 26);
            this.txt_ListSubject.TabIndex = 13;
            // 
            // dataGridView_Bug
            // 
            this.dataGridView_Bug.AllowUserToAddRows = false;
            this.dataGridView_Bug.AllowUserToDeleteRows = false;
            this.dataGridView_Bug.AllowUserToOrderColumns = true;
            this.dataGridView_Bug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bug.Location = new System.Drawing.Point(12, 43);
            this.dataGridView_Bug.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Bug.Name = "dataGridView_Bug";
            this.dataGridView_Bug.ReadOnly = true;
            this.dataGridView_Bug.Size = new System.Drawing.Size(360, 529);
            this.dataGridView_Bug.TabIndex = 12;
            this.dataGridView_Bug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Bug_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 580);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 580);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_ListDone
            // 
            this.btn_ListDone.Location = new System.Drawing.Point(717, 580);
            this.btn_ListDone.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ListDone.Name = "btn_ListDone";
            this.btn_ListDone.Size = new System.Drawing.Size(200, 34);
            this.btn_ListDone.TabIndex = 9;
            this.btn_ListDone.Text = "Done";
            this.btn_ListDone.UseVisualStyleBackColor = true;
            this.btn_ListDone.Click += new System.EventHandler(this.btn_ListDone_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "CODE";
            // 
            // rtxt_ListDescribtion
            // 
            this.rtxt_ListDescribtion.Location = new System.Drawing.Point(400, 359);
            this.rtxt_ListDescribtion.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_ListDescribtion.Name = "rtxt_ListDescribtion";
            this.rtxt_ListDescribtion.Size = new System.Drawing.Size(517, 213);
            this.rtxt_ListDescribtion.TabIndex = 6;
            this.rtxt_ListDescribtion.Text = "";
            // 
            // rtxt_ListCode
            // 
            this.rtxt_ListCode.Location = new System.Drawing.Point(401, 118);
            this.rtxt_ListCode.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_ListCode.Name = "rtxt_ListCode";
            this.rtxt_ListCode.Size = new System.Drawing.Size(518, 199);
            this.rtxt_ListCode.TabIndex = 5;
            this.rtxt_ListCode.Text = "";
            this.rtxt_ListCode.TextChanged += new System.EventHandler(this.rtxt_ListCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Submited Bug Reports";
            // 
            // BugEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 691);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BugEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Entry Form";
            this.Load += new System.EventHandler(this.Bug_Entry_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Add.ResumeLayout(false);
            this.tab_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bug)).EndInit();
            this.tab_List.ResumeLayout(false);
            this.tab_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Tracker;
        private System.Windows.Forms.Label lbl_UserIdDisplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Usershow;
        private System.Windows.Forms.TextBox txt_Imageurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_Bug;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxt_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_Describe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Project;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TabPage tab_List;
        private System.Windows.Forms.Label lbl_BugIdDisplay;
        private System.Windows.Forms.Label lbl_Bugid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ListSubject;
        private System.Windows.Forms.DataGridView dataGridView_Bug;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_ListDone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxt_ListDescribtion;
        private System.Windows.Forms.RichTextBox rtxt_ListCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;

    }
}