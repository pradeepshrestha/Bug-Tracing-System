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
            this.btn_RequestAccept = new System.Windows.Forms.Button();
            this.dataGridView_RequestList = new System.Windows.Forms.DataGridView();
            this.UserRequestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // UserRequestList
            // 
            this.UserRequestList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UserRequestList.Controls.Add(this.btn_RequestAccept);
            this.UserRequestList.Controls.Add(this.dataGridView_RequestList);
            this.UserRequestList.Location = new System.Drawing.Point(12, 12);
            this.UserRequestList.Name = "UserRequestList";
            this.UserRequestList.Size = new System.Drawing.Size(364, 310);
            this.UserRequestList.TabIndex = 0;
            this.UserRequestList.TabStop = false;
            this.UserRequestList.Text = "groupBox1";
            // 
            // btn_RequestAccept
            // 
            this.btn_RequestAccept.Location = new System.Drawing.Point(128, 269);
            this.btn_RequestAccept.Name = "btn_RequestAccept";
            this.btn_RequestAccept.Size = new System.Drawing.Size(73, 36);
            this.btn_RequestAccept.TabIndex = 3;
            this.btn_RequestAccept.Text = "Accept";
            this.btn_RequestAccept.UseVisualStyleBackColor = true;
            // 
            // dataGridView_RequestList
            // 
            this.dataGridView_RequestList.AllowUserToAddRows = false;
            this.dataGridView_RequestList.AllowUserToDeleteRows = false;
            this.dataGridView_RequestList.AllowUserToOrderColumns = true;
            this.dataGridView_RequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RequestList.Location = new System.Drawing.Point(6, 25);
            this.dataGridView_RequestList.Name = "dataGridView_RequestList";
            this.dataGridView_RequestList.ReadOnly = true;
            this.dataGridView_RequestList.Size = new System.Drawing.Size(352, 238);
            this.dataGridView_RequestList.TabIndex = 2;
            // 
            // RequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(390, 336);
            this.Controls.Add(this.UserRequestList);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RequestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Lists";
            this.Load += new System.EventHandler(this.New_User_Load);
            this.UserRequestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserRequestList;
        private System.Windows.Forms.Button btn_RequestAccept;
        private System.Windows.Forms.DataGridView dataGridView_RequestList;


    }
}