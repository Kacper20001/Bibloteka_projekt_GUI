using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class BorrowedBooksForm : Form
    {
        private int currentReaderId;

        public BorrowedBooksForm(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            Book.LoadBorrowedBooks();
        }

        private void BorrowedBooksForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentReaderId);
            librarianMenu.Show();
        }

        private void ReturnBooksBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridBorrowed.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectToReturn"].Value);
                if(isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["book_id"].Value);
                    Book.ReturnBook(bookId);
                }
            }
            Book.LoadBorrowedBooks();
        }
    }
}
