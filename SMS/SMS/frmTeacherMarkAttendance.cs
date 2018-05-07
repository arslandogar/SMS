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
    public partial class frmTeacherMarkAttendance : Form
    {
        public frmTeacherMarkAttendance()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void frmTeacherMarkAttendance_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewRollNumbers();
            cmbSelectStudent.DataSource = source; 
            cmbSelectStudent.Text = "Select Student";
            cmbStatus.Text = "Status";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            bool marked = false;
            bool markedS = false;
            ser.sMarkAttendanceStudent(cmbSelectStudent.Text, dateTimePicker1.Text, cmbStatus.Text, out marked, out markedS);
            if (marked)
            {
                MessageBox.Show("Attendance of Roll No. " + cmbSelectStudent.Text + " marked!");
                cmbSelectStudent.Text = "Select Student";
                cmbStatus.Text = "Status";
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmTeacherProfile temp = new frmTeacherProfile();
            temp.Show();
            this.Close();
        }

        private void btSendMessages_Click(object sender, EventArgs e)
        {
            frmTeacherSendMessages temp = new frmTeacherSendMessages();
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
