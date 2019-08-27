using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class TeamManager : IWorker
    {
        private List<IWorker> TeamMembers = new List<IWorker>();
        public int Salary { get ; set ; }
        public string Name { get; set ; }

      

        public void AddMember(IWorker w)
        {
            TeamMembers.Add(w);
        }
        public void RemoveMember(IWorker w)
        {
            TeamMembers.Remove(w);
        }
        public void GetWorkerInfo()
        {
            foreach (var item in TeamMembers)
            {
                item.GetWorkerInfo();
            }
        }
    }
}
