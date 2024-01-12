using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Bibliotekarz.BookManagement
{
    public partial class DeleteBookForm : Form
    {
        private int currentLibraryId;
        public DeleteBookForm(int id)
        {
            InitializeComponent();
            currentLibraryId = id;
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibraryId);
            librarianMenu.Show();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianBooks librarianBooks = new LibrarianBooks(currentLibraryId);
            librarianBooks.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IdTxt.Text);
                Book.DeleteBook(id);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID");
            }
        }
    }
}
