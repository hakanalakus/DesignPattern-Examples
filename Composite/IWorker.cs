using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   
    interface IWorker
    {

        int Salary { get; set; }
        string Name { get; set; }
        void GetWorkerInfo();
    }
}
