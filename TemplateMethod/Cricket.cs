using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Cricket : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Cricket Game End");
        }

        public override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started..");
        }
    }
}
