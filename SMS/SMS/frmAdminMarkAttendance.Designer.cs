namespace SMS
{
    partial class frmAdminMarkAttendance
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSendMessages = new System.Windows.Forms.Button();
            this.btnViewAttendances = new System.Windows.Forms.Button();
            this.btnAddLibrarian = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnAssignCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnViewTeachers = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cmbSelectEmployee = new System.Windows.Forms.ComboBox();
            this.bMarkAttendance = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnLogout);
            this.panel.Controls.Add(this.btnSendMessages);
            this.panel.Controls.Add(this.btnViewAttendances);
            this.panel.Controls.Add(this.btnAddLibrarian);
            this.panel.Controls.Add(this.btnViewCourses);
            this.panel.Controls.Add(this.btnAssignCourse);
            this.panel.Controls.Add(this.btnAddCourse);
            this.panel.Controls.Add(this.btnViewTeachers);
            this.panel.Controls.Add(this.btnAddTeacher);
            this.panel.Controls.Add(this.btnMarkAttendance);
            this.panel.Controls.Add(this.btnViewStudents);
            this.panel.Controls.Add(this.btnAddStudent);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 511);
            this.panel.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 463);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 35);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSendMessages
            // 
            this.btnSendMessages.Location = new System.Drawing.Point(3, 422);
            this.btnSendMessages.Name = "btnSendMessages";
            this.btnSendMessages.Size = new System.Drawing.Size(192, 35);
            this.btnSendMessages.TabIndex = 21;
            this.btnSendMessages.Text = "Send Messages";
            this.btnSendMessages.UseVisualStyleBackColor = true;
            // 
            // btnViewAttendances
            // 
            this.btnViewAttendances.Location = new System.Drawing.Point(3, 340);
            this.btnViewAttendances.Name = "btnViewAttendances";
            this.btnViewAttendances.Size = new System.Drawing.Size(192, 35);
            this.btnViewAttendances.TabIndex = 19;
            this.btnViewAttendances.Text = "View Attenance Reports";
            this.btnViewAttendances.UseVisualStyleBackColor = true;
            this.btnViewAttendances.Click += new System.EventHandler(this.btnViewAttendances_Click);
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddLibrarian.Location = new System.Drawing.Point(3, 299);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(192, 35);
            this.btnAddLibrarian.TabIndex = 18;
            this.btnAddLibrarian.Text = "Add Librarian";
            this.btnAddLibrarian.UseVisualStyleBackColor = true;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(3, 258);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(192, 35);
            this.btnViewCourses.TabIndex = 17;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.Location = new System.Drawing.Point(3, 217);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.Size = new System.Drawing.Size(192, 35);
            this.btnAssignCourse.TabIndex = 16;
            this.btnAssignCourse.Text = "Assign Course";
            this.btnAssignCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(3, 176);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(192, 35);
            this.btnAddCourse.TabIndex = 15;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnViewTeachers
            // 
            this.btnViewTeachers.Location = new System.Drawing.Point(3, 135);
            this.btnViewTeachers.Name = "btnViewTeachers";
            this.btnViewTeachers.Size = new System.Drawing.Size(192, 35);
            this.btnViewTeachers.TabIndex = 14;
            this.btnViewTeachers.Text = "View Teachers";
            this.btnViewTeachers.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(3, 94);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(192, 35);
            this.btnAddTeacher.TabIndex = 13;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMarkAttendance.Location = new System.Drawing.Point(3, 381);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(192, 35);
            this.btnMarkAttendance.TabIndex = 20;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = false;
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(3, 53);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(192, 35);
            this.btnViewStudents.TabIndex = 12;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(3, 11);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(192, 36);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // cmbSelectEmployee
            // 
            this.cmbSelectEmployee.FormattingEnabled = true;
            this.cmbSelectEmployee.Location = new System.Drawing.Point(469, 95);
            this.cmbSelectEmployee.Name = "cmbSelectEmployee";
            this.cmbSelectEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectEmployee.TabIndex = 0;
            // 
            // bMarkAttendance
            // 
            this.bMarkAttendance.Location = new System.Drawing.Point(487, 224);
            this.bMarkAttendance.Name = "bMarkAttendance";
            this.bMarkAttendance.Size = new System.Drawing.Size(103, 23);
            this.bMarkAttendance.TabIndex = 2;
            this.bMarkAttendance.Text = "Mark Attendance";
            this.bMarkAttendance.UseVisualStyleBackColor = true;
            this.bMarkAttendance.Click += new System.EventHandler(this.bMarkAttendance_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(469, 177);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.Value = new System.DateTime(2018, 5, 6, 0, 0, 0, 0);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave"});
            this.cmbStatus.Location = new System.Drawing.Point(469, 136);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // frmAdminMarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.bMarkAttendance);
            this.Controls.Add(this.cmbSelectEmployee);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmAdminMarkAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Mark Attendance";
            this.Load += new System.EventHandler(this.frmAdminMarkAttendance_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSendMessages;
        private System.Windows.Forms.Button btnViewAttendances;
        private System.Windows.Forms.Button btnAddLibrarian;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnAssignCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnViewTeachers;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.ComboBox cmbSelectEmployee;
        private System.Windows.Forms.Button bMarkAttendance;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}