using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    public class MechCreateCommand
    {
        public MechCreateCommand()
        {
            MechComplexityDeploying mechComplexityDeploying = new();
            Console.WriteLine(mechComplexityDeploying.ArmoreDeploy(7));
            Console.WriteLine(mechComplexityDeploying.WeaponDeploy(4));
            Console.WriteLine(mechComplexityDeploying.EngineDeploy(2));
            Console.WriteLine(mechComplexityDeploying.SystemDeploy(3));
        }
    }
}
