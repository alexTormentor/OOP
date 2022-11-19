using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    abstract class Operation : Command
    {
        public Operation(MachineFactory mech, decimal component) => (this.mech, this.component) = (mech, component);

        public override void Undo() { }
    }
}
