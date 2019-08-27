using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    enum Color {Red,Green,Blue,White,Black}

    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 20; i++)
            {
                Color c = GetRandomColor();
                int x = GetRandomX();
                int y = GetRandomY();
                Circle circle= (Circle)ShapeFactory.GetCircle(c);
                circle.X = x;
                circle.Y = y;
                circle.Draw();
                
            }

            Console.ReadLine();
            

        }
        static Random rnd = new Random();
        static Color GetRandomColor()
        {
            Array colors = Enum.GetValues(typeof(Color));
            Color randomColor = (Color)colors.GetValue(rnd.Next(0, colors.Length));
            return randomColor;
            
        }
        static int GetRandomX()
        {
            int randomX = rnd.Next(0, 100);
            return randomX;
        }
        static int GetRandomY()
        {
            int randomY = rnd.Next(0, 100);
            return randomY;
        }
    }
}
