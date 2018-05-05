namespace SMS
{
    partial class frmParentMain
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btNotifications = new System.Windows.Forms.Button();
            this.btViewReport = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.cmbSelectReceiver = new System.Windows.Forms.ComboBox();
            this.btSend = new System.Windows.Forms.Button();
            this.llbReadMessages = new System.Windows.Forms.LinkLabel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btLogout);
            this.panel.Controls.Add(this.btNotifications);
            this.panel.Controls.Add(this.btViewReport);
            this.panel.Controls.Add(this.btnMain);
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 59);
            this.panel.TabIndex = 6;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(625, 3);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(202, 51);
            this.btLogout.TabIndex = 3;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btNotifications
            // 
            this.btNotifications.Location = new System.Drawing.Point(419, 3);
            this.btNotifications.Name = "btNotifications";
            this.btNotifications.Size = new System.Drawing.Size(202, 51);
            this.btNotifications.TabIndex = 2;
            this.btNotifications.Text = "Notifications";
            this.btNotifications.UseVisualStyleBackColor = true;
            // 
            // btViewReport
            // 
            this.btViewReport.Location = new System.Drawing.Point(211, 3);
            this.btViewReport.Name = "btViewReport";
            this.btViewReport.Size = new System.Drawing.Size(202, 51);
            this.btViewReport.TabIndex = 1;
            this.btViewReport.Text = "View Attendance Report";
            this.btViewReport.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMain.Location = new System.Drawing.Point(3, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(202, 51);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(106, 160);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(172, 96);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // cmbSelectReceiver
            // 
            this.cmbSelectReceiver.FormattingEnabled = true;
            this.cmbSelectReceiver.Location = new System.Drawing.Point(106, 286);
            this.cmbSelectReceiver.Name = "cmbSelectReceiver";
            this.cmbSelectReceiver.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectReceiver.TabIndex = 8;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(106, 339);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 9;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            // 
            // llbReadMessages
            // 
            this.llbReadMessages.AutoSize = true;
            this.llbReadMessages.Location = new System.Drawing.Point(738, 489);
            this.llbReadMessages.Name = "llbReadMessages";
            this.llbReadMessages.Size = new System.Drawing.Size(84, 13);
            this.llbReadMessages.TabIndex = 10;
            this.llbReadMessages.TabStop = true;
            this.llbReadMessages.Text = "Read Messages";
            // 
            // frmParentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.llbReadMessages);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.cmbSelectReceiver);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel);
            this.Name = "frmParentMain";
            this.Text = "Parent - Main";
            this.Load += new System.EventHandler(this.frmParentMain_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btNotifications;
        private System.Windows.Forms.Button btViewReport;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox cmbSelectReceiver;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.LinkLabel llbReadMessages;
    }
}