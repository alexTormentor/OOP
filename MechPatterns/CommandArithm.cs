using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    enum Operations
    {
        Plus, Minuse, Multiply, Divide
    }
    class ArithmeticUnit
    {
        public decimal Result { get; private set; }
        public void Run(Operations operations, decimal operand) => Result = operations switch
        {
            Operations.Plus => Result + operand,
            Operations.Minuse => Result - operand,
            Operations.Multiply => Result * operand,
            Operations.Divide => Result / operand,
            _ => throw new InvalidOperationException()
        };
    }
}
