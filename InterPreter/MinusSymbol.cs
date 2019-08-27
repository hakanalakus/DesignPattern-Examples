using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterPreter
{
    class MinusSymbol : ISymbol
    {
        public void Interpret()
        {
            Console.WriteLine("Minus Symbol Interpreted");
        }
    }
}
