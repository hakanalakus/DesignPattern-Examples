﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GasolineCar:ICar
    {
        public void Run() {

            Console.WriteLine("Gasoline car is running ..");
        }
    }
}
