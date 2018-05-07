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
    public partial class frmParentViewAttendanceReport : Form
    {
        public frmParentViewAttendanceReport()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close(); 
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmParentMain temp = new frmParentMain();
            temp.Show();
            this.Close();
        }

        private void frmParentViewAttendanceReport_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewChildAttendance();
            dataGridView.DataSource = source;
        }
    }
}
