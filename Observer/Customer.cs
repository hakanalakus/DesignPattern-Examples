using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Customer : PriceObserver
    {
        private string _name;
        public Customer(string name)
        {
            _name = name;
        }
        public void update(int price)
        {
            Console.WriteLine($"{_name} update price :{price}");
        }
    }
}
