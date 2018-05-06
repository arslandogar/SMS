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
    public partial class frmAdminMarkAttendance : Form
    {
        public frmAdminMarkAttendance()
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

        private void frmAdminMarkAttendance_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewEmployeeNumbers();
            cmbSelectEmployee.DataSource = source;
            cmbSelectEmployee.Text = "Select Employee";
            cmbStatus.Text = "Status";
        }

        private void bMarkAttendance_Click(object sender, EventArgs e)
        {
            bool isMarked = false;
            bool isMarkedS = false;
            server.Service1 ser = new server.Service1();
            ser.sMarkAttendanceEmployee(cmbSelectEmployee.Text, dateTimePicker.Text, cmbStatus.Text, out isMarked, out isMarkedS);
            if (isMarked)
            {
                MessageBox.Show("Attendance of Employee No. " + cmbSelectEmployee.Text + " marked!");
                cmbSelectEmployee.Text = "Select Employee";
                cmbStatus.Text = "Status";
            }
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
    }
}