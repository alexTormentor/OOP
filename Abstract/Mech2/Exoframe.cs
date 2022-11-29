using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    public class Exoframe : Vehicle
    {
        public Exoframe(String t, String a, String w, String d, String e, String m, String c, String _capacity, String _specification) : base(t, a, w, d, e, m, c, _capacity, _specification) 
        {
        }

        public override void Output()
        {
            base.Output();
        }
    }
    
}
