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
    public partial class frmAdminAddCourse : Form
    {
        public frmAdminAddCourse()
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

        private void bAddCourse_Click(object sender, EventArgs e)
        {
            if(txtAddCourse.Text == "")
            {
                MessageBox.Show("Enter name of the course!");
            } else
            {
                server.Service1 ser = new server.Service1();
                ser.sAddCourse(txtAddCourse.Text);
                MessageBox.Show(txtAddCourse.Text + " added to courses!");
                txtAddCourse.Text = "";
            }
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
