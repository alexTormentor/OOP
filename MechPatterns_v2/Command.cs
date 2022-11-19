using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    abstract class Command
    {
        protected MachineFactory mech;
        protected decimal component;
        public abstract void Execute();
        public abstract void Undo();
    }
}
