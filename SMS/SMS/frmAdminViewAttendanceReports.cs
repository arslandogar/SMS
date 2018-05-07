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
    public partial class frmAdminViewAttendanceReports : Form
    {
        public frmAdminViewAttendanceReports()
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

        private void frmAdminViewAttendanceReports_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            if (cbIsStudent.Checked)
            {
                source.DataSource = ser.sViewRollNumbers();
                cmbSelect.DataSource = source;
                cmbSelect.Text = "Select Student";
            } else
            {
                source.DataSource = ser.sViewEmployeeNumbers();
                cmbSelect.DataSource = source;
                cmbSelect.Text = "Select Employee";
            }
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            frmAdminMarkAttendance temp = new frmAdminMarkAttendance();
            temp.Show();
            this.Close();
        }

        private void cbIsStudent_CheckedChanged(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            if (cbIsStudent.Checked)
            {
                source.DataSource = ser.sViewRollNumbers();
                cmbSelect.DataSource = source;
                cmbSelect.Text = "Select Student";
            }
            else
            {
                source.DataSource = ser.sViewEmployeeNumbers();
                cmbSelect.DataSource = source;
            }
            cmbSelect.Text = "Select Employee";
        }

        private void cmbSelect_TextChanged(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewAttendances(cmbSelect.Text);
            dataGridView.DataSource = source;
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

        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            frmAdminSendMessages temp = new frmAdminSendMessages();
            temp.Show();
            this.Close();
        }
    }
}
