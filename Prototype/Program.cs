using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Phone p1 = new Phone() { batteryCapacity = 3000, brand = "Iphone", screenSize = 5.5 };
            Phone p2 = (Phone) p1.Clone();
            p2.brand = "Samsung";
            Phone p3 = p1;

            Console.WriteLine(p1.brand+"\t"+p1.screenSize+" inc");
            Console.WriteLine(p2.brand+"\t"+p2.screenSize+" inc");

            Console.ReadLine();


        }
    }
}
