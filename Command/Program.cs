using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {

            LampButton button = new LampButton(new LampTurnOnCommand(new Lamp()));
            button.TurnOnLamp();
            Console.ReadLine();

        }
    }
}
