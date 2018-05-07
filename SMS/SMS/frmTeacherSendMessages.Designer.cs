namespace SMS
{
    partial class frmTeacherSendMessages
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
            this.panelInbox = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.llbReadMessages = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSendToAdmin = new System.Windows.Forms.Button();
            this.cmbSelectStudent = new System.Windows.Forms.ComboBox();
            this.btSendToStudent = new System.Windows.Forms.Button();
            this.cmbSelectParent = new System.Windows.Forms.ComboBox();
            this.btSendToParent = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panelInbox.SuspendLayout();
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
            this.btSendMessages.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSendMessages.Location = new System.Drawing.Point(554, 3);
            this.btSendMessages.Name = "btSendMessages";
            this.btSendMessages.Size = new System.Drawing.Size(132, 51);
            this.btSendMessages.TabIndex = 8;
            this.btSendMessages.Text = "Send Messages";
            this.btSendMessages.UseVisualStyleBackColor = false;
            // 
            // btAttendanceReport
            // 
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
            this.btCourses.Location = new System.Drawing.Point(141, 3);
            this.btCourses.Name = "btCourses";
            this.btCourses.Size = new System.Drawing.Size(132, 51);
            this.btCourses.TabIndex = 5;
            this.btCourses.Text = "Courses";
            this.btCourses.UseVisualStyleBackColor = true;
            this.btCourses.Click += new System.EventHandler(this.btCourses_Click);
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
            // panelInbox
            // 
            this.panelInbox.Controls.Add(this.dataGridView);
            this.panelInbox.Location = new System.Drawing.Point(24, 291);
            this.panelInbox.Name = "panelInbox";
            this.panelInbox.Size = new System.Drawing.Size(798, 185);
            this.panelInbox.TabIndex = 19;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(766, 164);
            this.dataGridView.TabIndex = 0;
            // 
            // llbReadMessages
            // 
            this.llbReadMessages.AutoSize = true;
            this.llbReadMessages.Location = new System.Drawing.Point(738, 489);
            this.llbReadMessages.Name = "llbReadMessages";
            this.llbReadMessages.Size = new System.Drawing.Size(84, 13);
            this.llbReadMessages.TabIndex = 20;
            this.llbReadMessages.TabStop = true;
            this.llbReadMessages.Text = "Read Messages";
            this.llbReadMessages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbReadMessages_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Message Admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Message a Student:";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(24, 66);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(172, 96);
            this.richTextBox.TabIndex = 23;
            this.richTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Message a Parent:";
            // 
            // btSendToAdmin
            // 
            this.btSendToAdmin.Location = new System.Drawing.Point(221, 104);
            this.btSendToAdmin.Name = "btSendToAdmin";
            this.btSendToAdmin.Size = new System.Drawing.Size(93, 23);
            this.btSendToAdmin.TabIndex = 25;
            this.btSendToAdmin.Text = "Send To Admin";
            this.btSendToAdmin.UseVisualStyleBackColor = true;
            this.btSendToAdmin.Click += new System.EventHandler(this.btSendToAdmin_Click);
            // 
            // cmbSelectStudent
            // 
            this.cmbSelectStudent.FormattingEnabled = true;
            this.cmbSelectStudent.Location = new System.Drawing.Point(24, 195);
            this.cmbSelectStudent.Name = "cmbSelectStudent";
            this.cmbSelectStudent.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectStudent.TabIndex = 26;
            // 
            // btSendToStudent
            // 
            this.btSendToStudent.Location = new System.Drawing.Point(41, 222);
            this.btSendToStudent.Name = "btSendToStudent";
            this.btSendToStudent.Size = new System.Drawing.Size(75, 23);
            this.btSendToStudent.TabIndex = 27;
            this.btSendToStudent.Text = "Send";
            this.btSendToStudent.UseVisualStyleBackColor = true;
            this.btSendToStudent.Click += new System.EventHandler(this.btSendToStudent_Click);
            // 
            // cmbSelectParent
            // 
            this.cmbSelectParent.FormattingEnabled = true;
            this.cmbSelectParent.Location = new System.Drawing.Point(181, 195);
            this.cmbSelectParent.Name = "cmbSelectParent";
            this.cmbSelectParent.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectParent.TabIndex = 28;
            // 
            // btSendToParent
            // 
            this.btSendToParent.Location = new System.Drawing.Point(199, 222);
            this.btSendToParent.Name = "btSendToParent";
            this.btSendToParent.Size = new System.Drawing.Size(75, 23);
            this.btSendToParent.TabIndex = 29;
            this.btSendToParent.Text = "Send";
            this.btSendToParent.UseVisualStyleBackColor = true;
            this.btSendToParent.Click += new System.EventHandler(this.btSendToParent_Click);
            // 
            // frmTeacherSendMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btSendToParent);
            this.Controls.Add(this.cmbSelectParent);
            this.Controls.Add(this.btSendToStudent);
            this.Controls.Add(this.cmbSelectStudent);
            this.Controls.Add(this.btSendToAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbReadMessages);
            this.Controls.Add(this.panelInbox);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmTeacherSendMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Send Messages";
            this.Load += new System.EventHandler(this.frmTeacherSendMessages_Load);
            this.panel.ResumeLayout(false);
            this.panelInbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btAttendanceReport;
        private System.Windows.Forms.Button btMarkAttendance;
        private System.Windows.Forms.Button btCourses;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btSendMessages;
        private System.Windows.Forms.Panel panelInbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.LinkLabel llbReadMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSendToAdmin;
        private System.Windows.Forms.ComboBox cmbSelectStudent;
        private System.Windows.Forms.Button btSendToStudent;
        private System.Windows.Forms.ComboBox cmbSelectParent;
        private System.Windows.Forms.Button btSendToParent;
    }
}