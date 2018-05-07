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
    public partial class frmAdminSendMessages : Form
    {
        public frmAdminSendMessages()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAdminAddStudent temp = new frmAdminAddStudent();
            temp.Show();
            this.Close();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            frmAdminAddLibrarian temp = new frmAdminAddLibrarian();
            temp.Show();
            this.Close();
        }

        private void btnViewAttendances_Click(object sender, EventArgs e)
        {
            frmAdminViewAttendanceReports temp = new frmAdminViewAttendanceReports();
            temp.Show();
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAdminAddCourse temp = new frmAdminAddCourse();
            temp.Show();
            this.Close();
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            frmAdminViewCourses temp = new frmAdminViewCourses();
            temp.Show();
            this.Close();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAdminAddTeacher temp = new frmAdminAddTeacher();
            temp.Show();
            this.Close();
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            frmAdminAssignCourse temp = new frmAdminAssignCourse();
            temp.Show();
            this.Close();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            frmAdminMarkAttendance temp = new frmAdminMarkAttendance();
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
            inbox.DataSource = ser.sGetAdminInbox();
            cmbSelectTeacher.DataSource = id_source;
            cmbSelectStudent.DataSource = rollNo_source;
            cmbSelectParent.DataSource = rollNoP_source;
            cmbSelectTeacher.Text = "Select Teacher";
            cmbSelectStudent.Text = "Select Student";
            cmbSelectParent.Text = "Select Child's roll no.";
            richTextBox.Text = "Type Your Message..";
        }

        private void frmAdminSendMessages_Load(object sender, EventArgs e)
        {
            panelInbox.Hide();
            reset();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            int i = cmbSelectTeacher.Text.IndexOf(':');
            string t = cmbSelectTeacher.Text.Substring(0, i);
            ser.sSendMessageToTeacher(richTextBox.Text, "Admin", t);
            MessageBox.Show("Message Sent!");
            reset();
        }

        private void llbReadMessages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llbReadMessages.Text == "Read Messages")
            {
                panelInbox.Show();
                llbReadMessages.Text = "Hide Messages";
            } else
            {
                panelInbox.Hide();
                llbReadMessages.Text = "Read Messages";
            }
        }

        private void btSendToStudent_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            ser.sSendMessageToStudent(richTextBox.Text, "Admin", cmbSelectStudent.Text);
            MessageBox.Show("Message Sent!");
            reset();
        }

        private void btSendToParent_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            ser.sSendMessageToParent(richTextBox.Text, "Admin", cmbSelectParent.Text);
            MessageBox.Show("Message Sent!");
            reset();
        }
    }
}