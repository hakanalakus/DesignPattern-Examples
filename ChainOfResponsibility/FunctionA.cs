using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class FunctionA : Function
    {
        protected override void PerformFunction(string functionVarible)
        {
            Console.WriteLine("FunctionA is running on "+functionVarible);
        }
    }
}
