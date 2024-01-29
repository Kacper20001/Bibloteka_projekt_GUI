using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Transactions;
using CsvHelper;

namespace WindowsFormsApp1
{
    internal class Reader : Person
    {
        public int ReaderId { get; set; }
        public string Password  { get; set; }
        public string Username { get; set; }

        public Reader(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, string password, string username)
         : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
        {
            Username = username;
            Password = password;
        }
    }
}
