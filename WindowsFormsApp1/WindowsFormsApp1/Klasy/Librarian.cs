using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Librarian : Person
    {
        public int LibrarianId { get; private set; }
        //private static int nextId = 1;

        public int EmployeeNumber { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Password { get; set; }

        /*        public Librarian(string passoword, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, int employeeNumber)
                    : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
                {
                    EmployeeNumber= employeeNumber;
                    Id = nextId++; 
                    Password = passoword;
                }*/
        public Librarian(string passoword, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, int employeeNumber)
            : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
        {
            EmployeeNumber = employeeNumber;
            //Id = nextId++;
            Password = passoword;
        }
        public static Librarian GetLibrarian(int employeeNumber, string password)
        {
            Librarian foundLibrarian = null;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
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
                                librarian["City"].ToString(), librarian["Country"].ToString()), Convert.ToInt32(librarian["EmployeeNumber"].ToString()));
                        }
                    }
                }
            }
            return foundLibrarian;
        }
        public static Librarian GetLibrarianById(int librarianId, string connectionString)
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
    }
}