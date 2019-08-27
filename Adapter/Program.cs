using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("5551111717", "Hakan Alakus", "Ex", "Halkalı Merkez mah 5.sokak", "Turkey", "Istanbul", "İkitelli");
            CustomerBillingAdressAdapter adapter = new CustomerBillingAdressAdapter(c1);
           
            IAdress adress = adapter;
            Console.WriteLine(adress.GetCity());
            Console.WriteLine(adress.GetCountry());
            Console.WriteLine(adress.GetAdress());
            
            Console.ReadLine();  

        }
    }
}
