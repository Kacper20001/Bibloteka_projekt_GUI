using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfejsy
{
    internal interface IBorrowBookHandle
    {
        void BorrowBook(int readerId, int bookId);
        DataTable LoadBorrowedBooks(int readerId);
        DataTable LoadAllBorrowedBooks(string connectionString);
    }
}
