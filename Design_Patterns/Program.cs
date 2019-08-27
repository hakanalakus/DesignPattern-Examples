using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread-Safe singleton example.

            var obj = Singleton.GetInstance();
            Console.WriteLine(obj.ToString());
            Console.ReadLine();


        }
    }
}
