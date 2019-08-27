using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PriceSubject : ISubject

    {
        private List<PriceObserver> _observerList = new List<PriceObserver>();
        private int _price;


        public void AddObserver(PriceObserver p)
        {
            _observerList.Add(p);
        }

        public void NotifyObservers()
        {
            foreach (var item in _observerList)
            {
                item.update(_price);
            }
        }

        public void ChangePrice(int price)
        {
            _price = price;
            NotifyObservers();



        }

    }
}
