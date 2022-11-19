using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class PilotGun : Gun
    {
        public PilotGun(String n)
        {
            Console.WriteLine("пилот оснащён");
            GunPrototype(n);
        }

        public override void GunPrototype(String n)
        {
            Console.WriteLine("Пилот получил прототип " + n + " отправлен на диагностику всех параметров");
        }
    }
}
