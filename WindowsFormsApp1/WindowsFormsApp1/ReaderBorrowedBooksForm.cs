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
        private string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True";
        private int currentReaderId;
        public ReaderBorrowedBooksForm(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            LoadBorrowedBooks();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderMenu readerMenu = new ReaderMenu(currentReaderId);
            readerMenu.Show();
        }
        private void LoadBorrowedBooks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT b.BookId, bk.Title, bk.Author, b.BorrowDate, 
                   CASE 
                       WHEN DATEDIFF(day, b.BorrowDate, GETDATE()) > 30 THEN DATEDIFF(day, b.BorrowDate, GETDATE()) - 30
                       ELSE 0
                   END AS OverdueFee
            FROM Borrows b
            INNER JOIN Books bk ON b.BookId = bk.Id
            WHERE b.ReaderId = @ReaderId AND b.ReturnDate IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReaderId", currentReaderId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    borrowedBooksDataGridView.DataSource = dataTable;
                }

            }
        }
        private void ReturnBook(int bookId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"
            UPDATE Borrows 
            SET ReturnDate = GETDATE()
            WHERE BookId = @BookId AND ReaderId = @ReaderId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@ReaderId", currentReaderId);
                    command.ExecuteNonQuery();
                }
                string updateBookQuery = "UPDATE Books SET IsAvailable = 1 WHERE Id = @BookId";
                using (SqlCommand command = new SqlCommand(updateBookQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.ExecuteNonQuery();
                }
            }
            LoadBorrowedBooks(); // Odświeżenie listy wypożyczonych książek
        }

        private void returnBookbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in borrowedBooksDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectBookCheckbox"].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                    ReturnBook(bookId);
                }
            }
            LoadBorrowedBooks();
        }

        private void borrowedBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
