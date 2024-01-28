using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfejsy;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Klasy
{
    internal class ReaderHandle : IReaderHandle
    {
        private readonly DatabaseHelper dbHelper; 
        public ReaderHandle(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }

        public Reader GetReaders(string username, string passwordHash)
        {
            string query = "SELECT * FROM Readers WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", passwordHash)
            };

            DataTable readerData = dbHelper.ExecuteQuery(query, parameters);

            if (readerData.Rows.Count > 0)
            {
                DataRow row = readerData.Rows[0];
                return new Reader(
                    row["FirstName"].ToString(), row["LastName"].ToString(),
                    Convert.ToDateTime(row["DateOfBirth"]), row["PhoneNumber"].ToString(),
                    row["Email"].ToString(),
                    new Address(row["Street"].ToString(), row["HouseNumber"].ToString(),
                                row["PostalCode"].ToString(), row["City"].ToString(),
                                row["Country"].ToString()),
                    row["Password"].ToString(), row["Username"].ToString())
                {
                    ReaderId = Convert.ToInt32(row["ReaderId"])
                };
            }

            return null;
        }
        public Reader GetReaderById(int readerId)
        {
            string query = "SELECT FirstName, LastName, DateOfBirth, Email, Username, PhoneNumber, Street, City, HouseNumber, PostalCode, Country FROM Readers WHERE ReaderId = @ReaderId";
            SqlParameter[] parameters = { new SqlParameter("@ReaderId", readerId) };

            DataTable readerData = dbHelper.ExecuteQuery(query, parameters);

            if (readerData.Rows.Count > 0)
            {
                DataRow row = readerData.Rows[0];
                Address address = new Address(row["Street"].ToString(), row["HouseNumber"].ToString(), row["PostalCode"].ToString(), row["City"].ToString(), row["Country"].ToString());
                return new Reader(
                    row["FirstName"].ToString(), row["LastName"].ToString(),
                    Convert.ToDateTime(row["DateOfBirth"]), row["PhoneNumber"].ToString(),
                    row["Email"].ToString(), address, "", row["Username"].ToString());
            }

            return null;
        }
        public DataTable LoadReaders(string searchTerm = "")
        {
            string query;
            SqlParameter[] parameters = null;

            if (string.IsNullOrEmpty(searchTerm))
            {
                query = "SELECT ReaderId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country FROM Readers";
            }
            else
            {
                query = "SELECT ReaderId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country FROM Readers WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR ReaderId LIKE @SearchTerm";
                parameters = new[] { new SqlParameter("@SearchTerm", $"%{searchTerm}%") };
            }

            return dbHelper.ExecuteQuery(query, parameters);
        }
        public void DeleteReader(int id)
        {
            // Ustawienie książek jako dostępne
            string updateBooksQuery = "UPDATE Books SET Availability = 1 WHERE BookId IN (SELECT BookId FROM Borrows WHERE ReaderId = @ReaderId)";
            SqlParameter[] bookParams = { new SqlParameter("@ReaderId", id) };
            dbHelper.ExecuteNonQuery(updateBooksQuery, bookParams);

            // Usunięcie wypożyczeń czytelnika
            string deleteBorrowsQuery = "DELETE FROM Borrows WHERE ReaderId = @ReaderId";
            dbHelper.ExecuteNonQuery(deleteBorrowsQuery, bookParams);

            // Usunięcie czytelnika
            string deleteReaderQuery = "DELETE FROM Readers WHERE ReaderId = @ReaderId";
            int affectedRows = dbHelper.ExecuteNonQuery(deleteReaderQuery, bookParams);

            if (affectedRows == 0)
            {
                MessageBox.Show("No Reader found with the given ID.");
            }
            else
            {
                MessageBox.Show("Reader deleted successfully.");
            }
        }
        public void SaveReaderInDatabase(Reader reader)
        {
            string insertDataQuery = "INSERT INTO dbo.Readers (Username, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) VALUES (@Username, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Street, @City, @HouseNumber, @PostalCode, @Country)";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", reader.Username),
                new SqlParameter("@Password", reader.Password),
                new SqlParameter("@FirstName", reader.FirstName),
                new SqlParameter("@LastName", reader.LastName),
                new SqlParameter("@DateOfBirth", reader.DateOfBirth.ToString("yyyy-MM-dd")),
                new SqlParameter("@Email", reader.Email),
                new SqlParameter("@PhoneNumber", reader.PhoneNumber),
                new SqlParameter("@Street", reader.Address.Street),
                new SqlParameter("@City", reader.Address.City),
                new SqlParameter("@HouseNumber", reader.Address.HouseNumber),
                new SqlParameter("@PostalCode", reader.Address.PostalCode),
                new SqlParameter("@Country", reader.Address.Country)
            };

            dbHelper.ExecuteNonQuery(insertDataQuery, parameters);
            MessageBox.Show("Reader successfully registered.");
        }
        public void EditReader(int readerId, string lastName, string phoneNumber, string street, string houseNumber, string postalCode, string city, string country)
        {
            string query = "UPDATE Readers SET LastName = @LastName, PhoneNumber = @PhoneNumber, Street = @Street, HouseNumber = @HouseNumber, PostalCode = @PostalCode, City = @City, Country = @Country WHERE ReaderId = @ReaderId";
            SqlParameter[] parameters = {
                new SqlParameter("@ReaderId", readerId),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Street", street),
                new SqlParameter("@HouseNumber", houseNumber),
                new SqlParameter("@PostalCode", postalCode),
                new SqlParameter("@City", city),
                new SqlParameter("@Country", country)
            };

            dbHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Reader details updated successfully.");
        }

    }
}
