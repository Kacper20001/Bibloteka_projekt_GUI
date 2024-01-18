using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Web;

namespace WindowsFormsApp1
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public Book(int id, string title, string author, int year, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Description = description;
        }
        public static void BorrowBook(int readerId, int bookId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Sprawdzenie dostępności książki i jej wypożyczenie
                string borrowQuery = @"
            BEGIN TRANSACTION;
            UPDATE Books SET IsAvailable = 0 WHERE Id = @BookId AND IsAvailable = 1;
            INSERT INTO Borrows (BookId, ReaderId, BorrowDate, ExpectedReturnDate) 
            VALUES (@BookId, @ReaderId, GETDATE(), DATEADD(day, 30, GETDATE()));
            COMMIT;";

                using (SqlCommand command = new SqlCommand(borrowQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@ReaderId", readerId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static Book GetBookById(int bookId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = "SELECT Id, Title, Author, Year, Description FROM Books WHERE Id = @BookId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    connection.Open();
                    using (SqlDataReader book = command.ExecuteReader())
                    {
                        if (book.Read())
                        {
                            return new Book(
                                Convert.ToInt32(book["Id"]),
                                book["Title"].ToString(),
                                book["Author"].ToString(),
                                Convert.ToInt32(book["Year"]),
                                book["Description"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }
        public static DataTable LoadBooks(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query;
                if (string.IsNullOrEmpty(searchTerm)){
                    query = "SELECT Id, Title, Author, Year, Description, Availability FROM Books";
                }
                else
                {
                    query = "SELECT Id, Title, Author, Year, Description, Availability FROM Books WHERE Title LIKE @SearchTerm OR Author LIKE @SearchTerm";
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

        public static void EditBook(int id, string newTitle, string newAuthor, string newDescription, int newYear)  
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = "Update @Title, @Author, @Year, @Description FROM Books Where Id = @BookId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", id);
                    command.Parameters.AddWithValue("@Title", newTitle);
                    command.Parameters.AddWithValue("@Author", newAuthor);
                    command.Parameters.AddWithValue("@Year", Convert.ToInt32(newYear));
                    command.Parameters.AddWithValue("@Description", newDescription);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void AddBook(int id, string title, string author, int year, string description) // ogarnąć, żeby id automatycznie nowe się pojawiało ?
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = "INSERT INTO Books(id, title, author, year, description)" +
                               "VALUES(@id, @title, @author, @year, @description)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id );
                    command.Parameters.AddWithValue("@title", title );
                    command.Parameters.AddWithValue("@author", author );
                    command.Parameters.AddWithValue("@year", year );
                    command.Parameters.AddWithValue("@description", description );
                    connection.Open();    
                    command.ExecuteNonQuery();
                }

            }
        }

        public static void DeleteBook(int id)
        {
            using (SqlConnection  connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = "DELETE FROM Books WHERE id = @id";
                using(SqlCommand command = new SqlCommand(query, connection))
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
        public static void ReturnBook(int bookId, string connectionString)
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
            WHERE BookId = @BookId AND ReturnDate IS NULL;";

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
            UPDATE Borrows SET ReturnDate = GETDATE() 
            WHERE BookId = @BookId AND ReturnDate IS NULL;
            UPDATE Books SET IsAvailable = 1 WHERE Id = @BookId;";

                using (SqlCommand command = new SqlCommand(returnQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable LoadBorrowedBooks(int readerId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
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
                    command.Parameters.AddWithValue("@ReaderId", readerId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
        }
        public static DataTable LoadOverdueBooks()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = @"
                SELECT 
                    b.BookId, 
                    b.ReaderId, 
                    bk.Title, 
                    bk.Author, 
                    b.BorrowDate, 
                    DATEADD(day, 30, b.BorrowDate) AS ExpectedReturnDate, 
                    CASE 
                        WHEN DATEDIFF(day, b.BorrowDate, GETDATE()) > 30 THEN DATEDIFF(day, b.BorrowDate, GETDATE()) - 30 
                        ELSE 0 
                    END AS OverdueFee
                FROM Borrows b
                INNER JOIN Books bk ON b.BookId = bk.Id
                WHERE b.ReturnDate IS NULL AND DATEDIFF(day, b.BorrowDate, GETDATE()) > 30";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static void ReturnOverdueBook(int bookId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                connection.Open();

                // Aktualizacja rekordu wypożyczenia
                string returnQuery = @"
                UPDATE Borrows SET ReturnDate = GETDATE() 
                WHERE BookId = @BookId AND ReturnDate IS NULL;
                UPDATE Books SET IsAvailable = 1 WHERE Id = @BookId;";

                using (SqlCommand command = new SqlCommand(returnQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
