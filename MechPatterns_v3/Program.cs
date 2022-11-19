using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            MechFabric mecha = new MechFabric();                                // фасад
            FM_Weapon arsenal = new FM_Weapon("Рельсотрон-2000", "Гроза С-14");                                // фабрика
            MechCreateCommand mechCreateCommand = new MechCreateCommand();      // команда
            Console.Read();
        }
    }
}