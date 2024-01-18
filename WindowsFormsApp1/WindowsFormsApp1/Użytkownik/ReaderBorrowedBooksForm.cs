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

namespace WindowsFormsApp1
{
    public partial class ReaderBorrowedBooksForm : Form
    {
        private int currentReaderId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True";

        public ReaderBorrowedBooksForm(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            Book.LoadBorrowedBooks(currentReaderId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderMenu readerMenu = new ReaderMenu(currentReaderId);
            readerMenu.Show();
        }
        
       

        private void returnBookbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in borrowedBooksDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectBookCheckbox"].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                    Book.ReturnBook(bookId, connectionString);
                }
            }
            Book.LoadBorrowedBooks(currentReaderId);
        }

        private void borrowedBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
