using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Reader : Person
    {
        public int Id {  get; private set; }
        private static int nextId = 1;
        public string Password {  get; set; }
        public string Username {  get; set; }
        public Reader(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, string password, string username)
        : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
        {
            Id = nextId++;
            Username = username;
            Password = password;
        }
    }
}
