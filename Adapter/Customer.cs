using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Customer
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public Customer(string number,string name,string explanation,string adress,string country,string city,string distrcit)
        {
            Number = number;
            Name = name;
            Explanation = explanation;
            Adress = adress;
            Country = country;
            City = city;
            District = distrcit;
        }
    }
}
