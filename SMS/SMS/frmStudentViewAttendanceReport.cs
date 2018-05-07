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
    public partial class frmStudentViewAttendanceReport : Form
    {
        public frmStudentViewAttendanceReport()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void frmStudentViewAttendanceReport_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            string roll_no = ser.sGetStudentInformation()[4];
            source.DataSource = ser.sViewAttendances(roll_no);
            dataGridView.DataSource = source;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmStudentProfile temp = new frmStudentProfile();
            temp.Show();
            this.Close();
        }

        private void btViewBooks_Click(object sender, EventArgs e)
        {
            frmStudentViewBooks temp = new frmStudentViewBooks();
            temp.Show();
            this.Close();
        }

        private void btSendMessages_Click(object sender, EventArgs e)
        {
            frmStudentSendMessages temp = new frmStudentSendMessages();
            temp.Show();
            this.Close();
        }
    }
}
