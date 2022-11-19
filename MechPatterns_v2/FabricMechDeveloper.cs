using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class RedBullet : Company
    {
        public RedBullet(string n) : base(n)
        { }

        public override Gun Create()
        {
            return new MechGun();
        }
    }
}
