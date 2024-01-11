using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
        public void BorrowBook(int readerId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Sprawdzenie dostępności książki

                string checkQuery = "SELECT IsAvailable FROM Books WHERE Id = @BookId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@BookId", this.Id);
                    bool isAvailable = Convert.ToBoolean(checkCommand.ExecuteScalar());

                    if (!isAvailable)
                    {
                        MessageBox.Show("This book is not available for borrowing.");
                        return;
                    }
                }

                // Aktualizacja statusu książki
                string updateQuery = "UPDATE Books SET IsAvailable = 0 WHERE Id = @BookId";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", this.Id);
                    command.ExecuteNonQuery();
                }

                // Dodanie wpisu do tabeli wypożyczeń
                string insertQuery = "INSERT INTO Borrows (BookId, ReaderId, BorrowDate) VALUES (@BookId, @ReaderId, @BorrowDate)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookId", this.Id);
                    command.Parameters.AddWithValue("@ReaderId", readerId);
                    command.Parameters.AddWithValue("@BorrowDate", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
