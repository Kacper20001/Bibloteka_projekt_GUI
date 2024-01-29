using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfejsy;

namespace WindowsFormsApp1
{
    internal class Address : IAddress
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address(string street, string houseNumber, string postalCode, string city, string country)
        {
            if (string.IsNullOrEmpty(street))
                throw new ArgumentException("Street cannot be empty or null", nameof(street));

            if (string.IsNullOrEmpty(houseNumber))
                throw new ArgumentException("HouseNumber cannot be empty or null", nameof(houseNumber));

            if (string.IsNullOrEmpty(postalCode))
                throw new ArgumentException("PostalCode cannot be empty or null", nameof(postalCode));

            if (string.IsNullOrEmpty(city))
                throw new ArgumentException("City cannot be empty or null", nameof(city));

            if (string.IsNullOrEmpty(country))
                throw new ArgumentException("Country cannot be empty or null", nameof(country));

            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }
    }
}
