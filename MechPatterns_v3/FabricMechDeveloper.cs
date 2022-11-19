using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class RedBullet : Company                       // еще один класс создающий другой класс
    {
        public RedBullet(string n) : base(n)
        {
            Console.WriteLine("\n\tВооружение - " + n);
            Create(n);
        }

        public override Gun Create(String n)
        {
            return new MechGun(n);
        }
    }
}
