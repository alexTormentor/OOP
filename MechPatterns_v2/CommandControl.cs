using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class ControlService
    {
        Queue<Command> commands = new();
        public void SetCommand(Command command) => commands.Enqueue(command);
        public void Deploy() => commands.Dequeue().Execute();
    }
}
