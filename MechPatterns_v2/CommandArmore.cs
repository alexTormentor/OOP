using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class ArmoreDeploy : Operation
    {
        public ArmoreDeploy(MachineFactory mech, decimal component) : base(mech, component) { }

        public override void Execute() => mech.MechArmoreDeploy(Components.ArmoreMk, component);
    }
}
