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
    public partial class ReaderBorrowedBooksForm : Form
    {
        private int currentReaderId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";

        public ReaderBorrowedBooksForm(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            LoadBoorowedBooksDataGrid(currentReaderId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderMenu readerMenu = new ReaderMenu(currentReaderId);
            readerMenu.Show();
        }
        
       

        private void returnBookbtn_Click(object sender, EventArgs e)
        {
            IBookHandle bookHandle = new BookHandle();
            foreach (DataGridViewRow row in borrowedBooksDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectBookCheckbox"].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookID"].Value);
                    bookHandle.ReturnBook(bookId, connectionString);
                }
            }
            LoadBoorowedBooksDataGrid(currentReaderId);
        }

        private void borrowedBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadBoorowedBooksDataGrid(int readerId)
        {
            IBorrowBookHandle bookHandle = new BorrowBookHandle();
            borrowedBooksDataGridView.DataSource = bookHandle.LoadBorrowedBooks(readerId);
        }
    }
}
