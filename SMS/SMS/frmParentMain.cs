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
    public partial class frmParentMain : Form
    {
        public frmParentMain()
        {
            InitializeComponent();
        }

        private void frmParentMain_Load(object sender, EventArgs e)
        {
            richTextBox.Text = "Type your message..";
            cmbSelectReceiver.Text = "Select Receiver";
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close(); 
        }
    }
}
