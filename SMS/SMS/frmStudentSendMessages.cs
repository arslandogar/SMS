using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmStudentSendMessages : Form
    {
        public frmStudentSendMessages()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void reset()
        {
            server.Service1 ser = new server.Service1();
            BindingSource id_source = new BindingSource();
            BindingSource inbox = new BindingSource();
            id_source.DataSource = ser.sViewTeacherNames();
            dataGridView.DataSource = inbox;
            inbox.DataSource = ser.sGetStudentInbox();
            cmbSelectTeacher.DataSource = id_source;
            cmbSelectTeacher.Text = "Select Teacher";
            richTextBox.Text = "Type Your Message..";
        }

        private void llbReadMessages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llbReadMessages.Text == "Read Messages")
            {
                panelInbox.Show();
                llbReadMessages.Text = "Hide Messages";
            }
            else
            {
                panelInbox.Hide();
                llbReadMessages.Text = "Read Messages";
            }
        }

        private void frmStudentSendMessages_Load(object sender, EventArgs e)
        {
            panelInbox.Hide();
            reset();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            int i = cmbSelectTeacher.Text.IndexOf(':');
            string t = cmbSelectTeacher.Text.Substring(0, i);
            ser.sSendMessageToTeacher(richTextBox.Text, ser.sGetStudentInformation()[0], t);
        }

        private void btAttendanceReports_Click(object sender, EventArgs e)
        {
            frmStudentViewAttendanceReport temp = new frmStudentViewAttendanceReport();
            temp.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmStudentProfile temp = new frmStudentProfile();
            temp.Show();
            this.Close();
        }

        private void btViewBooks_Click(object sender, EventArgs e)
        {
            frmStudentViewBooks temp = new frmStudentViewBooks();
            temp.Show();
            this.Close();
        }
    }
}
