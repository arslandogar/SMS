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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            bool isValidS = false;
            server.Service1 ser = new server.Service1();
            if(txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Incorrect username or password!");
            } else
            {
                ser.sValidAdmin(txtUserName.Text, txtPassword.Text, out isValid, out isValidS);
                if(!isValid)
                {
                    MessageBox.Show("Incorrect username or password!");
                } else
                {
                    frmAdminAddStudent temp = new frmAdminAddStudent();
                    temp.Show();
                    this.Hide();
                }
            }
        }
    }
}
