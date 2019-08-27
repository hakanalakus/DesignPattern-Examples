using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class NormalAccount : IAccountState
    {
        public void GetMoney()
        {
            Console.WriteLine("Money is getting from normal account");
        }

        public void PayMoney()
        {
            Console.WriteLine("Money is paying from normal account");
        }
    }
}
