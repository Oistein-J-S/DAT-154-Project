using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Address
    {
  
        string StreetName { get; set; }
        string PostalCode { get; set; }
        public Address(string streetName, string postalCode)
        {
            StreetName = streetName;
            PostalCode = postalCode;
        }
    }
}
