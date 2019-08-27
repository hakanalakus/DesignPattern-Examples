using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DigitalSignatureDecorator : MailDecorator
    {
        private string _signature;
        public DigitalSignatureDecorator(IMail mail,string signature) : base(mail)
        {
            _signature = signature;
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine($"Mail signatured as {_signature}  ..");
        }
    }
}
