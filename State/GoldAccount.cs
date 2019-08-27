using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GoldAccount : IAccountState
    {
        public void GetMoney()
        {
            Console.WriteLine("Money is getting from gold account");
        }

        public void PayMoney()
        {
            Console.WriteLine("Money is paying from gold account");
        }
    }
}
