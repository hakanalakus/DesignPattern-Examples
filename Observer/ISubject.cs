using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubject
    {
        void NotifyObservers();
        void AddObserver(PriceObserver p);

    }
}
