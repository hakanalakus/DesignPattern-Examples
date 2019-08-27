using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CustomerBillingAdressAdapter:IAdress
    {
        private Customer customer;
        public CustomerBillingAdressAdapter(Customer c)
        {
            customer = c;
        }

        public string GetAdress()
        {
            return customer.Adress;
        }

        public string GetDistrict()
        {
            return customer.District;
        }

        public string GetCity()
        {
            return customer.City;
        }

        public string GetCountry()
        {
            return customer.Country;
        }
    }
}
