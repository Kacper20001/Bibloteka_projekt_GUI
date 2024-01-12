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
    public partial class BookManagementView : Form
    {
        private int currentLibrarianId;
        public BookManagementView(int librarianId)
        {
            InitializeComponent();
            currentLibrarianId = librarianId;
        }

        private void BackMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }

        private void BookManagementView_Load(object sender, EventArgs e)
        {

        }

        private void BooksListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianBooks librarianBooks = new LibrarianBooks(currentLibrarianId);
            librarianBooks.Show();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
