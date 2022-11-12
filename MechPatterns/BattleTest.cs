using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class Test
    {
        ICommand command;
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void StartTest()
        {
            if (command != null)
                command.Execute();
        }
        public void StopTest()
        {
            if (command != null)
                command.Undo();
        }
    }
}
