using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class Siege : Company
    {
        public Siege(string n) : base(n)
        { }

        public override Gun Create()
        {
            return new PilotGun();
        }
    }
}
