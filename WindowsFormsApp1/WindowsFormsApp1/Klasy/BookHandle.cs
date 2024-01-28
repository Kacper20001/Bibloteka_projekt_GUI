using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfejsy;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Klasy
{
    internal class BookHandle : IBookHandle
    {
        public Book GetBookById(int bookId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookId, Title, Author, Year, Description, Availability FROM Books WHERE BookId = @BookId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    connection.Open();
                    using (SqlDataReader book = command.ExecuteReader())
                    {
                        if (book.Read())
                        {
                            return new Book(
                                book["Title"].ToString(),
                                book["Author"].ToString(),
                                Convert.ToInt32(book["Year"]),
                                book["Description"].ToString(),
                                book["Availability"].ToString());
                        }
                    }
                }
            }
            return null;
        }
        public DataTable LoadBooks(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
            {
                string query;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    query = "SELECT BookId, Title, Author, Year, Description, Availability FROM Books";
                }
                else
                {
                    query = "SELECT BookId, Title, Author, Year, Description, Availability FROM Books WHERE Title LIKE @SearchTerm OR Author LIKE @SearchTerm";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public void EditBook(string connectionString, int id, string newTitle, string newAuthor, string newDescription, int newYear)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Books SET Title = @Title, Author = @Author, Year = @Year, Description = @Description WHERE BookId = @BookId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", id);
                    command.Parameters.AddWithValue("@Title", newTitle);
                    command.Parameters.AddWithValue("@Author", newAuthor);
                    command.Parameters.AddWithValue("@Year", newYear);
                    command.Parameters.AddWithValue("@Description", newDescription);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteBook(int id)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
            {
                string query = "DELETE FROM Books WHERE BookId = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("No book found with the given ID.");
                    }
                    else
                    {
                        MessageBox.Show("Book deleted successfully.");
                    }
                }
            }
        }
        public void ReturnBook(int bookId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkOverdueQuery = @"
            SELECT CASE 
                WHEN DATEDIFF(day, BorrowDate, GETDATE()) > 30 THEN DATEDIFF(day, BorrowDate, GETDATE()) - 30
                ELSE 0
            END AS OverdueDays
            FROM Borrows
            WHERE BookId = @BookId";

                using (SqlCommand checkCommand = new SqlCommand(checkOverdueQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@BookId", bookId);
                    int overdueDays = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (overdueDays > 0)
                    {
                        MessageBox.Show("Cannot return the book. There is an overdue.");
                        return;
                    }
                }

                string returnQuery = @"
                DELETE FROM Borrows WHERE BookId = @BookId;
                UPDATE Books SET Availability = 1 WHERE BookId = @BookId;";

                using (SqlCommand command = new SqlCommand(returnQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddBook(string title, string author, int year, string description)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
            {
                string query = "INSERT INTO Books(title, author, year, description, availability)" +
                               "VALUES(@title, @author, @year, @description, 1)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@description", description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
