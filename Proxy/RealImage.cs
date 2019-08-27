using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class RealImage : Image
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
        }


        public void Display()
        {
            Console.WriteLine("Displaying "+_fileName);
        }

        public void Load(string file)
        {
            Console.WriteLine(file + " Loaded");
        }
    }
}
