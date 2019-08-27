using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Function chain1, chain2, chain3;
            chain1 = new FunctionA();
            chain2 = chain1.SetNextFunction(new FunctionC());
            chain2.SetNextFunction(new FunctionB());

            chain3 = new FunctionC();
            chain3.SetNextFunction(new FunctionA());
            Console.WriteLine("--- Chain 2 ---");
            chain2.Run("x");

            Console.WriteLine("--- Chain 3 ---");
            chain3.Run("y");
           
            Console.ReadLine();
            
        }
    }
}
