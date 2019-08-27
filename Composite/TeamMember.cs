using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class TeamMember : IWorker
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public TeamMember(string name,int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void GetWorkerInfo()
        {
            Console.WriteLine($"{Name} {Salary}");
        }
    }
}
