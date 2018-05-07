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
    public partial class frmAdminAssignCourse : Form
    {
        public frmAdminAssignCourse()
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

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            frmAdminMarkAttendance temp = new frmAdminMarkAttendance();
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

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAdminAddCourse temp = new frmAdminAddCourse();
            temp.Show();
            this.Close();
        }

        private void frmAdminAssignCourse_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource t_source = new BindingSource();
            BindingSource c_source = new BindingSource();
            c_source.DataSource = ser.sViewNullCourses();
            cmbSelectCourse.DataSource = c_source;
            t_source.DataSource = ser.sViewTeacherNames();
            cmbSelectTeacher.DataSource = t_source;
            cmbSelectCourse.Text = "Select Course";
            cmbSelectTeacher.Text = "Select Teacher";
        }

        private void btAssign_Click(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            int i = cmbSelectTeacher.Text.IndexOf(':');
            string t = cmbSelectTeacher.Text.Substring(0, i);
            ser.sAssignCourse(t, cmbSelectCourse.Text);
            BindingSource c_source = new BindingSource();
            c_source.DataSource = ser.sViewNullCourses();
            cmbSelectCourse.DataSource = c_source;
            cmbSelectCourse.Text = "Select Course";
            cmbSelectTeacher.Text = "Select Teacher";
        }

        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            frmAdminSendMessages temp = new frmAdminSendMessages();
            temp.Show();
            this.Close();
        }
    }
}
