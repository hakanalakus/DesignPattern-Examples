using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class GreenCircle : IDraw
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing green circle radius={radius} x={x} y={y}");
        }
    }
}
