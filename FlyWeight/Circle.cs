using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Circle : IShape
    {
        public Color color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; } = 100;

        public Circle(Color c)
        {
            color = c;
        }


        public void Draw()
        {
            Console.WriteLine($"Circle Drawing X={X} Y={Y} Color ={color} Radius={Radius} ");   
        }
    }
}
