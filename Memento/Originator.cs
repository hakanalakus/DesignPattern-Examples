using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(State);
        }
        public string GetStateFromMemento(Memento memento)
        {
            State = memento.GetState();
            return State;
        }


    }
}
