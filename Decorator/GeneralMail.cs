using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class GeneralMail : IMail
    {
        private string _source;
        private string _destination;

        public GeneralMail(string source, string destination)
        {
            _source = source;
            _destination = destination;
        }


        public void Send()
        {
            Console.WriteLine($"Mail is sending to {_destination} by {_source}");
        }




    }
}
