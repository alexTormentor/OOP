using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class CodeCommand : ICommand
    {
        Pilot pilot;
        public CodeCommand(Pilot p)
        {
            pilot = p;
        }
        public void Execute()
        {
            pilot.Start();
        }
        public void Undo()
        {
            pilot.Leave();
        }
    }
}
