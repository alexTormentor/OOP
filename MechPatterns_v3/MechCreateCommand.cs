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
            MechComplexityDeploying mechComplexityDeploying = new MechComplexityDeploying();
            Console.Write("Расчётная стоимость брони -");
            Console.WriteLine("\t" + mechComplexityDeploying.ArmoreDeploy(134));
            Console.Write("Расчётная стоимость вооружения -");
            Console.WriteLine("\t" + mechComplexityDeploying.WeaponDeploy(174));
            Console.Write("Расчётная стоимость реактора -");
            Console.WriteLine("\t" + mechComplexityDeploying.EngineDeploy(151));
            Console.Write("Расчётная стоимость автоматической системы и её калибровки под комплектацию -");
            Console.WriteLine("\t" + mechComplexityDeploying.SystemDeploy(174));
        }
    }
}
