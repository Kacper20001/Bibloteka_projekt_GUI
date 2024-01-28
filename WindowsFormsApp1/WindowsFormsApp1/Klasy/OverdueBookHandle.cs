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
    internal class OverdueBookHandle  : IOverdueBook
    {
        private readonly DatabaseHelper dbHelper;

        public OverdueBookHandle(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }
        public DataTable LoadOverdueBooks()
        {
            string query = @"
                SELECT 
                    b.BookId, 
                    b.ReaderId, 
                    bk.Title, 
                    bk.Author, 
                    b.BorrowDate, 
                    b.ExpectedReturnDate, 
                    CASE 
                        WHEN DATEDIFF(day, b.BorrowDate, GETDATE()) > 30 THEN DATEDIFF(day, b.BorrowDate, GETDATE()) - 30 
                        ELSE 0 
                    END AS OverdueFee
                FROM Borrows b
                INNER JOIN Books bk ON b.BookId = bk.BookID
                WHERE DATEDIFF(day, b.BorrowDate, GETDATE()) > 30";

            return dbHelper.ExecuteQuery(query);
        }
    }
}
