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
    public partial class frmLibrarianViewBooks : Form
    {
        public frmLibrarianViewBooks()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void frmLibrarianViewBooks_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewAllBooks();
            dataGridView.DataSource = source;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            txtAuthor.Text = "";
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewBookByName(txtTitle.Text);
            dataGridView.DataSource = source;
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewBookByAuthor(txtAuthor.Text);
            dataGridView.DataSource = source;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmLibrarianMain temp = new frmLibrarianMain();
            temp.Show();
            this.Close();
        }
    }
}
