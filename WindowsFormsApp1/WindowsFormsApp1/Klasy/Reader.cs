using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Reader : Person
    {
        public int Id {  get; private set; }
        private static int nextId = 1;
        public string Password {  get; set; }
        public string Username {  get; set; }
        public new Address Address { get; set; }

        public Reader(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, string password, string username)
        : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
        {
            Id = nextId++;
            Username = username;
            Password = password;
        }
        public static Reader GetReader(string username, string passwordHash)
        {
            Reader foundReader = null;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
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
                                reader["Password"].ToString(), reader["Username"].ToString());
                        }
                    }
                }
            }
            return foundReader;
        }
        public static Reader GetReaderById(int readerId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country" +
                               " FROM Readers WHERE Id = @ReaderId";
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
                                ""  // Username
                            );
                        }
                    }
                }
            }
            return null;
        }
        public static DataTable LoadReaders(string connectionString, string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    query = "SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country" +
                               "FROM Readers";
                }
                else
                {
                    query = "SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country" +
                               "FROM Readers WHERE FirstName LIKE @SearchTerm OR @LastName LIKE @SearchTerm OR @Id LIKE @SearchTerm";
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
        public static void DeleteReader(int id, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Readers WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("No Reader found with the given ID.");
                    }
                    else
                    {
                        MessageBox.Show("Reader deleted successfully.");
                    }
                }
            }
        }

    }
}
