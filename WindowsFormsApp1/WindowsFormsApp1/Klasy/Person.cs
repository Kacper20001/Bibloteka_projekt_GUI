using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfejsy;

namespace WindowsFormsApp1
{
    internal class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IAddress Address { get; set; }
        public Person(string firstName, string lastName, DateTime dateOfBirth, Address address, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
