namespace SMS
{
    partial class frmStudentSendMessages
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.cmbSelectTeacher = new System.Windows.Forms.ComboBox();
            this.btSend = new System.Windows.Forms.Button();
            this.llbReadMessages = new System.Windows.Forms.LinkLabel();
            this.panelInbox = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.panelInbox.SuspendLayout();
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
            this.btSendMessages.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSendMessages.Location = new System.Drawing.Point(501, 3);
            this.btSendMessages.Name = "btSendMessages";
            this.btSendMessages.Size = new System.Drawing.Size(160, 51);
            this.btSendMessages.TabIndex = 7;
            this.btSendMessages.Text = "Send Messages";
            this.btSendMessages.UseVisualStyleBackColor = false;
            // 
            // btViewBooks
            // 
            this.btViewBooks.Location = new System.Drawing.Point(335, 3);
            this.btViewBooks.Name = "btViewBooks";
            this.btViewBooks.Size = new System.Drawing.Size(160, 51);
            this.btViewBooks.TabIndex = 6;
            this.btViewBooks.Text = "View Books";
            this.btViewBooks.UseVisualStyleBackColor = true;
            // 
            // btAttendanceReports
            // 
            this.btAttendanceReports.Location = new System.Drawing.Point(169, 3);
            this.btAttendanceReports.Name = "btAttendanceReports";
            this.btAttendanceReports.Size = new System.Drawing.Size(160, 51);
            this.btAttendanceReports.TabIndex = 5;
            this.btAttendanceReports.Text = "View Attendance Report";
            this.btAttendanceReports.UseVisualStyleBackColor = true;
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
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(106, 160);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(172, 96);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = "";
            // 
            // cmbSelectTeacher
            // 
            this.cmbSelectTeacher.FormattingEnabled = true;
            this.cmbSelectTeacher.Location = new System.Drawing.Point(106, 286);
            this.cmbSelectTeacher.Name = "cmbSelectTeacher";
            this.cmbSelectTeacher.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectTeacher.TabIndex = 9;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(106, 339);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 10;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
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
            // panelInbox
            // 
            this.panelInbox.Controls.Add(this.dataGridView);
            this.panelInbox.Location = new System.Drawing.Point(360, 226);
            this.panelInbox.Name = "panelInbox";
            this.panelInbox.Size = new System.Drawing.Size(453, 245);
            this.panelInbox.TabIndex = 18;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(420, 222);
            this.dataGridView.TabIndex = 0;
            // 
            // frmStudentSendMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelInbox);
            this.Controls.Add(this.llbReadMessages);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.cmbSelectTeacher);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmStudentSendMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - Send Messages";
            this.Load += new System.EventHandler(this.frmStudentSendMessages_Load);
            this.panel.ResumeLayout(false);
            this.panelInbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btSendMessages;
        private System.Windows.Forms.Button btViewBooks;
        private System.Windows.Forms.Button btAttendanceReports;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox cmbSelectTeacher;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.LinkLabel llbReadMessages;
        private System.Windows.Forms.Panel panelInbox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}