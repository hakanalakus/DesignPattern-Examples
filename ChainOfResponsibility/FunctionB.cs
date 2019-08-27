using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class FunctionB:Function
    {
        protected override void PerformFunction(string functionVarible)
        {
            Console.WriteLine("FunctionB is running on " + functionVarible);
        }
    }
}
