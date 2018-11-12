using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Address
    {
        public Address(string street, int streetNumber, int? aptNumber, string city, string postCode)
        {
            AddressStreet = street;
            AddressStreetNumber = streetNumber;
            AddressApartmentNumber = aptNumber;
            AddressCity = city;
            AddressPostCode = postCode;
        }

        public string AddressStreet { get; set; }
        public int AddressStreetNumber { get; set; }
        public int? AddressApartmentNumber { get; set; }
        public string AddressCity { get; set; }
        public string AddressPostCode { get; set; }
    }
}
