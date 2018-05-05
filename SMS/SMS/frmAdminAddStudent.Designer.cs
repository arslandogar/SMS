namespace SMS
{
    partial class frmAdminAddStudent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.txtParentCnic = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtParentContact = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSelectCourses = new System.Windows.Forms.ComboBox();
            this.bAddCourse = new System.Windows.Forms.Button();
            this.bAddStudent = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.panel.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 463);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 35);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSendMessages
            // 
            this.btnSendMessages.Location = new System.Drawing.Point(3, 422);
            this.btnSendMessages.Name = "btnSendMessages";
            this.btnSendMessages.Size = new System.Drawing.Size(192, 35);
            this.btnSendMessages.TabIndex = 25;
            this.btnSendMessages.Text = "Send Messages";
            this.btnSendMessages.UseVisualStyleBackColor = true;
            // 
            // btnViewAttendances
            // 
            this.btnViewAttendances.Location = new System.Drawing.Point(3, 340);
            this.btnViewAttendances.Name = "btnViewAttendances";
            this.btnViewAttendances.Size = new System.Drawing.Size(192, 35);
            this.btnViewAttendances.TabIndex = 23;
            this.btnViewAttendances.Text = "View Attenance Reports";
            this.btnViewAttendances.UseVisualStyleBackColor = true;
            this.btnViewAttendances.Click += new System.EventHandler(this.btnViewAttendances_Click);
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.Location = new System.Drawing.Point(3, 299);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(192, 35);
            this.btnAddLibrarian.TabIndex = 22;
            this.btnAddLibrarian.Text = "Add Librarian";
            this.btnAddLibrarian.UseVisualStyleBackColor = true;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(3, 258);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(192, 35);
            this.btnViewCourses.TabIndex = 21;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.Location = new System.Drawing.Point(3, 217);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.Size = new System.Drawing.Size(192, 35);
            this.btnAssignCourse.TabIndex = 20;
            this.btnAssignCourse.Text = "Assign Course";
            this.btnAssignCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(3, 176);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(192, 35);
            this.btnAddCourse.TabIndex = 19;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnViewTeachers
            // 
            this.btnViewTeachers.Location = new System.Drawing.Point(3, 135);
            this.btnViewTeachers.Name = "btnViewTeachers";
            this.btnViewTeachers.Size = new System.Drawing.Size(192, 35);
            this.btnViewTeachers.TabIndex = 18;
            this.btnViewTeachers.Text = "View Teachers";
            this.btnViewTeachers.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(3, 94);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(192, 35);
            this.btnAddTeacher.TabIndex = 17;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Location = new System.Drawing.Point(3, 381);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(192, 35);
            this.btnMarkAttendance.TabIndex = 24;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(3, 53);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(192, 35);
            this.btnViewStudents.TabIndex = 16;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 11);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(192, 36);
            this.btnAddStudent.TabIndex = 15;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(251, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(399, 95);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(100, 20);
            this.txtParentName.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(542, 95);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.Text = "Select Gender";
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(251, 174);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(100, 20);
            this.txtCnic.TabIndex = 4;
            // 
            // txtParentCnic
            // 
            this.txtParentCnic.Location = new System.Drawing.Point(399, 174);
            this.txtParentCnic.Name = "txtParentCnic";
            this.txtParentCnic.Size = new System.Drawing.Size(100, 20);
            this.txtParentCnic.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(542, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parent Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CNIC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Parent CNIC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(726, 122);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(712, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 92);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Location = new System.Drawing.Point(399, 255);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateofBirth.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(647, 255);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 9;
            // 
            // txtParentContact
            // 
            this.txtParentContact.Location = new System.Drawing.Point(251, 341);
            this.txtParentContact.Name = "txtParentContact";
            this.txtParentContact.Size = new System.Drawing.Size(100, 20);
            this.txtParentContact.TabIndex = 10;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(251, 259);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 20);
            this.txtRollNo.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(530, 379);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 79);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Roll Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Contact:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Date of Brth:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Parent Contact:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Address:";
            // 
            // cmbSelectCourses
            // 
            this.cmbSelectCourses.FormattingEnabled = true;
            this.cmbSelectCourses.Location = new System.Drawing.Point(399, 340);
            this.cmbSelectCourses.Name = "cmbSelectCourses";
            this.cmbSelectCourses.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectCourses.TabIndex = 11;
            // 
            // bAddCourse
            // 
            this.bAddCourse.Location = new System.Drawing.Point(526, 338);
            this.bAddCourse.Name = "bAddCourse";
            this.bAddCourse.Size = new System.Drawing.Size(75, 23);
            this.bAddCourse.TabIndex = 12;
            this.bAddCourse.Text = "Add Course";
            this.bAddCourse.UseVisualStyleBackColor = true;
            this.bAddCourse.Click += new System.EventHandler(this.bAddCourse_Click);
            // 
            // bAddStudent
            // 
            this.bAddStudent.Location = new System.Drawing.Point(474, 476);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(75, 23);
            this.bAddStudent.TabIndex = 14;
            this.bAddStudent.Text = "Add Student";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Select Courses:";
            // 
            // frmAdminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bAddStudent);
            this.Controls.Add(this.bAddCourse);
            this.Controls.Add(this.cmbSelectCourses);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.txtParentContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.dtpDateofBirth);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtParentCnic);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmAdminAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Add Student";
            this.Load += new System.EventHandler(this.frmAdminAddStudent_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.TextBox txtParentCnic;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtParentContact;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSelectCourses;
        private System.Windows.Forms.Button bAddCourse;
        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.Label label12;
    }
}