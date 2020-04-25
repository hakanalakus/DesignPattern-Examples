using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object ob = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock(ob){

                    if (instance == null)
                    {
                        instance = new Singleton();

                    }


                }
                
            }
            return instance;
           
        }

        public override string ToString()
        {
            return "Created singleton object";
        }

    }
}
