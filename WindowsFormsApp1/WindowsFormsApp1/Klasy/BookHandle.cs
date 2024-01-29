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
        private readonly DatabaseHelper dbHelper;

        public BookHandle(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }
        public Book GetBookById(int bookId)
        {
                string query = "SELECT BookId, Title, Author, Year, Description, Availability FROM Books WHERE BookId = @BookId";
            SqlParameter[] parameters = { new SqlParameter("@BookId", bookId) };
            DataTable bookTable = dbHelper.ExecuteQuery(query, parameters);

            if (bookTable.Rows.Count > 0)
            {
                DataRow row = bookTable.Rows[0];
                return new Book(
                    row["Title"].ToString(),
                    row["Author"].ToString(),
                    Convert.ToInt32(row["Year"]),
                    row["Description"].ToString(),
                    row["Availability"].ToString());
            }

            return null;
        }
        public DataTable LoadBooks(string searchTerm = "")
        {
            try
            {
                string query;
                SqlParameter[] parameters = null;

                if (string.IsNullOrEmpty(searchTerm))
                {
                    query = "SELECT BookId, Title, Author, Year, Description, Availability FROM Books";
                }
                else
                {
                    query = "SELECT BookId, Title, Author, Year, Description, Availability FROM Books WHERE Title LIKE @SearchTerm OR Author LIKE @SearchTerm";
                    parameters = new[] { new SqlParameter("@SearchTerm", $"%{searchTerm}%") };
                }

                return dbHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books: {ex.Message}");
                return null;
            }
        }
        public void EditBook(int id, string newTitle, string newAuthor, string newDescription, int newYear)
        {
            try
            {
                string query = "UPDATE Books SET Title = @Title, Author = @Author, Year = @Year, Description = @Description WHERE BookId = @BookId";

                SqlParameter[] parameters = {
                    new SqlParameter("@BookId", id),
                    new SqlParameter("@Title", newTitle),
                    new SqlParameter("@Author", newAuthor),
                    new SqlParameter("@Year", newYear),
                    new SqlParameter("@Description", newDescription)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while editing a book: {ex.Message}");
            }
        }

        public void DeleteBook(int id)
        {
            try
            {
                string query = "DELETE FROM Books WHERE BookId = @id";
                SqlParameter[] parameters = {
                    new SqlParameter("@id", id)
                };
                int affectedRows = dbHelper.ExecuteNonQuery(query, parameters);

                if (affectedRows == 0)
                {
                    MessageBox.Show("No book found with the given ID.");
                }
                else
                {
                    MessageBox.Show("Book deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting a book: {ex.Message}");
            }
        }
        public void ReturnBook(int bookId)
        {
            try
            {
                string checkOverdueQuery = @"
                    SELECT CASE 
                        WHEN DATEDIFF(day, BorrowDate, GETDATE()) > 30 THEN DATEDIFF(day, BorrowDate, GETDATE()) - 30
                        ELSE 0
                    END AS OverdueDays
                    FROM Borrows
                    WHERE BookId = @BookId";
                SqlParameter[] checkParams = { new SqlParameter("@BookId", bookId) };

                object overdueDays = dbHelper.ExecuteScalar(checkOverdueQuery, checkParams);

                if (Convert.ToInt32(overdueDays) > 0)
                {
                    MessageBox.Show("Cannot return the book. There is an overdue.");
                    return;
                }

                string returnQuery = @"
                    DELETE FROM Borrows WHERE BookId = @BookId;
                    UPDATE Books SET Availability = 1 WHERE BookId = @BookId;";
                SqlParameter[] returnParams = { new SqlParameter("@BookId", bookId) };

                dbHelper.ExecuteNonQuery(returnQuery, returnParams);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while returning a book: {ex.Message}");
            }
        }

        public void AddBook(string title, string author, int year, string description)
        {
            try
            {
                string query = "INSERT INTO Books(title, author, year, description, availability) VALUES(@title, @author, @year, @description, 1)";
                SqlParameter[] parameters = {
                    new SqlParameter("@title", title),
                    new SqlParameter("@author", author),
                    new SqlParameter("@year", year),
                    new SqlParameter("@description", description)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding a book: {ex.Message}");
            }
        }
    }
}
