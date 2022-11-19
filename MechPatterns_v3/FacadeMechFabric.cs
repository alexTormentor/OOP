using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    public class MechFabric
    {
        public MechFabric()
        {
            MechFacade mech = new MechFacade(new Corpus(), new Engine(), new Tooling());
            mech.buildMechWithEngine();
            Console.WriteLine(new String('*', 10));
            mech.buildMechWithoutEngine();
            Console.ReadLine();
        }
    }
}
