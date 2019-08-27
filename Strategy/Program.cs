using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank1 = new Bank(new CalculateMethodA());
            Bank bank2 = new Bank(new CalculateMethodB());

            bank1.CalculateLoan();
            bank2.CalculateLoan();

            Console.ReadLine();
        }
    }
}
