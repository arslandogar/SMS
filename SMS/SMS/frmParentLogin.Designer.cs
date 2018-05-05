namespace SMS
{
    partial class frmParentLogin
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
            this.btLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.lnUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.llbMain = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(423, 250);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(412, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(412, 159);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(100, 20);
            this.txtCnic.TabIndex = 0;
            // 
            // lnUserName
            // 
            this.lnUserName.AutoSize = true;
            this.lnUserName.Location = new System.Drawing.Point(327, 162);
            this.lnUserName.Name = "lnUserName";
            this.lnUserName.Size = new System.Drawing.Size(35, 13);
            this.lnUserName.TabIndex = 3;
            this.lnUserName.Text = "CNIC:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(327, 209);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // llbMain
            // 
            this.llbMain.AutoSize = true;
            this.llbMain.Location = new System.Drawing.Point(420, 489);
            this.llbMain.Name = "llbMain";
            this.llbMain.Size = new System.Drawing.Size(58, 13);
            this.llbMain.TabIndex = 5;
            this.llbMain.TabStop = true;
            this.llbMain.Text = "Main Page";
            this.llbMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMain_LinkClicked);
            // 
            // frmParentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.llbMain);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lnUserName);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btLogin);
            this.Icon = global::SMS.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "frmParentLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label lnUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.LinkLabel llbMain;
    }
}

