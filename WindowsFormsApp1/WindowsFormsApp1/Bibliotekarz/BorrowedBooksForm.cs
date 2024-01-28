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
    public partial class BorrowedBooksForm : Form
    {
        private int currentLibrarianId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";

        public BorrowedBooksForm(int librarianId)
        {
            InitializeComponent();
            currentLibrarianId = librarianId;
            LoadBorrowedBooksData();
        }

        private void BorrowedBooksForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }

        private void ReturnBooksBtn_Click(object sender, EventArgs e)
        {
            IBookHandle bookHandle = new BookHandle(connectionString);

            foreach (DataGridViewRow row in DataGridBorrowed.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectToReturn"].Value);
                if(isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookID"].Value);
                    bookHandle.ReturnBook(bookId);
                }
            }
            LoadBorrowedBooksData();
        }
        private void LoadBorrowedBooksData()
        {
            //BorrowBookHandle bookHandle = new BorrowBookHandle();
            BorrowBookHandle bookHandle = new BorrowBookHandle(connectionString);
            DataGridBorrowed.DataSource = bookHandle.LoadAllBorrowedBooks(connectionString);
        }
    }
}
