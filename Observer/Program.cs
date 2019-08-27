using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceSubject priceSubject = new PriceSubject();
            Customer c1 = new Customer("Hakan");
            Customer c2 = new Customer("Ahmet");
            priceSubject.AddObserver(c1);
            priceSubject.AddObserver(c2);

            priceSubject.ChangePrice(20);
            Console.ReadLine();

            
        }
    }
}
