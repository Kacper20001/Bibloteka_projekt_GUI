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
        public Reader GetReaders(string username, string passwordHash, string connectionString)
        {
            Reader foundReader = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Readers WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", passwordHash);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundReader = new Reader(
                                reader["FirstName"].ToString(), reader["LastName"].ToString(),
                                Convert.ToDateTime(reader["DateOfBirth"]), reader["PhoneNumber"].ToString(),
                                reader["Email"].ToString(),
                                new Address(reader["Street"].ToString(), reader["HouseNumber"].ToString(),
                                reader["PostalCode"].ToString(), reader["City"].ToString(),
                                reader["Country"].ToString()),
                                reader["Password"].ToString(), reader["Username"].ToString())
                            {
                                ReaderId = Convert.ToInt32(reader["ReaderId"])
                            };
                        }
                    }
                }
            }
            return foundReader;
        }
        public Reader GetReaderById(int readerId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName, DateOfBirth, Email, Username, PhoneNumber, Street, City, HouseNumber, PostalCode, Country" +
                               " FROM Readers WHERE ReaderId = @ReaderId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReaderId", readerId);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Address address = new Address(
                                reader["Street"].ToString(),
                                reader["HouseNumber"].ToString(),
                                reader["PostalCode"].ToString(),
                                reader["City"].ToString(),
                                reader["Country"].ToString());

                            return new Reader(
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                Convert.ToDateTime(reader["DateOfBirth"]),
                                reader["PhoneNumber"].ToString(),
                                reader["Email"].ToString(),
                                address,
                                "", // Password
                                reader["Username"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }
        public DataTable LoadReaders(string connectionString, string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    query = @"SELECT ReaderId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country
                               FROM Readers";
                }
                else
                {
                    query = @"SELECT ReaderId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country 
                               FROM Readers WHERE FirstName LIKE @SearchTerm OR @LastName LIKE @SearchTerm OR @ReaderId LIKE @SearchTerm";
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
        public void DeleteReader(int id, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Ustawienie książek jako dostępne
                string updateBooksQuery = "UPDATE Books SET Availability = 1 WHERE BookId IN (SELECT BookId FROM Borrows WHERE ReaderId = @ReaderId)";
                using (SqlCommand updateBooksCommand = new SqlCommand(updateBooksQuery, connection))
                {
                    updateBooksCommand.Parameters.AddWithValue("@ReaderId", id);
                    updateBooksCommand.ExecuteNonQuery();
                }

                // Usunięcie wypożyczeń czytelnika
                string deleteBorrowsQuery = "DELETE FROM Borrows WHERE ReaderId = @ReaderId";
                using (SqlCommand deleteBorrowsCommand = new SqlCommand(deleteBorrowsQuery, connection))
                {
                    deleteBorrowsCommand.Parameters.AddWithValue("@ReaderId", id);
                    deleteBorrowsCommand.ExecuteNonQuery();
                }

                // Usunięcie czytelnika
                string deleteReaderQuery = "DELETE FROM Readers WHERE ReaderId = @ReaderId";
                using (SqlCommand deleteReaderCommand = new SqlCommand(deleteReaderQuery, connection))
                {
                    deleteReaderCommand.Parameters.AddWithValue("@ReaderId", id);
                    int affectedRows = deleteReaderCommand.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("No Reader found with the given ID.");
                    }
                    else
                    {
                        MessageBox.Show("Reader deleted successfully.");
                    }
                }

                connection.Close(); // Zamknięcie połączenia
            }
        }
        public void SaveReaderInDatabese(Reader reader, string connectionString)
        {
            string insertDataQuery = "INSERT INTO dbo.Readers (Username, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) VALUES (@Username, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Street, @City, @HouseNumber, @PostalCode, @Country)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@Username", reader.Username);
                    insertDataCommand.Parameters.AddWithValue("@Password", reader.Password);
                    insertDataCommand.Parameters.AddWithValue("@FirstName", reader.FirstName);
                    insertDataCommand.Parameters.AddWithValue("@LastName", reader.LastName);
                    insertDataCommand.Parameters.AddWithValue("@DateOfBirth", reader.DateOfBirth.ToString("yyyy-MM-dd"));
                    insertDataCommand.Parameters.AddWithValue("@Email", reader.Email);
                    insertDataCommand.Parameters.AddWithValue("@PhoneNumber", reader.PhoneNumber);

                    insertDataCommand.Parameters.AddWithValue("@Street", reader.Address.Street);
                    insertDataCommand.Parameters.AddWithValue("@City", reader.Address.City);
                    insertDataCommand.Parameters.AddWithValue("@HouseNumber", reader.Address.HouseNumber);
                    insertDataCommand.Parameters.AddWithValue("@PostalCode", reader.Address.PostalCode);
                    insertDataCommand.Parameters.AddWithValue("@Country", reader.Address.Country);
                    try
                    {
                        insertDataCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully registered.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while adding data {ex.Message}");
                    }
                }

            }
        }
        public void EditReader(string connectionString, int ReaderId, string LastName, string PhoneNumber, string Street, string HouseNumber, string PostalCode, string City, string Country)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Readers 
                                SET LastName = @LastName, PhoneNumber = @PhoneNumber, Street = @Street, HouseNumber = @HouseNumber, PostalCode = @PostalCode, City = @City, Country = @Country
                                WHERE ReaderId = @ReaderId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReaderId", ReaderId);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@Street", Street);
                    command.Parameters.AddWithValue("@HouseNumber", HouseNumber);
                    command.Parameters.AddWithValue("@PostalCode", PostalCode);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Country", Country);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
