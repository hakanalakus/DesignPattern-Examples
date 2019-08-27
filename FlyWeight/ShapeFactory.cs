using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class ShapeFactory
    {
        public static Dictionary<Color, Circle> ShapePool = new Dictionary<Color, Circle>();
        public static IShape GetCircle(Color c)
        {
            Circle circle;
            if (ShapePool.ContainsKey(c))
            {
                circle = ShapePool[c];
            }
            else
            {
                Console.WriteLine($"Creating circle {c.ToString()} ");
                circle = new Circle(c);
                ShapePool.Add(circle.color,circle);
            }
            return circle;
            
        }

    }
}
