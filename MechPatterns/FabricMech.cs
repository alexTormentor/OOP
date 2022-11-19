using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    public class MechFabric
    {
        public MechFabric()
        {
            MechFacade mech = new MechFacade(new Corpus(), new Engine(), new Tooling());
            mech.buildCorpus();
            Console.WriteLine(new String('*', 10));
            mech.buildEngine();
            Console.WriteLine(new String('*', 10));
            mech.buildTooling();
            Console.WriteLine(new String('*', 10));
            Console.ReadLine();
        }
    }
}
