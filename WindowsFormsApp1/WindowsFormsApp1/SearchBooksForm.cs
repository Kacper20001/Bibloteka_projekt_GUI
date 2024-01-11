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
    public partial class SearchBooksForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True";
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

        private void LoadBooks(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Title LIKE @SearchTerm OR Author LIKE @SearchTerm";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    booksDataGridView.DataSource = dataTable;
                }
            }
        }

        private Book GetBookById(int bookId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Title, Author, Year, Description FROM Books WHERE Id = @BookId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Book(
                                Convert.ToInt32(reader["Id"]),
                                reader["Title"].ToString(),
                                reader["Author"].ToString(),
                                Convert.ToInt32(reader["Year"]),
                                reader["Description"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e){}

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
                    int bookId = Convert.ToInt32(row.Cells["Id"].Value);
                    Book bookToBorrow = GetBookById(bookId);
                    bookToBorrow.BorrowBook(currentReaderId, connectionString);
                }
            }
            LoadBooks();
        }
    }
}
