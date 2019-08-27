using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Game cricket = new Cricket();
            Game soccer = new Soccer();
            cricket.Play();
            Console.WriteLine("----------------------------");
            soccer.Play();
            Console.ReadLine();

        }
    }
}
