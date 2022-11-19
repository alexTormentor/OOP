using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    public class FM_Weapon
    {
        public FM_Weapon(String MechWeaponName, String PilotWeaponName)
        {
            Company com = new RedBullet(MechWeaponName);

            com = new Siege(PilotWeaponName);

            Console.ReadLine();
        }
    }
}
