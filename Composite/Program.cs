using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember tm = new TeamMember("Hakan",1000);
            TeamMember tm2 = new TeamMember("Ahmet", 1500);

            TeamManager teamManager = new TeamManager();
            teamManager.AddMember(tm);
            teamManager.AddMember(tm2);

            TeamManager Boss = new TeamManager();
            Boss.AddMember(teamManager);
            Boss.GetWorkerInfo();
            

        }
    }
}
