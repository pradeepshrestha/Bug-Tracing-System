namespace BugTrackingSoftware
{
    partial class UserPanel
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
            this.RequestList = new System.Windows.Forms.TabPage();
            this.dataGridView_RequestList = new System.Windows.Forms.DataGridView();
            this.btn_RequestAccept = new System.Windows.Forms.Button();
            this.UserDetailEdit = new System.Windows.Forms.TabPage();
            this.lbl_UdEUsrId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_UsrType = new System.Windows.Forms.GroupBox();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.rb_Programmer = new System.Windows.Forms.RadioButton();
            this.rb_Tracker = new System.Windows.Forms.RadioButton();
            this.btn_UDECancel = new System.Windows.Forms.Button();
            this.btn_UDEDone = new System.Windows.Forms.Button();
            this.lbl_UDEUsrname = new System.Windows.Forms.Label();
            this.UserDetail = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UdDeleteUsr = new System.Windows.Forms.Button();
            this.lbl_UdUsrId = new System.Windows.Forms.Label();
            this.lbl_UdUsrName = new System.Windows.Forms.Label();
            this.lbl_UdUsrType = new System.Windows.Forms.Label();
            this.lbl_UdNumBugReport = new System.Windows.Forms.Label();
            this.btn_UdOkay = new System.Windows.Forms.Button();
            this.UserDetailView = new System.Windows.Forms.TabControl();
            this.RequestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestList)).BeginInit();
            this.UserDetailEdit.SuspendLayout();
            this.groupBox_UsrType.SuspendLayout();
            this.UserDetail.SuspendLayout();
            this.UserDetailView.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestList
            // 
            this.RequestList.Controls.Add(this.btn_RequestAccept);
            this.RequestList.Controls.Add(this.dataGridView_RequestList);
            this.RequestList.Location = new System.Drawing.Point(4, 28);
            this.RequestList.Name = "RequestList";
            this.RequestList.Padding = new System.Windows.Forms.Padding(3);
            this.RequestList.Size = new System.Drawing.Size(397, 243);
            this.RequestList.TabIndex = 2;
            this.RequestList.Text = "Request List";
            this.RequestList.UseVisualStyleBackColor = true;
            this.RequestList.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView_RequestList
            // 
            this.dataGridView_RequestList.AllowUserToAddRows = false;
            this.dataGridView_RequestList.AllowUserToDeleteRows = false;
            this.dataGridView_RequestList.AllowUserToOrderColumns = true;
            this.dataGridView_RequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RequestList.Location = new System.Drawing.Point(0, -2);
            this.dataGridView_RequestList.Name = "dataGridView_RequestList";
            this.dataGridView_RequestList.ReadOnly = true;
            this.dataGridView_RequestList.Size = new System.Drawing.Size(397, 203);
            this.dataGridView_RequestList.TabIndex = 2;
            // 
            // btn_RequestAccept
            // 
            this.btn_RequestAccept.Location = new System.Drawing.Point(140, 207);
            this.btn_RequestAccept.Name = "btn_RequestAccept";
            this.btn_RequestAccept.Size = new System.Drawing.Size(94, 30);
            this.btn_RequestAccept.TabIndex = 3;
            this.btn_RequestAccept.Text = "Accept";
            this.btn_RequestAccept.UseVisualStyleBackColor = true;
            // 
            // UserDetailEdit
            // 
            this.UserDetailEdit.Controls.Add(this.lbl_UDEUsrname);
            this.UserDetailEdit.Controls.Add(this.btn_UDEDone);
            this.UserDetailEdit.Controls.Add(this.btn_UDECancel);
            this.UserDetailEdit.Controls.Add(this.groupBox_UsrType);
            this.UserDetailEdit.Controls.Add(this.label4);
            this.UserDetailEdit.Controls.Add(this.label6);
            this.UserDetailEdit.Controls.Add(this.label7);
            this.UserDetailEdit.Controls.Add(this.lbl_UdEUsrId);
            this.UserDetailEdit.Location = new System.Drawing.Point(4, 28);
            this.UserDetailEdit.Name = "UserDetailEdit";
            this.UserDetailEdit.Padding = new System.Windows.Forms.Padding(3);
            this.UserDetailEdit.Size = new System.Drawing.Size(397, 243);
            this.UserDetailEdit.TabIndex = 1;
            this.UserDetailEdit.Text = "User\'s Detail Edit";
            this.UserDetailEdit.UseVisualStyleBackColor = true;
            this.UserDetailEdit.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbl_UdEUsrId
            // 
            this.lbl_UdEUsrId.AutoSize = true;
            this.lbl_UdEUsrId.Location = new System.Drawing.Point(123, 25);
            this.lbl_UdEUsrId.Name = "lbl_UdEUsrId";
            this.lbl_UdEUsrId.Size = new System.Drawing.Size(73, 19);
            this.lbl_UdEUsrId.TabIndex = 9;
            this.lbl_UdEUsrId.Text = "<UserId>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "User Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Type :";
            // 
            // groupBox_UsrType
            // 
            this.groupBox_UsrType.Controls.Add(this.rb_Tracker);
            this.groupBox_UsrType.Controls.Add(this.rb_Programmer);
            this.groupBox_UsrType.Controls.Add(this.rb_Admin);
            this.groupBox_UsrType.Location = new System.Drawing.Point(126, 73);
            this.groupBox_UsrType.Name = "groupBox_UsrType";
            this.groupBox_UsrType.Size = new System.Drawing.Size(131, 84);
            this.groupBox_UsrType.TabIndex = 13;
            this.groupBox_UsrType.TabStop = false;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(7, 11);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(72, 23);
            this.rb_Admin.TabIndex = 0;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // rb_Programmer
            // 
            this.rb_Programmer.AutoSize = true;
            this.rb_Programmer.Location = new System.Drawing.Point(6, 34);
            this.rb_Programmer.Name = "rb_Programmer";
            this.rb_Programmer.Size = new System.Drawing.Size(116, 23);
            this.rb_Programmer.TabIndex = 1;
            this.rb_Programmer.TabStop = true;
            this.rb_Programmer.Text = "Programmer";
            this.rb_Programmer.UseVisualStyleBackColor = true;
            // 
            // rb_Tracker
            // 
            this.rb_Tracker.AutoSize = true;
            this.rb_Tracker.Location = new System.Drawing.Point(7, 57);
            this.rb_Tracker.Name = "rb_Tracker";
            this.rb_Tracker.Size = new System.Drawing.Size(80, 23);
            this.rb_Tracker.TabIndex = 2;
            this.rb_Tracker.TabStop = true;
            this.rb_Tracker.Text = "Tracker";
            this.rb_Tracker.UseVisualStyleBackColor = true;
            // 
            // btn_UDECancel
            // 
            this.btn_UDECancel.Location = new System.Drawing.Point(69, 173);
            this.btn_UDECancel.Name = "btn_UDECancel";
            this.btn_UDECancel.Size = new System.Drawing.Size(75, 31);
            this.btn_UDECancel.TabIndex = 14;
            this.btn_UDECancel.Text = "Cancel";
            this.btn_UDECancel.UseVisualStyleBackColor = true;
            // 
            // btn_UDEDone
            // 
            this.btn_UDEDone.Location = new System.Drawing.Point(209, 173);
            this.btn_UDEDone.Name = "btn_UDEDone";
            this.btn_UDEDone.Size = new System.Drawing.Size(75, 31);
            this.btn_UDEDone.TabIndex = 15;
            this.btn_UDEDone.Text = "Done";
            this.btn_UDEDone.UseVisualStyleBackColor = true;
            // 
            // lbl_UDEUsrname
            // 
            this.lbl_UDEUsrname.AutoSize = true;
            this.lbl_UDEUsrname.Location = new System.Drawing.Point(123, 50);
            this.lbl_UDEUsrname.Name = "lbl_UDEUsrname";
            this.lbl_UDEUsrname.Size = new System.Drawing.Size(99, 19);
            this.lbl_UDEUsrname.TabIndex = 16;
            this.lbl_UDEUsrname.Text = "<UserName>";
            // 
            // UserDetail
            // 
            this.UserDetail.Controls.Add(this.btn_UdOkay);
            this.UserDetail.Controls.Add(this.lbl_UdNumBugReport);
            this.UserDetail.Controls.Add(this.lbl_UdUsrType);
            this.UserDetail.Controls.Add(this.lbl_UdUsrName);
            this.UserDetail.Controls.Add(this.lbl_UdUsrId);
            this.UserDetail.Controls.Add(this.btn_UdDeleteUsr);
            this.UserDetail.Controls.Add(this.label5);
            this.UserDetail.Controls.Add(this.label3);
            this.UserDetail.Controls.Add(this.label2);
            this.UserDetail.Controls.Add(this.label1);
            this.UserDetail.Location = new System.Drawing.Point(4, 28);
            this.UserDetail.Name = "UserDetail";
            this.UserDetail.Padding = new System.Windows.Forms.Padding(3);
            this.UserDetail.Size = new System.Drawing.Size(397, 243);
            this.UserDetail.TabIndex = 0;
            this.UserDetail.Text = "User\'s Detail View";
            this.UserDetail.UseVisualStyleBackColor = true;
            this.UserDetail.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numbers of Bug Reported :";
            // 
            // btn_UdDeleteUsr
            // 
            this.btn_UdDeleteUsr.BackColor = System.Drawing.Color.Red;
            this.btn_UdDeleteUsr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UdDeleteUsr.Location = new System.Drawing.Point(139, 152);
            this.btn_UdDeleteUsr.Name = "btn_UdDeleteUsr";
            this.btn_UdDeleteUsr.Size = new System.Drawing.Size(75, 33);
            this.btn_UdDeleteUsr.TabIndex = 16;
            this.btn_UdDeleteUsr.Text = "Delete User";
            this.btn_UdDeleteUsr.UseVisualStyleBackColor = false;
            // 
            // lbl_UdUsrId
            // 
            this.lbl_UdUsrId.AutoSize = true;
            this.lbl_UdUsrId.Location = new System.Drawing.Point(237, 29);
            this.lbl_UdUsrId.Name = "lbl_UdUsrId";
            this.lbl_UdUsrId.Size = new System.Drawing.Size(81, 19);
            this.lbl_UdUsrId.TabIndex = 17;
            this.lbl_UdUsrId.Text = "<User Id >";
            // 
            // lbl_UdUsrName
            // 
            this.lbl_UdUsrName.AutoSize = true;
            this.lbl_UdUsrName.Location = new System.Drawing.Point(237, 55);
            this.lbl_UdUsrName.Name = "lbl_UdUsrName";
            this.lbl_UdUsrName.Size = new System.Drawing.Size(103, 19);
            this.lbl_UdUsrName.TabIndex = 18;
            this.lbl_UdUsrName.Text = "<User Name>";
            // 
            // lbl_UdUsrType
            // 
            this.lbl_UdUsrType.AutoSize = true;
            this.lbl_UdUsrType.Location = new System.Drawing.Point(237, 82);
            this.lbl_UdUsrType.Name = "lbl_UdUsrType";
            this.lbl_UdUsrType.Size = new System.Drawing.Size(97, 19);
            this.lbl_UdUsrType.TabIndex = 19;
            this.lbl_UdUsrType.Text = "<User Type>";
            // 
            // lbl_UdNumBugReport
            // 
            this.lbl_UdNumBugReport.AutoSize = true;
            this.lbl_UdNumBugReport.Location = new System.Drawing.Point(237, 106);
            this.lbl_UdNumBugReport.Name = "lbl_UdNumBugReport";
            this.lbl_UdNumBugReport.Size = new System.Drawing.Size(91, 19);
            this.lbl_UdNumBugReport.TabIndex = 20;
            this.lbl_UdNumBugReport.Text = "<Numbers>";
            // 
            // btn_UdOkay
            // 
            this.btn_UdOkay.BackColor = System.Drawing.Color.Green;
            this.btn_UdOkay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UdOkay.Location = new System.Drawing.Point(253, 152);
            this.btn_UdOkay.Name = "btn_UdOkay";
            this.btn_UdOkay.Size = new System.Drawing.Size(75, 33);
            this.btn_UdOkay.TabIndex = 21;
            this.btn_UdOkay.Text = "Okay";
            this.btn_UdOkay.UseVisualStyleBackColor = false;
            // 
            // UserDetailView
            // 
            this.UserDetailView.Controls.Add(this.UserDetail);
            this.UserDetailView.Controls.Add(this.UserDetailEdit);
            this.UserDetailView.Controls.Add(this.RequestList);
            this.UserDetailView.Location = new System.Drawing.Point(12, 12);
            this.UserDetailView.Name = "UserDetailView";
            this.UserDetailView.SelectedIndex = 0;
            this.UserDetailView.Size = new System.Drawing.Size(405, 275);
            this.UserDetailView.TabIndex = 0;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(436, 306);
            this.Controls.Add(this.UserDetailView);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Panel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.RequestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestList)).EndInit();
            this.UserDetailEdit.ResumeLayout(false);
            this.UserDetailEdit.PerformLayout();
            this.groupBox_UsrType.ResumeLayout(false);
            this.groupBox_UsrType.PerformLayout();
            this.UserDetail.ResumeLayout(false);
            this.UserDetail.PerformLayout();
            this.UserDetailView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage RequestList;
        private System.Windows.Forms.Button btn_RequestAccept;
        private System.Windows.Forms.DataGridView dataGridView_RequestList;
        private System.Windows.Forms.TabPage UserDetailEdit;
        public System.Windows.Forms.Label lbl_UDEUsrname;
        private System.Windows.Forms.Button btn_UDEDone;
        private System.Windows.Forms.Button btn_UDECancel;
        private System.Windows.Forms.GroupBox groupBox_UsrType;
        private System.Windows.Forms.RadioButton rb_Tracker;
        private System.Windows.Forms.RadioButton rb_Programmer;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_UdEUsrId;
        private System.Windows.Forms.TabPage UserDetail;
        private System.Windows.Forms.Button btn_UdOkay;
        private System.Windows.Forms.Label lbl_UdNumBugReport;
        private System.Windows.Forms.Label lbl_UdUsrType;
        private System.Windows.Forms.Label lbl_UdUsrName;
        public System.Windows.Forms.Label lbl_UdUsrId;
        private System.Windows.Forms.Button btn_UdDeleteUsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl UserDetailView;

    }
}