using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Computer
    {
        public void Open()
        {
            Memory m = new Memory();
            Processor p = new Processor();
            HardDrive h = new HardDrive();

            m.Load("0x1231","xx");
            p.Work();
            h.Read();

        }

    }
}
