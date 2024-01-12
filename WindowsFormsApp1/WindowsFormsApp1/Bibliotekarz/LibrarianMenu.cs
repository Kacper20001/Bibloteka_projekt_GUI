using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LibrarianMenu : Form
    {
        private int currentLibrarianId;
        public LibrarianMenu(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianBooks librarianBooks = new LibrarianBooks(currentLibrarianId);
            librarianBooks.Show();
        }

        private void BookManagementBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookManagementView bookManagementView = new BookManagementView(currentLibrarianId);
            bookManagementView.Show();
        }

        private void LibrarianMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
