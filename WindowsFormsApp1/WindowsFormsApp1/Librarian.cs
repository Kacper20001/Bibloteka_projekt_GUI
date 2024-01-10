using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Librarian : Person
    {
        public string EmployeeNumber { get; set; }
        public DateTime EmploymentDate { get; set; }

        public Librarian(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, Address address, string employeeNumber, DateTime employmentDate)
            : base(firstName, lastName, dateOfBirth, address, email, phoneNumber)
        {
            EmployeeNumber = employeeNumber;
            EmploymentDate = employmentDate;
        }
    }
}
