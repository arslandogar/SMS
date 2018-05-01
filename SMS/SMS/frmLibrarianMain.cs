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
    public partial class frmLibrarianMain : Form
    {
        public frmLibrarianMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain temp = frmMain.getInstance();
            temp.Show();
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "")
            {
                MessageBox.Show("Incomplete Information!");
            }
            else
            {
                server.Service1 ser = new server.Service1();
                ser.sAddBook(txtTitle.Text, txtAuthor.Text);
                MessageBox.Show(txtTitle.Text + " added to Books!");
                txtTitle.Text = "";
                txtAuthor.Text = "";
                BindingSource source = new BindingSource();
                source.DataSource = ser.sViewBookNames();
                cmbSelectBook.DataSource = source;
                cmbSelectBook.Text = "Select Book";
            }
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            frmLibrarianViewBooks temp = new frmLibrarianViewBooks();
            temp.Show();
            this.Close();
        }

        private void frmLibrarianMain_Load(object sender, EventArgs e)
        {
            server.Service1 ser = new server.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.sViewBookNames();
            cmbSelectBook.DataSource = source;
            cmbSelectBook.Text = "Select Book";
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            bool isRemoved = false;
            bool isRemoveS = false;
            server.Service1 ser = new server.Service1();
            ser.sRemoveBook(cmbSelectBook.Text, out isRemoved, out isRemoveS);
            if (isRemoved)
            {
                MessageBox.Show(cmbSelectBook.Text + " deleted!");
                BindingSource source = new BindingSource();
                source.DataSource = ser.sViewBookNames();
                cmbSelectBook.DataSource = source;
                cmbSelectBook.Text = "Select Book";
            }
        }
    }
}