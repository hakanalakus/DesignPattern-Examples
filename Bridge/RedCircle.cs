using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RedCircle : IDraw
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing red circle radius={radius} x={x} y={y}");
        }
    }
}
