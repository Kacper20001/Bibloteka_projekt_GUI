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
        public int LibrarianId { get;  set; }
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
    }
}