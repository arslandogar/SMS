namespace SMS
{
    partial class frmTeacherCourses
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
            this.btAttendanceReport = new System.Windows.Forms.Button();
            this.btMarkAttendance = new System.Windows.Forms.Button();
            this.btCourses = new System.Windows.Forms.Button();
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
            this.panel.Controls.Add(this.btAttendanceReport);
            this.panel.Controls.Add(this.btMarkAttendance);
            this.panel.Controls.Add(this.btCourses);
            this.panel.Controls.Add(this.btLogout);
            this.panel.Controls.Add(this.btnProfile);
            this.panel.Location = new System.Drawing.Point(0, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 59);
            this.panel.TabIndex = 7;
            // 
            // btSendMessages
            // 
            this.btSendMessages.Location = new System.Drawing.Point(554, 3);
            this.btSendMessages.Name = "btSendMessages";
            this.btSendMessages.Size = new System.Drawing.Size(132, 51);
            this.btSendMessages.TabIndex = 8;
            this.btSendMessages.Text = "Send Messages";
            this.btSendMessages.UseVisualStyleBackColor = true;
            this.btSendMessages.Click += new System.EventHandler(this.btSendMessages_Click);
            // 
            // btAttendanceReport
            // 
            this.btAttendanceReport.BackColor = System.Drawing.SystemColors.Control;
            this.btAttendanceReport.Location = new System.Drawing.Point(417, 3);
            this.btAttendanceReport.Name = "btAttendanceReport";
            this.btAttendanceReport.Size = new System.Drawing.Size(132, 51);
            this.btAttendanceReport.TabIndex = 7;
            this.btAttendanceReport.Text = "Attendance Report";
            this.btAttendanceReport.UseVisualStyleBackColor = true;
            this.btAttendanceReport.Click += new System.EventHandler(this.btAttendanceReport_Click);
            // 
            // btMarkAttendance
            // 
            this.btMarkAttendance.BackColor = System.Drawing.SystemColors.Control;
            this.btMarkAttendance.Location = new System.Drawing.Point(279, 3);
            this.btMarkAttendance.Name = "btMarkAttendance";
            this.btMarkAttendance.Size = new System.Drawing.Size(132, 51);
            this.btMarkAttendance.TabIndex = 6;
            this.btMarkAttendance.Text = "Mark Attendance";
            this.btMarkAttendance.UseVisualStyleBackColor = true;
            this.btMarkAttendance.Click += new System.EventHandler(this.btMarkAttendance_Click);
            // 
            // btCourses
            // 
            this.btCourses.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCourses.Location = new System.Drawing.Point(141, 3);
            this.btCourses.Name = "btCourses";
            this.btCourses.Size = new System.Drawing.Size(132, 51);
            this.btCourses.TabIndex = 5;
            this.btCourses.Text = "Courses";
            this.btCourses.UseVisualStyleBackColor = false;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(692, 3);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(132, 51);
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
            this.btnProfile.Size = new System.Drawing.Size(132, 51);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(280, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(230, 150);
            this.dataGridView.TabIndex = 9;
            // 
            // frmTeacherCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmTeacherCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Courses";
            this.Load += new System.EventHandler(this.frmTeacherCourses_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btAttendanceReport;
        private System.Windows.Forms.Button btMarkAttendance;
        private System.Windows.Forms.Button btCourses;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btSendMessages;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}