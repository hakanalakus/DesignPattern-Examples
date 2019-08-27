﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CalculateMethodA : CalculateMethod
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated with Method A");
        }
    }
}
