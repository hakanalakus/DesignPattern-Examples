using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class MailDecorator : IMail
    {
        private IMail mail;


        public MailDecorator(IMail mail)
        {
            this.mail = mail;
        }

        public virtual void Send()
        {
           
            mail.Send();
        }
    }
}
