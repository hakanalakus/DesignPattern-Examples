using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyImage : Image
    {
        private RealImage _image;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_image == null)
            {
                Console.WriteLine("Image Loading From Disk");
                _image = new RealImage(_fileName);
            }
            _image.Display();
        }
    }
}
