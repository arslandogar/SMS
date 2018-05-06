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
    public partial class frmTeacherLogin : Form
    {
        public frmTeacherLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            bool isValidS = false;
            server.Service1 ser = new server.Service1();
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Incorrect username or password!");
            }
            else
            {
                ser.sValidTeacher(txtEmail.Text, txtPassword.Text, out isValid, out isValidS);
                if (!isValid)
                {
                    MessageBox.Show("Incorrect username or password!");
                }
                else
                {
                    frmTeacherProfile temp = new frmTeacherProfile();
                    temp.Show();
                    this.Close();
                }
            }
        }

        private void llbMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }
    }
}
