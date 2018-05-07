namespace SMS
{
    partial class frmTeacherMarkAttendance
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
            this.cmbSelectStudent = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btMark = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel.SuspendLayout();
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
            this.btAttendanceReport.Location = new System.Drawing.Point(417, 3);
            this.btAttendanceReport.Name = "btAttendanceReport";
            this.btAttendanceReport.Size = new System.Drawing.Size(132, 51);
            this.btAttendanceReport.TabIndex = 7;
            this.btAttendanceReport.Text = "Attendance Report";
            this.btAttendanceReport.UseVisualStyleBackColor = true;
            // 
            // btMarkAttendance
            // 
            this.btMarkAttendance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btMarkAttendance.Location = new System.Drawing.Point(279, 3);
            this.btMarkAttendance.Name = "btMarkAttendance";
            this.btMarkAttendance.Size = new System.Drawing.Size(132, 51);
            this.btMarkAttendance.TabIndex = 6;
            this.btMarkAttendance.Text = "Mark Attendance";
            this.btMarkAttendance.UseVisualStyleBackColor = false;
            // 
            // btCourses
            // 
            this.btCourses.Location = new System.Drawing.Point(141, 3);
            this.btCourses.Name = "btCourses";
            this.btCourses.Size = new System.Drawing.Size(132, 51);
            this.btCourses.TabIndex = 5;
            this.btCourses.Text = "Courses";
            this.btCourses.UseVisualStyleBackColor = true;
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
            // cmbSelectStudent
            // 
            this.cmbSelectStudent.FormattingEnabled = true;
            this.cmbSelectStudent.Location = new System.Drawing.Point(359, 146);
            this.cmbSelectStudent.Name = "cmbSelectStudent";
            this.cmbSelectStudent.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectStudent.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave"});
            this.cmbStatus.Location = new System.Drawing.Point(359, 194);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // btMark
            // 
            this.btMark.Location = new System.Drawing.Point(359, 279);
            this.btMark.Name = "btMark";
            this.btMark.Size = new System.Drawing.Size(101, 23);
            this.btMark.TabIndex = 10;
            this.btMark.Text = "Mark Attendance";
            this.btMark.UseVisualStyleBackColor = true;
            this.btMark.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // frmTeacherMarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btMark);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbSelectStudent);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmTeacherMarkAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Mark Attendance";
            this.Load += new System.EventHandler(this.frmTeacherMarkAttendance_Load);
            this.panel.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbSelectStudent;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btMark;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}