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
    public partial class frmStudentProfile : Form
    {
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        private void frmStudentProfile_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            lbName.Text = ser.sGetStudentInformation()[0];
            lbGender.Text = ser.sGetStudentInformation()[1];
            llbParentName.Text = ser.sGetStudentInformation()[2];
            lbDob.Text = ser.sGetStudentInformation()[3];
            lbRollNo.Text = ser.sGetStudentInformation()[4];
            lbEmail.Text =  ser.sGetStudentInformation()[5];
            lbPhone.Text = ser.sGetStudentInformation()[6];
            txtAddress.Text = ser.sGetStudentInformation()[7];
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmStudentSendMessages temp = new frmStudentSendMessages();
            temp.Show();
            this.Close();
        }
    }
}
