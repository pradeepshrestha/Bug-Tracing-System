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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.UserDetail = new System.Windows.Forms.GroupBox();
            this.btn_UdOkay = new System.Windows.Forms.Button();
            this.lbl_UdNumBugReport = new System.Windows.Forms.Label();
            this.lbl_UdUsrType = new System.Windows.Forms.Label();
            this.lbl_UdUsrName = new System.Windows.Forms.Label();
            this.lbl_UdUsrId = new System.Windows.Forms.Label();
            this.btn_UdDeleteUsr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDetail
            // 
            this.UserDetail.BackColor = System.Drawing.SystemColors.Info;
            this.UserDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserDetail.BackgroundImage")));
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
            this.UserDetail.Location = new System.Drawing.Point(13, 18);
            this.UserDetail.Margin = new System.Windows.Forms.Padding(4);
            this.UserDetail.Name = "UserDetail";
            this.UserDetail.Padding = new System.Windows.Forms.Padding(4);
            this.UserDetail.Size = new System.Drawing.Size(387, 280);
            this.UserDetail.TabIndex = 0;
            this.UserDetail.TabStop = false;
            this.UserDetail.Text = "User\'s Detail View";
            // 
            // btn_UdOkay
            // 
            this.btn_UdOkay.BackColor = System.Drawing.Color.Green;
            this.btn_UdOkay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UdOkay.Location = new System.Drawing.Point(244, 173);
            this.btn_UdOkay.Name = "btn_UdOkay";
            this.btn_UdOkay.Size = new System.Drawing.Size(74, 38);
            this.btn_UdOkay.TabIndex = 21;
            this.btn_UdOkay.Text = "Okay";
            this.btn_UdOkay.UseVisualStyleBackColor = false;
            // 
            // lbl_UdNumBugReport
            // 
            this.lbl_UdNumBugReport.AutoSize = true;
            this.lbl_UdNumBugReport.Location = new System.Drawing.Point(218, 127);
            this.lbl_UdNumBugReport.Name = "lbl_UdNumBugReport";
            this.lbl_UdNumBugReport.Size = new System.Drawing.Size(91, 19);
            this.lbl_UdNumBugReport.TabIndex = 20;
            this.lbl_UdNumBugReport.Text = "<Numbers>";
            // 
            // lbl_UdUsrType
            // 
            this.lbl_UdUsrType.AutoSize = true;
            this.lbl_UdUsrType.Location = new System.Drawing.Point(218, 103);
            this.lbl_UdUsrType.Name = "lbl_UdUsrType";
            this.lbl_UdUsrType.Size = new System.Drawing.Size(97, 19);
            this.lbl_UdUsrType.TabIndex = 19;
            this.lbl_UdUsrType.Text = "<User Type>";
            // 
            // lbl_UdUsrName
            // 
            this.lbl_UdUsrName.AutoSize = true;
            this.lbl_UdUsrName.Location = new System.Drawing.Point(218, 76);
            this.lbl_UdUsrName.Name = "lbl_UdUsrName";
            this.lbl_UdUsrName.Size = new System.Drawing.Size(103, 19);
            this.lbl_UdUsrName.TabIndex = 18;
            this.lbl_UdUsrName.Text = "<User Name>";
            // 
            // lbl_UdUsrId
            // 
            this.lbl_UdUsrId.AutoSize = true;
            this.lbl_UdUsrId.Location = new System.Drawing.Point(218, 50);
            this.lbl_UdUsrId.Name = "lbl_UdUsrId";
            this.lbl_UdUsrId.Size = new System.Drawing.Size(81, 19);
            this.lbl_UdUsrId.TabIndex = 17;
            this.lbl_UdUsrId.Text = "<User Id >";
            // 
            // btn_UdDeleteUsr
            // 
            this.btn_UdDeleteUsr.BackColor = System.Drawing.Color.Red;
            this.btn_UdDeleteUsr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UdDeleteUsr.Location = new System.Drawing.Point(127, 173);
            this.btn_UdDeleteUsr.Name = "btn_UdDeleteUsr";
            this.btn_UdDeleteUsr.Size = new System.Drawing.Size(83, 38);
            this.btn_UdDeleteUsr.TabIndex = 16;
            this.btn_UdDeleteUsr.Text = "Delete User";
            this.btn_UdDeleteUsr.UseVisualStyleBackColor = false;
            this.btn_UdDeleteUsr.Click += new System.EventHandler(this.btn_UdDeleteUsr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numbers of Bug Reported :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Id :";
            // 
            // UserDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(419, 316);
            this.Controls.Add(this.UserDetail);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserDetailEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User\'s Detail";
            this.Load += new System.EventHandler(this.New_User_Load);
            this.UserDetail.ResumeLayout(false);
            this.UserDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserDetail;
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


    }
}