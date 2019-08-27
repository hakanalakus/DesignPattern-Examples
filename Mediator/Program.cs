using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Hakan");
            User user2 = new User("Mehmet");
            user1.SendMessage("Hi");
            user2.SendMessage("Hello world");
            Console.ReadLine();

        }
    }
}
