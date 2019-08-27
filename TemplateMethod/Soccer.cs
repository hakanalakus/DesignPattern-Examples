using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Soccer : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Soccer Game End");
        }

        public override void Initialize()
        {
            Console.WriteLine("Soccer Game Initialized ");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Soccer Game Started..");
        }
    }
}
