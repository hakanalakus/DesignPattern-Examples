using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ElectricCar : ICar
    {
        public void Run()
        {
            Console.WriteLine("Electric Car is running ..");
        }
    }
}
