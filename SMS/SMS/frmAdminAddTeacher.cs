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
    public partial class frmAdminAddTeacher : Form
    {
        public static List<string> courses = new List<string>();
        public frmAdminAddTeacher()
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

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            frmAdminMarkAttendance temp = new frmAdminMarkAttendance();
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

        private void frmAdminAddTeacher_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewCourses();
            cmbSelectCourses.DataSource = source;
            pictureBox.Image = SMS.Properties.Resources.user_pic;
            cmbSelectCourses.Text = "Select Courses";
            cmbGender.Text = "Select Gender";
        }

        private void bAssignCourse_Click(object sender, EventArgs e)
        {
            if (cmbSelectCourses.Text != "Select Courses")
            {
                courses.Add(cmbSelectCourses.Text);
                MessageBox.Show("Course Assigned!");
                cmbSelectCourses.Text = "Select Courses";
            }
        }

        private void bAddTeacher_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCnic.Text == "" || cmbGender.Text == "" || txtContact.Text == "" || txtEmail.Text == "" || txtEmployeeNo.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Incomplete Information");
            }
            else
            {
                server.Service1 ser = new server.Service1();
                ser.sAddTeacher(txtName.Text, txtCnic.Text, cmbGender.Text, txtEmail.Text, txtContact.Text, txtAddress.Text, dtpDateofBirth.Text, dtpJoiningDate.Text, txtEmployeeNo.Text, courses.ToArray());
                txtName.Text = "";
                txtCnic.Text = "";
                cmbGender.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtEmployeeNo.Text = "";
                txtAddress.Text = "";
                pictureBox.Image = SMS.Properties.Resources.user_pic;
                MessageBox.Show("Teacher Added!");
            }
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            frmAdminAddLibrarian temp = new frmAdminAddLibrarian();
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
