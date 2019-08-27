using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LampButton
    {
        ILampCommand openCommand;

        public LampButton(ILampCommand turnOn)
        {
            openCommand = turnOn;
        }
        public void TurnOnLamp()
        {

            openCommand.CommandRun();
        }

    }
}
