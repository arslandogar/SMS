namespace SMS
{
    partial class frmStudentViewBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
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
            this.btViewBooks.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btViewBooks.Location = new System.Drawing.Point(335, 3);
            this.btViewBooks.Name = "btViewBooks";
            this.btViewBooks.Size = new System.Drawing.Size(160, 51);
            this.btViewBooks.TabIndex = 6;
            this.btViewBooks.Text = "View Books";
            this.btViewBooks.UseVisualStyleBackColor = false;
            // 
            // btAttendanceReports
            // 
            this.btAttendanceReports.BackColor = System.Drawing.SystemColors.Control;
            this.btAttendanceReports.Location = new System.Drawing.Point(169, 3);
            this.btAttendanceReports.Name = "btAttendanceReports";
            this.btAttendanceReports.Size = new System.Drawing.Size(160, 51);
            this.btAttendanceReports.TabIndex = 5;
            this.btAttendanceReports.Text = "View Attendance Report";
            this.btAttendanceReports.UseVisualStyleBackColor = true;
            this.btAttendanceReports.Click += new System.EventHandler(this.btAttendanceReports_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search By Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(170, 130);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(588, 130);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 11;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(284, 183);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 12;
            // 
            // frmStudentViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmStudentViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - View Books";
            this.Load += new System.EventHandler(this.frmStudentViewBooks_Load);
            this.panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}