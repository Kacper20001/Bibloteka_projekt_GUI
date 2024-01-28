using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfejsy
{
    internal interface IAddress
    {
        string Street { get; }
        string HouseNumber { get; }
        string PostalCode { get; }
        string City { get; }
        string Country { get; }
    }
}
