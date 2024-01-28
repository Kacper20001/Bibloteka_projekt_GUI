using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp1.Interfejsy;

namespace WindowsFormsApp1.Klasy
{
    internal class BorrowBookHandle : IBorrowBookHandle
    {
        public  void BorrowBook(int readerId, int bookId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                // Sprawdzenie dostępności książki i jej wypożyczenie
                string borrowQuery = @"
            BEGIN TRANSACTION;
            UPDATE Books SET Availability = 0 WHERE BookID = @BookID AND Availability = 1;
            INSERT INTO Borrows (BookId, ReaderId, BorrowDate, ExpectedReturnDate) 
            VALUES (@BookId, @ReaderId, GETDATE(), DATEADD(day, 30, GETDATE()));
            COMMIT;";

                using (SqlCommand command = new SqlCommand(borrowQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookId);
                    command.Parameters.AddWithValue("@ReaderId", readerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public  DataTable LoadBorrowedBooks(int readerId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
            SELECT b.BookId, bk.Title, bk.Author, b.BorrowDate, 
                   CASE 
                       WHEN DATEDIFF(day, b.BorrowDate, b.ExpectedReturnDate) > 30 THEN DATEDIFF(day, b.BorrowDate, GETDATE()) - 30
                       ELSE 0
                   END AS OverdueFee
            FROM Borrows b
            INNER JOIN Books bk ON b.BookId = bk.BookID
            WHERE b.ReaderId = @ReaderId";

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
        public  DataTable LoadAllBorrowedBooks(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    b.BookId, 
                    b.ReaderId, 
                    b.BorrowDate, 
                    b.ExpectedReturnDate,
                    CASE 
                        WHEN DATEDIFF(day, b.BorrowDate, GETDATE()) > 30 THEN DATEDIFF(day, b.BorrowDate, GETDATE()) - 30 
                        ELSE 0 
                    END AS OverdueFee
                FROM Borrows b";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
