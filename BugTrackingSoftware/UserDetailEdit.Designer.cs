namespace BugTrackingSoftware
{
    partial class NewUser
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
            this.UserRequestList = new System.Windows.Forms.GroupBox();
            this.lbl_UDEUsrname = new System.Windows.Forms.Label();
            this.btn_UDEDone = new System.Windows.Forms.Button();
            this.btn_UDECancel = new System.Windows.Forms.Button();
            this.groupBox_UsrType = new System.Windows.Forms.GroupBox();
            this.rb_Tracker = new System.Windows.Forms.RadioButton();
            this.rb_Programmer = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_UdEUsrId = new System.Windows.Forms.Label();
            this.UserRequestList.SuspendLayout();
            this.groupBox_UsrType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.UserRequestList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UserRequestList.Controls.Add(this.lbl_UDEUsrname);
            this.UserRequestList.Controls.Add(this.btn_UDEDone);
            this.UserRequestList.Controls.Add(this.btn_UDECancel);
            this.UserRequestList.Controls.Add(this.groupBox_UsrType);
            this.UserRequestList.Controls.Add(this.label3);
            this.UserRequestList.Controls.Add(this.label2);
            this.UserRequestList.Controls.Add(this.label1);
            this.UserRequestList.Controls.Add(this.lbl_UdEUsrId);
            this.UserRequestList.Location = new System.Drawing.Point(12, 12);
            this.UserRequestList.Name = "groupBox1";
            this.UserRequestList.Size = new System.Drawing.Size(352, 284);
            this.UserRequestList.TabIndex = 0;
            this.UserRequestList.TabStop = false;
            this.UserRequestList.Text = "User\'s Detail Edit";
            // 
            // lbl_UDEUsrname
            // 
            this.lbl_UDEUsrname.AutoSize = true;
            this.lbl_UDEUsrname.Location = new System.Drawing.Point(161, 69);
            this.lbl_UDEUsrname.Name = "lbl_UDEUsrname";
            this.lbl_UDEUsrname.Size = new System.Drawing.Size(99, 19);
            this.lbl_UDEUsrname.TabIndex = 16;
            this.lbl_UDEUsrname.Text = "<UserName>";
            // 
            // btn_UDEDone
            // 
            this.btn_UDEDone.Location = new System.Drawing.Point(208, 192);
            this.btn_UDEDone.Name = "btn_UDEDone";
            this.btn_UDEDone.Size = new System.Drawing.Size(78, 30);
            this.btn_UDEDone.TabIndex = 15;
            this.btn_UDEDone.Text = "Done";
            this.btn_UDEDone.UseVisualStyleBackColor = true;
            // 
            // btn_UDECancel
            // 
            this.btn_UDECancel.Location = new System.Drawing.Point(107, 192);
            this.btn_UDECancel.Name = "btn_UDECancel";
            this.btn_UDECancel.Size = new System.Drawing.Size(73, 30);
            this.btn_UDECancel.TabIndex = 14;
            this.btn_UDECancel.Text = "Cancel";
            this.btn_UDECancel.UseVisualStyleBackColor = true;
            // 
            // groupBox_UsrType
            // 
            this.groupBox_UsrType.Controls.Add(this.rb_Tracker);
            this.groupBox_UsrType.Controls.Add(this.rb_Programmer);
            this.groupBox_UsrType.Controls.Add(this.rb_Admin);
            this.groupBox_UsrType.Location = new System.Drawing.Point(164, 92);
            this.groupBox_UsrType.Name = "groupBox_UsrType";
            this.groupBox_UsrType.Size = new System.Drawing.Size(122, 84);
            this.groupBox_UsrType.TabIndex = 13;
            this.groupBox_UsrType.TabStop = false;
            // 
            // rb_Tracker
            // 
            this.rb_Tracker.AutoSize = true;
            this.rb_Tracker.Location = new System.Drawing.Point(7, 57);
            this.rb_Tracker.Name = "rb_Tracker";
            this.rb_Tracker.Size = new System.Drawing.Size(70, 23);
            this.rb_Tracker.TabIndex = 2;
            this.rb_Tracker.TabStop = true;
            this.rb_Tracker.Text = "Tester";
            this.rb_Tracker.UseVisualStyleBackColor = true;
            // 
            // rb_Programmer
            // 
            this.rb_Programmer.AutoSize = true;
            this.rb_Programmer.Location = new System.Drawing.Point(6, 34);
            this.rb_Programmer.Name = "rb_Programmer";
            this.rb_Programmer.Size = new System.Drawing.Size(99, 23);
            this.rb_Programmer.TabIndex = 1;
            this.rb_Programmer.TabStop = true;
            this.rb_Programmer.Text = "Developer";
            this.rb_Programmer.UseVisualStyleBackColor = true;
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
            this.rb_Admin.CheckedChanged += new System.EventHandler(this.rb_Admin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Id :";
            // 
            // lbl_UdEUsrId
            // 
            this.lbl_UdEUsrId.AutoSize = true;
            this.lbl_UdEUsrId.Location = new System.Drawing.Point(161, 44);
            this.lbl_UdEUsrId.Name = "lbl_UdEUsrId";
            this.lbl_UdEUsrId.Size = new System.Drawing.Size(73, 19);
            this.lbl_UdEUsrId.TabIndex = 9;
            this.lbl_UdEUsrId.Text = "<UserId>";
            // 
            // UserDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(376, 308);
            this.Controls.Add(this.UserRequestList);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserDetailEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User\'s Detail Edit";
            this.Load += new System.EventHandler(this.New_User_Load);
            this.UserRequestList.ResumeLayout(false);
            this.UserRequestList.PerformLayout();
            this.groupBox_UsrType.ResumeLayout(false);
            this.groupBox_UsrType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbl_UDEUsrname;
        private System.Windows.Forms.Button btn_UDEDone;
        private System.Windows.Forms.Button btn_UDECancel;
        private System.Windows.Forms.GroupBox groupBox_UsrType;
        private System.Windows.Forms.RadioButton rb_Tracker;
        private System.Windows.Forms.RadioButton rb_Programmer;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_UdEUsrId;


    }
}