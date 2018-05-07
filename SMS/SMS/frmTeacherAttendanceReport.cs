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
    public partial class frmTeacherAttendanceReport : Form
    {
        public frmTeacherAttendanceReport()
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

        private void btSendMessages_Click(object sender, EventArgs e)
        {
            frmTeacherSendMessages temp = new frmTeacherSendMessages();
            temp.Show();
            this.Close();
        }

        private void frmTeacherAttendanceReport_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            string employee_no = ser.sGetTeacherInformation()[3];
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewAttendances(employee_no);
            dataGridView.DataSource = source;
        }

        private void btCourses_Click(object sender, EventArgs e)
        {
            frmTeacherCourses temp = new frmTeacherCourses();
            temp.Show();
            this.Close();
        }

        private void btMarkAttendance_Click(object sender, EventArgs e)
        {
            frmTeacherMarkAttendance temp = new frmTeacherMarkAttendance();
            temp.Show();
            this.Close();
        }
    }
}
