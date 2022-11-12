using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class TechCommand : ICommand
    {
        Tech tech;
        public TechCommand(Tech t)
        {
            tech = t;
        }
        public void Execute()
        {
            tech.StartAdvertize();
        }

        public void Undo()
        {
            tech.StopAdvertize();
        }
    }
}
