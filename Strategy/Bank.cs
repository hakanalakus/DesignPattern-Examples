using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Bank
    {
        private CalculateMethod _method;

        public Bank(CalculateMethod calculateMethod)
        {
            _method = calculateMethod;

        }
        public void CalculateLoan()
        {
            _method.Calculate();

        }

    }
}
