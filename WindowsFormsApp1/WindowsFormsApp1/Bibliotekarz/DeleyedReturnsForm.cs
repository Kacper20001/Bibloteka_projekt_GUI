using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class DeleyedReturnsForm : Form
    {
        private int currentLibrarianId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        public DeleyedReturnsForm(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
            LoadOverdueBooksData();
        }
        private void LoadOverdueBooksData()
        {
            IOverdueBook overdueBook = new OverdueBookHandle(connectionString);
            DataGridDeleyedBook.DataSource = overdueBook.LoadOverdueBooks();
        }
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            IOverdueBook overdueBook = new OverdueBookHandle(connectionString);
            IBookHandle bookHandle = new BookHandle(connectionString);
            foreach (DataGridViewRow row in DataGridDeleyedBook.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectBookCheck"].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                    bookHandle.ReturnBook(bookId);
                }
            }
            overdueBook.LoadOverdueBooks();
        }

        private void BackMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }

        private void DeleyedReturnsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
