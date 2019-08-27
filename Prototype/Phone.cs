using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Phone:ICloneable
    {
        public string brand;
        public int batteryCapacity;
        public double screenSize;

    
        public object Clone()
        {
           return this.MemberwiseClone();
        }

        

    }
}
