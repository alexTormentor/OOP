using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class WeaponDeploy : Operation
    {
        public WeaponDeploy(MachineFactory mech, decimal component) : base(mech, component) { }

        public override void Execute() => mech.MechWeaponDeploy(Components.WeaponMk, component);
    }
}
