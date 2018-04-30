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
    public partial class frmAdminAddLibrarian : Form
    {
        public frmAdminAddLibrarian()
        {
            InitializeComponent();
        }

        private void frmAdminAddLibrarian_Load(object sender, EventArgs e)
        {
            pictureBox.Image = SMS.Properties.Resources.user_pic;
        }

        private void bAddLibrarian_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtCnic.Text == "" || cmbGender.Text == "" || txtContact.Text == "" || txtEmail.Text == "" || txtEmployeeNo.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Incomplete Information");
            } else
            {
                server.Service1 ser = new server.Service1();
                ser.sChangeLibrarian(txtName.Text, txtCnic.Text, cmbGender.Text, txtEmail.Text, txtContact.Text, txtAddress.Text, dtpDateofBirth.Text, dtpJoiningDate.Text, txtEmployeeNo.Text);
                txtName.Text = "";
                txtCnic.Text = "";
                cmbGender.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtEmployeeNo.Text = ""; 
                txtAddress.Text = "";
                pictureBox.Image = SMS.Properties.Resources.user_pic;
                MessageBox.Show("Librarian Added!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }
    }
}
