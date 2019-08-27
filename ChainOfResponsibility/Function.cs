using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Function
    {
        protected Function nextFunction;
        public Function SetNextFunction(Function f)
        {
            nextFunction = f;
            return f;
        }
        public void Run(string functionVariable)
        {
            PerformFunction(functionVariable);
            if (nextFunction != null)
            {
                nextFunction.PerformFunction(functionVariable);
            }
        }
        protected abstract void PerformFunction(string functionVarible);
    }
}
