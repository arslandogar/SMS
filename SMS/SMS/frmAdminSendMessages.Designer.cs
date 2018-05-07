namespace SMS
{
    partial class frmAdminSendMessages
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.cmbSelectTeacher = new System.Windows.Forms.ComboBox();
            this.btSendToTeacher = new System.Windows.Forms.Button();
            this.llbReadMessages = new System.Windows.Forms.LinkLabel();
            this.cmbSelectStudent = new System.Windows.Forms.ComboBox();
            this.cmbSelectParent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInbox = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btSendToStudent = new System.Windows.Forms.Button();
            this.btSendToParent = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panelInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.btnSendMessages.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendMessages.Location = new System.Drawing.Point(3, 422);
            this.btnSendMessages.Name = "btnSendMessages";
            this.btnSendMessages.Size = new System.Drawing.Size(192, 35);
            this.btnSendMessages.TabIndex = 21;
            this.btnSendMessages.Text = "Send Messages";
            this.btnSendMessages.UseVisualStyleBackColor = false;
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
            this.btnAssignCourse.Click += new System.EventHandler(this.btnAssignCourse_Click);
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
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarkAttendance.Location = new System.Drawing.Point(3, 381);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(192, 35);
            this.btnMarkAttendance.TabIndex = 20;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
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
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(264, 34);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(172, 96);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = "";
            // 
            // cmbSelectTeacher
            // 
            this.cmbSelectTeacher.FormattingEnabled = true;
            this.cmbSelectTeacher.Location = new System.Drawing.Point(264, 174);
            this.cmbSelectTeacher.Name = "cmbSelectTeacher";
            this.cmbSelectTeacher.Size = new System.Drawing.Size(106, 21);
            this.cmbSelectTeacher.TabIndex = 9;
            // 
            // btSendToTeacher
            // 
            this.btSendToTeacher.Location = new System.Drawing.Point(279, 201);
            this.btSendToTeacher.Name = "btSendToTeacher";
            this.btSendToTeacher.Size = new System.Drawing.Size(75, 23);
            this.btSendToTeacher.TabIndex = 10;
            this.btSendToTeacher.Text = "Send";
            this.btSendToTeacher.UseVisualStyleBackColor = true;
            this.btSendToTeacher.Click += new System.EventHandler(this.btSend_Click);
            // 
            // llbReadMessages
            // 
            this.llbReadMessages.AutoSize = true;
            this.llbReadMessages.Location = new System.Drawing.Point(738, 489);
            this.llbReadMessages.Name = "llbReadMessages";
            this.llbReadMessages.Size = new System.Drawing.Size(84, 13);
            this.llbReadMessages.TabIndex = 11;
            this.llbReadMessages.TabStop = true;
            this.llbReadMessages.Text = "Read Messages";
            this.llbReadMessages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbReadMessages_LinkClicked);
            // 
            // cmbSelectStudent
            // 
            this.cmbSelectStudent.FormattingEnabled = true;
            this.cmbSelectStudent.Location = new System.Drawing.Point(432, 174);
            this.cmbSelectStudent.Name = "cmbSelectStudent";
            this.cmbSelectStudent.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectStudent.TabIndex = 12;
            // 
            // cmbSelectParent
            // 
            this.cmbSelectParent.FormattingEnabled = true;
            this.cmbSelectParent.Location = new System.Drawing.Point(596, 174);
            this.cmbSelectParent.Name = "cmbSelectParent";
            this.cmbSelectParent.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectParent.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Message a Teacher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Message a Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Message a Parent:";
            // 
            // panelInbox
            // 
            this.panelInbox.Controls.Add(this.dataGridView);
            this.panelInbox.Location = new System.Drawing.Point(230, 259);
            this.panelInbox.Name = "panelInbox";
            this.panelInbox.Size = new System.Drawing.Size(592, 227);
            this.panelInbox.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(558, 205);
            this.dataGridView.TabIndex = 0;
            // 
            // btSendToStudent
            // 
            this.btSendToStudent.Location = new System.Drawing.Point(456, 201);
            this.btSendToStudent.Name = "btSendToStudent";
            this.btSendToStudent.Size = new System.Drawing.Size(75, 23);
            this.btSendToStudent.TabIndex = 18;
            this.btSendToStudent.Text = "Send";
            this.btSendToStudent.UseVisualStyleBackColor = true;
            this.btSendToStudent.Click += new System.EventHandler(this.btSendToStudent_Click);
            // 
            // btSendToParent
            // 
            this.btSendToParent.Location = new System.Drawing.Point(614, 201);
            this.btSendToParent.Name = "btSendToParent";
            this.btSendToParent.Size = new System.Drawing.Size(75, 23);
            this.btSendToParent.TabIndex = 19;
            this.btSendToParent.Text = "Send";
            this.btSendToParent.UseVisualStyleBackColor = true;
            this.btSendToParent.Click += new System.EventHandler(this.btSendToParent_Click);
            // 
            // frmAdminSendMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btSendToParent);
            this.Controls.Add(this.btSendToStudent);
            this.Controls.Add(this.panelInbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectParent);
            this.Controls.Add(this.cmbSelectStudent);
            this.Controls.Add(this.llbReadMessages);
            this.Controls.Add(this.btSendToTeacher);
            this.Controls.Add(this.cmbSelectTeacher);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmAdminSendMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Send Messages";
            this.Load += new System.EventHandler(this.frmAdminSendMessages_Load);
            this.panel.ResumeLayout(false);
            this.panelInbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox cmbSelectTeacher;
        private System.Windows.Forms.Button btSendToTeacher;
        private System.Windows.Forms.LinkLabel llbReadMessages;
        private System.Windows.Forms.ComboBox cmbSelectStudent;
        private System.Windows.Forms.ComboBox cmbSelectParent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btSendToStudent;
        private System.Windows.Forms.Button btSendToParent;
    }
}