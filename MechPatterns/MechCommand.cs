using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class MechCommand : ICommand
    {
        Mech mech;
        public MechCommand(Mech m)
        {
            mech = m;
        }
        public void Execute()
        {
            mech.Start();
        }
        public void Undo()
        {
            mech.Returning();
        }
    }
}
