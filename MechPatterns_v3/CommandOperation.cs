using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    abstract class Operation : Command                                                                                  // класс операции 
    {
        public Operation(MachineFactory mech, decimal component) => (this.mech, this.component) = (mech, component);    // конструктор для переопределения команды

        public override void Undo() { }
    }
}
