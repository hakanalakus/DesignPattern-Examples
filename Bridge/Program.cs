using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(10, 2, 5,new RedCircle());
            Shape greenCircle = new Circle(5, 5, 3, new GreenCircle());
            redCircle.Draw();
            greenCircle.Draw();
            Console.ReadLine();
            

        }
    }
}
