using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MechFabric mecha = new MechFabric();
            FM_Weapon arsenal = new FM_Weapon();

            Pilot pilot = new Pilot();
            Mech mech = new Mech();
            Tech tech = new Tech();

            List<ICommand> commands = new List<ICommand>
        {
            new TechCommand(tech),
            new CodeCommand(pilot),
            new MechCommand(mech)
           
        };
            Test manager = new Test();
            manager.SetCommand(new MacroCommand(commands));
            manager.StartTest();
            manager.StopTest();

            Console.Read();
        }
    }
}
