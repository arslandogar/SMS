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
    public partial class frmAdminAddStudent : Form
    {
        public static List<string> coursesAdded= new List<string>();
        public frmAdminAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            frmAdminAddLibrarian temp = new frmAdminAddLibrarian();
            temp.Show();
            this.Close();
            
        }

        private void frmAdminAddStudent_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewCourses();
            cmbSelectCourses.DataSource = source;
            cmbSelectCourses.Text = "Select Courses";
            pictureBox.Image = SMS.Properties.Resources.user_pic;
        }

        private void bAddCourse_Click(object sender, EventArgs e)
        {
            coursesAdded.Add(cmbSelectCourses.Text);
            cmbSelectCourses.Text = "Select Courses";
            MessageBox.Show("Course Added!");
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" || txtCnic.Text == "" || txtContact.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtParentCnic.Text == "" || txtParentContact.Text == "" || txtParentName.Text == "" || txtRollNo.Text == "")
            {
                MessageBox.Show("Incomplete Information!");
            } else
            { 
                server.Service1 ser = new server.Service1();
                ser.sAddStudent(txtName.Text, txtCnic.Text, cmbGender.Text, txtEmail.Text, txtRollNo.Text, dtpDateofBirth.Text, txtContact.Text, coursesAdded.ToArray(), txtAddress.Text);
                ser.sAddParent(txtParentName.Text, txtParentCnic.Text, txtParentContact.Text, txtCnic.Text);
                MessageBox.Show("Student Added!");
                MessageBox.Show(txtName.Text + "'s parent also Added!");
                coursesAdded.Clear();
                cmbGender.Text = "Select Gender";
                txtAddress.Text = "";
                txtCnic.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtName.Text = "";
                txtParentCnic.Text = "";
                txtParentContact.Text = "";
                txtParentName.Text = ""; ;
                txtRollNo.Text = "";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            frmAdminMarkAttendance temp = new frmAdminMarkAttendance();
            temp.Show();
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
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
    }
}
