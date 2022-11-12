using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    public class FM_Weapon
    {
        public FM_Weapon()
        {
            Company com = new RedBullet("плазмаган");
            Gun mech = com.Create();

            com = new Siege("ПП-2000");
            Gun pilot = com.Create();

            Console.ReadLine();
        }
    }
}
