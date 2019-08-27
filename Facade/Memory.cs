using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Memory
    {
        public void Load(string adress, string var)
        {
            Console.WriteLine($"{var} loaded {adress}");

        }

    }
}
