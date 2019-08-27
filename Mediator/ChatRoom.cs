using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ChatRoom
    {

        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} {user.Name}:{message}");
        }

    }
}
