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
        public  DataTable LoadOverdueBooks()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
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
