using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class Siege : Company                   // класс конкретной компании
    {
        public Siege(string n) : base(n)
        {
            Console.WriteLine("\n\tВооружение - " + n);
            Create(n);
        }

        public override Gun Create(String n)        // абстрактный класс возвращающий другой класс
        {
            return new PilotGun(n);
        }
    }
}
