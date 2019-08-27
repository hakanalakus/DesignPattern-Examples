using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CustomerBusinessAdress : IAdress
    {
        public Customer customer { get; set; }

        public CustomerBusinessAdress(Customer c)
        {
            customer = c;
        }

        public string GetAdress()
        {
            return "S.cesme mah. Bayar Sok No 82";
        }

        public string GetCity()
        {
            return "İstanbul";
        }

        public string GetCountry()
        {
            return "Turkey";
        }

        public string GetDistrict()
        {
            return "Sefakoy";
        }
    }
}
