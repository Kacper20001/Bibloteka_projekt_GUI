using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfejsy
{
    internal interface ILibrarianHandle
    {
        Librarian GetLibrarian(int employeeNumber, string password, string connectionString);
        Librarian GetLibrarianById(int librarianId, string connectionString);
        void SaveLibrarianInDatabase(Librarian librarian, string connectionString);
        void EditLibrarian(string connectionString, int LibrarianId, string LastName, string PhoneNumber, string Street, string HouseNumber, string PostalCode, string City, string Country);
        void DeleteLibrarian(int id, string connectionString);
        DataTable LoadLibrarians(string connectionString, string searchTerm = "");
    }
}
