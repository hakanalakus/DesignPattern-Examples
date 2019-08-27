using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class FunctionC : Function
    {
        protected override void PerformFunction(string functionVarible)
        {
            Console.WriteLine("FunctionC is running on " + functionVarible);
        }
    }
}
