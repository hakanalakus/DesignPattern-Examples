using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterPreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "++--";

            List<ISymbol> symbolList = new List<ISymbol>();

            foreach (var item in text)
            {
                if (item == '+')
                {
                    symbolList.Add(new PlusSymbol());
                }
                else if(item=='-')
                {
                    symbolList.Add(new MinusSymbol());

                }
            }

            foreach (var item in symbolList)
            {
                item.Interpret();
            }
            Console.ReadLine();
        }
    }
}
