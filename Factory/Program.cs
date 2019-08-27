using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory car = new CarFactory();
            ICar c=car.GetCar(CarFactory.carType.Fast);
            c.Run();
            Console.ReadLine();


        }
    }
}
