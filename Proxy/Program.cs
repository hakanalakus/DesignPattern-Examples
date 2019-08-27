using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Image img = new ProxyImage("hakan.jpg");
            img.Display();

            //Not Loaded
            img.Display();
            Console.ReadLine();
        }
    }
}
