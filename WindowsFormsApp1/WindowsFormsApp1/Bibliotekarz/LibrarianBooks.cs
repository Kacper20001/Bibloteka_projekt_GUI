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
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1
{
    public partial class LibrarianBooks : Form
    {
        private int currentLibrarianId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        public LibrarianBooks(int currentLibrarianId)
        {
            InitializeComponent();
            LoadBooks();
            this.currentLibrarianId = currentLibrarianId;
        }

        private void BooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadBooks(string searchTerm="")
        {
            IBookHandle bookHandle = new BookHandle();
            BooksDataGrid.DataSource = bookHandle.LoadBooks(searchTerm);
        }

        private void SrcBooksBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSrcBooks.Text;
            LoadBooks(searchTerm);
        }

        private void BackMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddBookForm addBookForm = new AddBookForm(currentLibrarianId); 
            addBookForm.Show();
        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBookForm editBookForm = new EditBookForm(currentLibrarianId); 
            editBookForm.Show(); 
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBookForm deleteBookForm = new DeleteBookForm(currentLibrarianId); 
            deleteBookForm.Show();
        }

        private void LibrarianBooks_Load(object sender, EventArgs e)
        {

        }
        public void LoadLibrarianBooks(string searchTerm = "")
        {
            IBookHandle bookHandle = new BookHandle();
            BooksDataGrid.DataSource = bookHandle.LoadBooks(searchTerm);
        }
    }
}
