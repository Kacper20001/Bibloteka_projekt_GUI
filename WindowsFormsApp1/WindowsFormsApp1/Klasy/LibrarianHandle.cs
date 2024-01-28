using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp1.Interfejsy;
using System.Data;
using System.Windows.Forms;
using System.IO.Packaging;

namespace WindowsFormsApp1.Klasy
{
    internal class LibrarianHandle : ILibrarianHandle
    {
        public Librarian GetLibrarian(int employeeNumber, string password, string connectionString)
        {
            Librarian foundLibrarian = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Librarians WHERE EmployeeNumber = @EmployeeNumber AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    using (SqlDataReader librarian = command.ExecuteReader())
                    {
                        if (librarian.Read())
                        {
                            foundLibrarian = new Librarian(librarian["password"].ToString(), librarian["firstName"].ToString(), librarian["lastName"].ToString(), Convert.ToDateTime(librarian["dateOfBirth"]),
                                librarian["phoneNumber"].ToString(), librarian["email"].ToString(), new Address(librarian["Street"].ToString(), librarian["HouseNumber"].ToString(), librarian["PostalCode"].ToString(),
                                librarian["City"].ToString(), librarian["Country"].ToString()), Convert.ToInt32(librarian["EmployeeNumber"].ToString()))
                            {
                                LibrarianId = Convert.ToInt32(librarian["EmployeeId"])
                            };
                        }
                    }
                }
            }
            return foundLibrarian;
        }
        public Librarian GetLibrarianById(int librarianId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country, EmployeeNumber
                               FROM Librarians WHERE EmployeeId = @LibrarianId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LibrarianId", librarianId);
                    connection.Open();
                    using (SqlDataReader librarian = command.ExecuteReader())
                    {
                        if (librarian.Read())
                        {
                            Address address = new Address(
                                librarian["Street"].ToString(),
                                librarian["HouseNumber"].ToString(),
                                librarian["PostalCode"].ToString(),
                                librarian["City"].ToString(),
                                librarian["Country"].ToString());

                            return new Librarian("",
                                librarian["FirstName"].ToString(),
                                librarian["LastName"].ToString(),
                                Convert.ToDateTime(librarian["DateOfBirth"]),
                                librarian["PhoneNumber"].ToString(),
                                librarian["Email"].ToString(),
                                address, Convert.ToInt32(librarian["EmployeeNumber"].ToString())
                            );
                        }
                    }
                }
            }
            return null;
        }
        public DataTable LoadLibrarians(string connectionString, string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    query = @"SELECT EmployeeId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country
                               FROM Librarians";
                }
                else
                {
                    query = @"SELECT EmployeeId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country 
                               FROM Librarians WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR EmployeeId LIKE @SearchTerm";
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
        public void DeleteLibrarian(int id, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Usunięcie bibliotekarza
                string deleteLibrarianrQuery = "DELETE FROM Librarians WHERE EmployeeId = @LibrarianId";
                using (SqlCommand deleteLibrarianCommand = new SqlCommand(deleteLibrarianrQuery, connection))
                {
                    deleteLibrarianCommand.Parameters.AddWithValue("@LibrarianId", id);
                    int affectedRows = deleteLibrarianCommand.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("No Librarian found with the given ID.");
                    }
                    else
                    {
                        MessageBox.Show("Account deleted successfully.");
                    }
                }

                connection.Close();
            }
        }
        public void SaveLibrarianInDatabase(Librarian librarian, string connectionString)
        {
            string insertDataQuery = "INSERT INTO Librarians (EmployeeNumber, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) VALUES (@EmployeeNumber, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Street, @City, @HouseNumber, @PostalCode, @Country)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@EmployeeNumber", librarian.EmployeeNumber);
                    insertDataCommand.Parameters.AddWithValue("@Password", librarian.Password);
                    insertDataCommand.Parameters.AddWithValue("@FirstName", librarian.FirstName);
                    insertDataCommand.Parameters.AddWithValue("@LastName", librarian.LastName);
                    insertDataCommand.Parameters.AddWithValue("@DateOfBirth", librarian.DateOfBirth);
                    insertDataCommand.Parameters.AddWithValue("@Email", librarian.Email);
                    insertDataCommand.Parameters.AddWithValue("@PhoneNumber", librarian.PhoneNumber);
                    insertDataCommand.Parameters.AddWithValue("@Street", librarian.Address.Street);
                    insertDataCommand.Parameters.AddWithValue("@City", librarian.Address.City);
                    insertDataCommand.Parameters.AddWithValue("@HouseNumber", librarian.Address.HouseNumber);
                    insertDataCommand.Parameters.AddWithValue("@PostalCode", librarian.Address.PostalCode);
                    insertDataCommand.Parameters.AddWithValue("@Country", librarian.Address.Country);

                    try
                    {
                        insertDataCommand.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zarejestrowano");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd przy dodawaniu danych: {ex.Message}");
                    }
                }
            }
        }
        public void EditLibrarian(string connectionString, int LibrarianId, string LastName, string PhoneNumber, string Street, string HouseNumber, string PostalCode, string City, string Country)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Librarians 
                                SET LastName = @LastName, PhoneNumber = @PhoneNumber, Street = @Street, HouseNumber = @HouseNumber, PostalCode = @PostalCode, City = @City, Country = @Country
                                WHERE EmployeeId = @LibrarianId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LibrarianId", LibrarianId);
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
