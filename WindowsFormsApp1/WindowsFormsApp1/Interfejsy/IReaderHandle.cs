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
        Reader GetReaders(string username, string passwordHash, string connectionString);
        Reader GetReaderById(int readerId, string connectionString);
        DataTable LoadReaders(string connectionString, string searchTerm = "");
        void DeleteReader(int id, string connectionString);
        void SaveReaderInDatabese(Reader reader, string connectionString);
        void EditReader(string connectionString, int ReaderId, string LastName, string PhoneNumber, string Street, string HouseNumber, string PostalCode, string City, string Country);
    }
}
