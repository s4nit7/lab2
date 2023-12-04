using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        public static void Main ()
        {
            Address address = new Address();
            address.Index = 08923;
            address.City = "Lviv";
            address.Apartment = 22;
            address.Country = "Ukraine";
            address.House = 4;

            Console.WriteLine(address);
        }
    }
}
