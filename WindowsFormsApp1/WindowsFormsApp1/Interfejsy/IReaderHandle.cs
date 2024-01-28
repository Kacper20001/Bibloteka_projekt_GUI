using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfejsy
{
    internal interface IReaderHandle
    {
        Reader GetReaders(string username, string passwordHash);
        Reader GetReaderById(int readerId);
        DataTable LoadReaders( string searchTerm = "");
        void DeleteReader(int id);
        void SaveReaderInDatabase(Reader reader);
        void EditReader(int ReaderId, string LastName, string PhoneNumber, string Street, string HouseNumber, string PostalCode, string City, string Country);
    }
}
