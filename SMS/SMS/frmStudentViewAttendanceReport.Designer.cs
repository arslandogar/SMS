namespace SMS
{
    partial class frmStudentViewAttendanceReport
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
            this.panel = new System.Windows.Forms.Panel();
            this.btSendMessages = new System.Windows.Forms.Button();
            this.btViewBooks = new System.Windows.Forms.Button();
            this.btAttendanceReports = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btSendMessages);
            this.panel.Controls.Add(this.btViewBooks);
            this.panel.Controls.Add(this.btAttendanceReports);
            this.panel.Controls.Add(this.btLogout);
            this.panel.Controls.Add(this.btnProfile);
            this.panel.Location = new System.Drawing.Point(0, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 59);
            this.panel.TabIndex = 7;
            // 
            // btSendMessages
            // 
            this.btSendMessages.Location = new System.Drawing.Point(501, 3);
            this.btSendMessages.Name = "btSendMessages";
            this.btSendMessages.Size = new System.Drawing.Size(160, 51);
            this.btSendMessages.TabIndex = 7;
            this.btSendMessages.Text = "Send Messages";
            this.btSendMessages.UseVisualStyleBackColor = true;
            this.btSendMessages.Click += new System.EventHandler(this.btSendMessages_Click);
            // 
            // btViewBooks
            // 
            this.btViewBooks.Location = new System.Drawing.Point(335, 3);
            this.btViewBooks.Name = "btViewBooks";
            this.btViewBooks.Size = new System.Drawing.Size(160, 51);
            this.btViewBooks.TabIndex = 6;
            this.btViewBooks.Text = "View Books";
            this.btViewBooks.UseVisualStyleBackColor = true;
            this.btViewBooks.Click += new System.EventHandler(this.btViewBooks_Click);
            // 
            // btAttendanceReports
            // 
            this.btAttendanceReports.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAttendanceReports.Location = new System.Drawing.Point(169, 3);
            this.btAttendanceReports.Name = "btAttendanceReports";
            this.btAttendanceReports.Size = new System.Drawing.Size(160, 51);
            this.btAttendanceReports.TabIndex = 5;
            this.btAttendanceReports.Text = "View Attendance Report";
            this.btAttendanceReports.UseVisualStyleBackColor = false;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(667, 3);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(160, 51);
            this.btLogout.TabIndex = 3;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.Control;
            this.btnProfile.Location = new System.Drawing.Point(3, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(160, 51);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(148, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(436, 150);
            this.dataGridView.TabIndex = 8;
            // 
            // frmStudentViewAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmStudentViewAttendanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - View Attendance Report";
            this.Load += new System.EventHandler(this.frmStudentViewAttendanceReport_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btSendMessages;
        private System.Windows.Forms.Button btViewBooks;
        private System.Windows.Forms.Button btAttendanceReports;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}