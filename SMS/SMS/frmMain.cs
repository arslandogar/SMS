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
    public partial class frmMain : Form
    {
        private static frmMain instance = null;
        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain getInstance()
        {
            if(instance == null)
            {
                instance = new frmMain();
            }
            return instance;
        }

        private void llbAdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin temp = new frmAdminLogin();
            temp.Show();
            this.Hide();
        }

        private void llbStudentLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStudentLogin temp = new frmStudentLogin();
            temp.Show();
            this.Hide();
        }

        private void llbParentLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmParentLogin temp = new frmParentLogin();
            temp.Show();
            this.Hide();
        }

        private void llbLibrarianLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLibrarianLogin temp = new frmLibrarianLogin();
            temp.Show();
            this.Hide();
        }
    }
}
