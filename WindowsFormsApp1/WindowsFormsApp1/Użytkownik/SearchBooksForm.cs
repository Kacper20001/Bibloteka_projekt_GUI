using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Klasy;
using WindowsFormsApp1.Interfejsy;

namespace WindowsFormsApp1
{
    public partial class SearchBooksForm : Form
    {
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        private int currentReaderId;

        public SearchBooksForm(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            LoadBooks();
        }

        private void SrcBooksBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSrcBooks.Text;
            LoadBooks(searchTerm);
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SrcReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderMenu readerMenu = new ReaderMenu(currentReaderId);
            readerMenu.Show();
        }

        private void Borrowbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in booksDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["BorrowCheckbox"].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookID"].Value);
                    IBorrowBookHandle bookHandle = new BorrowBookHandle();
                    bookHandle.BorrowBook(currentReaderId, bookId);
                }
            }
            LoadBooks();
        }
        public void LoadBooks(string searchTerm = "")
        {
            IBookHandle bookHandle = new BookHandle();
            booksDataGridView.DataSource = bookHandle.LoadBooks(searchTerm);
        }
        private void SearchBooksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
