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
    public partial class frmTeacherProfile : Form
    {
        public frmTeacherProfile()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void frmTeacherProfile_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            lbName.Text = ser.sGetTeacherInformation()[0];
            lbGender.Text = ser.sGetTeacherInformation()[1];
            lbDob.Text = ser.sGetTeacherInformation()[2];
            lbEmployeeNo.Text = ser.sGetTeacherInformation()[3];
            lbJoiningDate.Text = ser.sGetTeacherInformation()[4];
            lbEmail.Text = ser.sGetTeacherInformation()[5];
            lbPhone.Text = ser.sGetTeacherInformation()[6];
            txtAddress.Text = ser.sGetTeacherInformation()[7];
        }

        private void btMarkAttendance_Click(object sender, EventArgs e)
        {
            frmTeacherMarkAttendance temp = new frmTeacherMarkAttendance();
            temp.Show();
            this.Close();
        }

        private void btSendMessages_Click(object sender, EventArgs e)
        {
            frmTeacherSendMessages temp = new frmTeacherSendMessages();
            temp.Show();
            this.Close();
        }
    }
}
