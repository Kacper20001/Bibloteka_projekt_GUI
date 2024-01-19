using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Bibliotekarz.BookManagement;

namespace WindowsFormsApp1
{
    public partial class LibrarianBooks : Form
    {
        private int currentReaderId;
        private string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True";
        public LibrarianBooks(int currentReaderId)
        {
            InitializeComponent();
            LoadBooks();
            this.currentReaderId = currentReaderId;
        }

        private void BooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadBooks(string searchTerm="")
        {
            BooksDataGrid.DataSource = Book.LoadBooks(searchTerm);
        }

        private void SrcBooksBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSrcBooks.Text;
            LoadBooks(searchTerm);
        }

        private void BackMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentReaderId);
            librarianMenu.Show();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addBookForm = new AddBookForm(currentReaderId); 
            addBookForm.Show();
        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBookForm editBookForm = new EditBookForm(currentReaderId); 
            editBookForm.Show(); 
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBookForm deleteBookForm = new DeleteBookForm(currentReaderId); 
            deleteBookForm.Show();
        }

        private void LibrarianBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
