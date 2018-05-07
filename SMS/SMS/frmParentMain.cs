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
    public partial class frmParentMain : Form
    {
        public frmParentMain()
        {
            InitializeComponent();
        }

        private void reset()
        {
            server.Service1 ser = new server.Service1();
            BindingSource id_source = new BindingSource();
            BindingSource rollNo_source = new BindingSource();
            BindingSource inbox = new BindingSource();
            id_source.DataSource = ser.sViewTeacherNames();
            rollNo_source.DataSource = ser.sViewRollNumbers();
            dataGridView.DataSource = inbox;
            inbox.DataSource = ser.sGetParentInbox();
            cmbSelectTeacher.DataSource = id_source;
            cmbSelectTeacher.Text = "Select Teacher";
            richTextBox.Text = "Type Your Message..";
        }

        private void frmParentMain_Load(object sender, EventArgs e)
        {
            panelInbox.Hide();
            reset();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close(); 
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            int i = cmbSelectTeacher.Text.IndexOf(':');
            string t = cmbSelectTeacher.Text.Substring(0, i);
            ser.sSendMessageToTeacher(richTextBox.Text, ser.sGetParentInformation()[0], t);
            MessageBox.Show("Message sent!");
            reset();
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

        private void btViewReport_Click(object sender, EventArgs e)
        {
            frmParentViewAttendanceReport temp = new frmParentViewAttendanceReport();
            temp.Show();
            this.Close();
        }
    }
}
