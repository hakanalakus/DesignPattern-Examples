using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal Account
            Account account = new Account();
            account.GetMoney();
            account.PayMoney();

            //Gold Account
            account.ChangeState(new GoldAccount());
            account.GetMoney();
            account.PayMoney();

            Console.ReadLine();

        }
    }
}
