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
        public int Id { get; private set; }
        private static int nextId = 1;

        public string EmployeeNumber { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Password { get; set; }

        public Librarian(string passoword, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, string employeeNumber, DateTime employmentDate)
            : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
        {
            EmployeeNumber = employeeNumber;
            EmploymentDate = employmentDate;
            Id = nextId++; 
            Password = passoword;
        }
        public static Librarian GetLibrarian(string employeeNumber,  string password)
        {
            Librarian foundLibrarian = null;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = "SELECT * FROM Librarians WHERE EmployeeNumber = @EmployeeNumber AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@Password", password);
                    
                    connection.Open(); 
                    using(SqlDataReader librarian = command.ExecuteReader())
                    {
                        if(librarian.Read())
                        {
                            foundLibrarian = new Librarian(librarian["password"].ToString(), librarian["firstName"].ToString(), librarian["lastName"].ToString(), Convert.ToDateTime(librarian["dateOfBirth"]),
                                librarian["phoneNumber"].ToString(), librarian["email"].ToString(), new Address(librarian["Street"].ToString(), librarian["HouseNumber"].ToString(), librarian["PostalCode"].ToString(),
                                librarian["City"].ToString(), librarian["Country"].ToString()), librarian["EmployeeNumber"].ToString(), Convert.ToDateTime(librarian["employmentDate"]));
                        }
                    }
                }
            }
            return foundLibrarian;
        }
    }
}
