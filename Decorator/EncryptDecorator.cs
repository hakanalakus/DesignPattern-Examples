using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EncryptDecorator : MailDecorator
    {
        public EncryptDecorator(IMail mail) : base(mail)
        {
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Mail Encrypted ..");
        }
    }
}
