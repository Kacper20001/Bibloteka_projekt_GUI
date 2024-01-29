using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp1.Interfejsy;
using System.Windows.Forms;

namespace WindowsFormsApp1.Klasy
{
    internal class BorrowBookHandle : IBorrowBookHandle
    {
        private readonly DatabaseHelper dbHelper;

        public BorrowBookHandle(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }
        public void BorrowBook(int readerId, int bookId)
        {
            try
            {
                string borrowQuery = @"
                    BEGIN TRANSACTION;
                    UPDATE Books SET Availability = 0 WHERE BookID = @BookID AND Availability = 1;
                    INSERT INTO Borrows (BookId, ReaderId, BorrowDate, ExpectedReturnDate) 
                    VALUES (@BookId, @ReaderId, GETDATE(), DATEADD(day, 30, GETDATE()));
                    COMMIT;";

                SqlParameter[] parameters = {
                    new SqlParameter("@BookID", bookId),
                    new SqlParameter("@ReaderId", readerId)
                };

                dbHelper.ExecuteNonQuery(borrowQuery, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while borrowing a book: {ex.Message}");
            }
        }

        public DataTable LoadBorrowedBooks(int readerId)
        {
            try
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

                SqlParameter[] parameters = {
                    new SqlParameter("@ReaderId", readerId)
                };
                return dbHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading borrowed books: {ex.Message}");
                return null;
            }
        }
        public DataTable LoadAllBorrowedBooks(string connectionString)
        {
            try
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

                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading all borrowed books: {ex.Message}");
                return null; 
            }
        }
    }
    
}
