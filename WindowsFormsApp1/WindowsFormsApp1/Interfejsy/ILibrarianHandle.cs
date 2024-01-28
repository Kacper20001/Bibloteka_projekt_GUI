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
        Librarian GetLibrarian(int employeeNumber, string password);
        Librarian GetLibrarianById(int librarianId);
        void SaveLibrarianInDatabase(Librarian librarian);
        void EditLibrarian(int LibrarianId, string LastName, string PhoneNumber, string Street, string HouseNumber, string PostalCode, string City, string Country);
        void DeleteLibrarian(int id);
        DataTable LoadLibrarians(string searchTerm = "");
    }
}
