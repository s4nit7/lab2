using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Address
    {
        private string country;
        private string city;
        private int index;
        private int house;
        private int apartment;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public override string ToString()
        {
            return $"{index}, {country}, {city}, {house}, {apartment}";
        }
    }
}
