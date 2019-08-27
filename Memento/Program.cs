using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {

            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.State = "State1";
            originator.State = "State2";

            originator.State = "State3";
            careTaker.Add(originator.SaveStateToMemento());
            originator.State = "State4";
            careTaker.Add(originator.SaveStateToMemento());

            Console.WriteLine(originator.GetStateFromMemento(careTaker.Get(0)));
            Console.WriteLine(originator.GetStateFromMemento(careTaker.Get(1)));

            Console.ReadLine();

        }
    }
}
