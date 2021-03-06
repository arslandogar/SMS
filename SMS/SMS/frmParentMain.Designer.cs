﻿namespace SMS
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
            this.btViewReport.Click += new System.EventHandler(this.btViewReport_Click);
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
            this.richTextBox.Location = new System.Drawing.Point(73, 157);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(172, 96);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // cmbSelectTeacher
            // 
            this.cmbSelectTeacher.FormattingEnabled = true;
            this.cmbSelectTeacher.Location = new System.Drawing.Point(73, 276);
            this.cmbSelectTeacher.Name = "cmbSelectTeacher";
            this.cmbSelectTeacher.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectTeacher.TabIndex = 8;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(73, 320);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 9;
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
            this.llbReadMessages.TabIndex = 10;
            this.llbReadMessages.TabStop = true;
            this.llbReadMessages.Text = "Read Messages";
            this.llbReadMessages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbReadMessages_LinkClicked);
            // 
            // panelInbox
            // 
            this.panelInbox.Controls.Add(this.dataGridView);
            this.panelInbox.Location = new System.Drawing.Point(369, 222);
            this.panelInbox.Name = "panelInbox";
            this.panelInbox.Size = new System.Drawing.Size(453, 245);
            this.panelInbox.TabIndex = 19;
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
            // frmParentMain
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
            this.Name = "frmParentMain";
            this.Text = "Parent - Main";
            this.Load += new System.EventHandler(this.frmParentMain_Load);
            this.panel.ResumeLayout(false);
            this.panelInbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbSelectTeacher;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.LinkLabel llbReadMessages;
        private System.Windows.Forms.Panel panelInbox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}