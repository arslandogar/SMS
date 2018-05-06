namespace SMS
{
    partial class frmMain
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
            this.llbAdminLogin = new System.Windows.Forms.LinkLabel();
            this.llbLibrarianLogin = new System.Windows.Forms.LinkLabel();
            this.llbParentLogin = new System.Windows.Forms.LinkLabel();
            this.llbStudentLogin = new System.Windows.Forms.LinkLabel();
            this.llbTeacherLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llbAdminLogin
            // 
            this.llbAdminLogin.ActiveLinkColor = System.Drawing.Color.DarkKhaki;
            this.llbAdminLogin.AutoSize = true;
            this.llbAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.llbAdminLogin.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbAdminLogin.LinkColor = System.Drawing.Color.SeaGreen;
            this.llbAdminLogin.Location = new System.Drawing.Point(301, 63);
            this.llbAdminLogin.Name = "llbAdminLogin";
            this.llbAdminLogin.Size = new System.Drawing.Size(181, 30);
            this.llbAdminLogin.TabIndex = 0;
            this.llbAdminLogin.TabStop = true;
            this.llbAdminLogin.Text = "Admin Login";
            this.llbAdminLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAdminLogin_LinkClicked);
            // 
            // llbLibrarianLogin
            // 
            this.llbLibrarianLogin.ActiveLinkColor = System.Drawing.Color.DarkKhaki;
            this.llbLibrarianLogin.AutoSize = true;
            this.llbLibrarianLogin.BackColor = System.Drawing.Color.Transparent;
            this.llbLibrarianLogin.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLibrarianLogin.LinkColor = System.Drawing.Color.SeaGreen;
            this.llbLibrarianLogin.Location = new System.Drawing.Point(301, 263);
            this.llbLibrarianLogin.Name = "llbLibrarianLogin";
            this.llbLibrarianLogin.Size = new System.Drawing.Size(233, 30);
            this.llbLibrarianLogin.TabIndex = 3;
            this.llbLibrarianLogin.TabStop = true;
            this.llbLibrarianLogin.Text = "Librarian Login";
            this.llbLibrarianLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLibrarianLogin_LinkClicked);
            // 
            // llbParentLogin
            // 
            this.llbParentLogin.ActiveLinkColor = System.Drawing.Color.DarkKhaki;
            this.llbParentLogin.AutoSize = true;
            this.llbParentLogin.BackColor = System.Drawing.Color.Transparent;
            this.llbParentLogin.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbParentLogin.LinkColor = System.Drawing.Color.SeaGreen;
            this.llbParentLogin.Location = new System.Drawing.Point(301, 163);
            this.llbParentLogin.Name = "llbParentLogin";
            this.llbParentLogin.Size = new System.Drawing.Size(195, 30);
            this.llbParentLogin.TabIndex = 2;
            this.llbParentLogin.TabStop = true;
            this.llbParentLogin.Text = "Parent Login";
            this.llbParentLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbParentLogin_LinkClicked);
            // 
            // llbStudentLogin
            // 
            this.llbStudentLogin.ActiveLinkColor = System.Drawing.Color.DarkKhaki;
            this.llbStudentLogin.AutoSize = true;
            this.llbStudentLogin.BackColor = System.Drawing.Color.Transparent;
            this.llbStudentLogin.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbStudentLogin.LinkColor = System.Drawing.Color.SeaGreen;
            this.llbStudentLogin.Location = new System.Drawing.Point(301, 113);
            this.llbStudentLogin.Name = "llbStudentLogin";
            this.llbStudentLogin.Size = new System.Drawing.Size(210, 30);
            this.llbStudentLogin.TabIndex = 1;
            this.llbStudentLogin.TabStop = true;
            this.llbStudentLogin.Text = "Student Login";
            this.llbStudentLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbStudentLogin_LinkClicked);
            // 
            // llbTeacherLogin
            // 
            this.llbTeacherLogin.ActiveLinkColor = System.Drawing.Color.DarkKhaki;
            this.llbTeacherLogin.AutoSize = true;
            this.llbTeacherLogin.BackColor = System.Drawing.Color.Transparent;
            this.llbTeacherLogin.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTeacherLogin.LinkColor = System.Drawing.Color.SeaGreen;
            this.llbTeacherLogin.Location = new System.Drawing.Point(301, 213);
            this.llbTeacherLogin.Name = "llbTeacherLogin";
            this.llbTeacherLogin.Size = new System.Drawing.Size(208, 30);
            this.llbTeacherLogin.TabIndex = 4;
            this.llbTeacherLogin.TabStop = true;
            this.llbTeacherLogin.Text = "Teacher Login";
            this.llbTeacherLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTeacherLogin_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMS.Properties.Resources.background_main;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.llbTeacherLogin);
            this.Controls.Add(this.llbStudentLogin);
            this.Controls.Add(this.llbParentLogin);
            this.Controls.Add(this.llbLibrarianLogin);
            this.Controls.Add(this.llbAdminLogin);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbAdminLogin;
        private System.Windows.Forms.LinkLabel llbLibrarianLogin;
        private System.Windows.Forms.LinkLabel llbParentLogin;
        private System.Windows.Forms.LinkLabel llbStudentLogin;
        private System.Windows.Forms.LinkLabel llbTeacherLogin;
    }
}