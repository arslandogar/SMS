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
    public partial class frmTeacherSendMessages : Form
    {
        public frmTeacherSendMessages()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmTeacherProfile temp = new frmTeacherProfile();
            temp.Show();
            this.Close();
        }

        private void reset()
        {
            server.Service1 ser = new server.Service1();
            BindingSource id_source = new BindingSource();
            BindingSource rollNo_source = new BindingSource();
            BindingSource rollNoP_source = new BindingSource();
            BindingSource inbox = new BindingSource();
            id_source.DataSource = ser.sViewTeacherNames();
            rollNo_source.DataSource = ser.sViewRollNumbers();
            rollNoP_source.DataSource = ser.sViewRollNumbers();
            dataGridView.DataSource = inbox;
            inbox.DataSource = ser.sGetTeacherInbox();
            cmbSelectStudent.DataSource = rollNo_source;
            cmbSelectParent.DataSource = rollNoP_source;
            cmbSelectStudent.Text = "Select Student";
            cmbSelectParent.Text = "Select Child's roll no.";
            richTextBox.Text = "Type Your Message..";
        }

        private void btSendToAdmin_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            ser.sSendMessageToAdmin(richTextBox.Text, ser.sGetTeacherInformation()[0]);
            MessageBox.Show("Message sent!");
            reset();
        }

        private void frmTeacherSendMessages_Load(object sender, EventArgs e)
        {
            reset();
            panelInbox.Hide();
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

        private void btSendToStudent_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            ser.sSendMessageToStudent(richTextBox.Text, ser.sGetTeacherInformation()[0], cmbSelectStudent.Text);
            MessageBox.Show("Message Sent!");
            reset();
        }

        private void btSendToParent_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            ser.sSendMessageToParent(richTextBox.Text, ser.sGetTeacherInformation()[0], cmbSelectParent.Text);
            MessageBox.Show("Message Sent!");
            reset();
        }

        private void btMarkAttendance_Click(object sender, EventArgs e)
        {
            frmTeacherMarkAttendance temp = new frmTeacherMarkAttendance();
            temp.Show();
            this.Close();
        }

        private void btCourses_Click(object sender, EventArgs e)
        {
            frmTeacherCourses temp = new frmTeacherCourses();
            temp.Show();
            this.Close();
        }

        private void btAttendanceReport_Click(object sender, EventArgs e)
        {
            frmTeacherAttendanceReport temp = new frmTeacherAttendanceReport();
            temp.Show();
            this.Close();
        }
    }
}
