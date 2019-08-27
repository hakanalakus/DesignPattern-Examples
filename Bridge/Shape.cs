using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Shape
    {
        protected IDraw drawAPI;

        protected Shape(IDraw drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
       
    }
}

