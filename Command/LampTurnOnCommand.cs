using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LampTurnOnCommand : ILampCommand
    {
        Lamp _lamp;
        public LampTurnOnCommand(Lamp lamp)
        {
            _lamp = lamp;
        }

        public void CommandRun()
        {
            _lamp.LampTurnOn();
        }
    }
}
