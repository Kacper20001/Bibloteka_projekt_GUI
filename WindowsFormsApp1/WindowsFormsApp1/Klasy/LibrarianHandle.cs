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
        private readonly DatabaseHelper dbHelper;
        public LibrarianHandle(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }
        public Librarian GetLibrarian(int employeeNumber, string password)
        {
            string query = "SELECT * FROM Librarians WHERE EmployeeNumber = @EmployeeNumber AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeNumber", employeeNumber),
                new SqlParameter("@Password", password)
            };

            DataTable librarianTable = dbHelper.ExecuteQuery(query, parameters);

            if (librarianTable.Rows.Count > 0)
            {
                DataRow row = librarianTable.Rows[0];
                return new Librarian(
                    row["password"].ToString(),
                    row["firstName"].ToString(),
                    row["lastName"].ToString(),
                    Convert.ToDateTime(row["dateOfBirth"]),
                    row["phoneNumber"].ToString(),
                    row["email"].ToString(),
                    new Address(
                        row["Street"].ToString(),
                        row["HouseNumber"].ToString(),
                        row["PostalCode"].ToString(),
                        row["City"].ToString(),
                        row["Country"].ToString()),
                    Convert.ToInt32(row["EmployeeNumber"])
                )
                { LibrarianId = Convert.ToInt32(row["EmployeeId"]) };
            }

            return null;
        }
        public Librarian GetLibrarianById(int librarianId)
        {
            string query = @"SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country, EmployeeNumber
                             FROM Librarians WHERE EmployeeId = @LibrarianId";
            SqlParameter[] parameters = { new SqlParameter("@LibrarianId", librarianId) };

            DataTable librarianData = dbHelper.ExecuteQuery(query, parameters);

            if (librarianData.Rows.Count > 0)
            {
                DataRow row = librarianData.Rows[0];
                Address address = new Address(row["Street"].ToString(), row["HouseNumber"].ToString(), row["PostalCode"].ToString(), row["City"].ToString(), row["Country"].ToString());
                return new Librarian("", row["FirstName"].ToString(), row["LastName"].ToString(), Convert.ToDateTime(row["DateOfBirth"]), row["PhoneNumber"].ToString(), row["Email"].ToString(), address, Convert.ToInt32(row["EmployeeNumber"]));
            }

            return null;
        }
        public DataTable LoadLibrarians(string searchTerm = "")
        {
            string query;
            SqlParameter[] parameters = null;

            if (string.IsNullOrEmpty(searchTerm))
            {
                query = @"SELECT EmployeeId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country FROM Librarians";
            }
            else
            {
                query = @"SELECT EmployeeId, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country FROM Librarians WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR EmployeeId LIKE @SearchTerm";
                parameters = new[] { new SqlParameter("@SearchTerm", $"%{searchTerm}%") };
            }

            return dbHelper.ExecuteQuery(query, parameters);
        }
        public void DeleteLibrarian(int id)
        {
            string deleteLibrarianQuery = "DELETE FROM Librarians WHERE EmployeeId = @LibrarianId";
            SqlParameter[] parameters = { new SqlParameter("@LibrarianId", id) };

            int affectedRows = dbHelper.ExecuteNonQuery(deleteLibrarianQuery, parameters);

            if (affectedRows == 0)
            {
                MessageBox.Show("No Librarian found with the given ID.");
            }
            else
            {
                MessageBox.Show("Account deleted successfully.");
            }
        }
        public void SaveLibrarianInDatabase(Librarian librarian)
        {
            string insertDataQuery = "INSERT INTO Librarians (EmployeeNumber, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) VALUES (@EmployeeNumber, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Street, @City, @HouseNumber, @PostalCode, @Country)";
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeNumber", librarian.EmployeeNumber),
                new SqlParameter("@Password", librarian.Password),
                new SqlParameter("@FirstName", librarian.FirstName),
                new SqlParameter("@LastName", librarian.LastName),
                new SqlParameter("@DateOfBirth", librarian.DateOfBirth),
                new SqlParameter("@Email", librarian.Email),
                new SqlParameter("@PhoneNumber", librarian.PhoneNumber),
                new SqlParameter("@Street", librarian.Address.Street),
                new SqlParameter("@City", librarian.Address.City),
                new SqlParameter("@HouseNumber", librarian.Address.HouseNumber),
                new SqlParameter("@PostalCode", librarian.Address.PostalCode),
                new SqlParameter("@Country", librarian.Address.Country)
            };

            dbHelper.ExecuteNonQuery(insertDataQuery, parameters);
            MessageBox.Show("Librarian successfully registered.");
        }
        public void EditLibrarian(int librarianId, string lastName, string phoneNumber, string street, string houseNumber, string postalCode, string city, string country)
        {
            string query = @"UPDATE Librarians 
                             SET LastName = @LastName, PhoneNumber = @PhoneNumber, Street = @Street, HouseNumber = @HouseNumber, PostalCode = @PostalCode, City = @City, Country = @Country
                             WHERE EmployeeId = @LibrarianId";

            SqlParameter[] parameters = {
                new SqlParameter("@LibrarianId", librarianId),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Street", street),
                new SqlParameter("@HouseNumber", houseNumber),
                new SqlParameter("@PostalCode", postalCode),
                new SqlParameter("@City", city),
                new SqlParameter("@Country", country)
            };

            dbHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Librarian details updated successfully.");
        }
    }
}
