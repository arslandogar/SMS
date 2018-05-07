namespace SMS
{
    partial class frmParentViewAttendanceReport
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
            this.llbReadMessages = new System.Windows.Forms.LinkLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
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
            this.btViewReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btViewReport.Location = new System.Drawing.Point(211, 3);
            this.btViewReport.Name = "btViewReport";
            this.btViewReport.Size = new System.Drawing.Size(202, 51);
            this.btViewReport.TabIndex = 1;
            this.btViewReport.Text = "View Attendance Report";
            this.btViewReport.UseVisualStyleBackColor = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.Control;
            this.btnMain.Location = new System.Drawing.Point(3, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(202, 51);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
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
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(187, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(436, 150);
            this.dataGridView.TabIndex = 11;
            // 
            // frmParentViewAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.llbReadMessages);
            this.Controls.Add(this.panel);
            this.Name = "frmParentViewAttendanceReport";
            this.Text = "Parent - View Attendance Report";
            this.Load += new System.EventHandler(this.frmParentViewAttendanceReport_Load);
            this.panel.ResumeLayout(false);
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
        private System.Windows.Forms.LinkLabel llbReadMessages;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}