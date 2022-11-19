using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    abstract class Command
    {
        protected ArithmeticUnit unit;
        protected decimal operand;
        public abstract void Execute();
        public abstract void Undo();
    }
}
