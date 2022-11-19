using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class ArmoreDeploy : Operation                                                                  // класс брони - используется для команды изменения брони
    {
        public ArmoreDeploy(MachineFactory mech, decimal component) : base(mech, component) { }     // изменяем конкретно мехфактори

        public override void Execute() => mech.MechArmoreDeploy(Components.ArmoreMk, component);    // вызываем нужную команду
    }
}
