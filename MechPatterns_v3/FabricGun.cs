using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class MechGun : Gun                                                         // класс переопределяющий метод класса Gun
    {
        public MechGun(String n)
        {
            Console.WriteLine("создан прототип вооружения");
            GunPrototype(n);
        }

        public override void GunPrototype(String n)
        {
            Console.WriteLine("Прототип " + n + " был передан в сборочный цех");
        }
    }
}
