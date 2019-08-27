using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "hakan.alakus@hotmail.com";
            string destination = "x.y@hotmail.com";

            IMail mail = new EncryptDecorator(new DigitalSignatureDecorator(new GeneralMail(source,destination), "Hakan Alakus"));
            mail.Send();
            Console.ReadLine();

            
        }
    }
}
