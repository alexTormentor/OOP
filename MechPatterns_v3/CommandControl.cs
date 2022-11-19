using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class ControlService                                                        // класс очереди команд
    {
        Queue<Command> commands = new Queue<Command>();                         // очередь команд
        public void SetCommand(Command command) => commands.Enqueue(command);   // загружаем команды
        public void Deploy() => commands.Dequeue().Execute();                   // вызывается команда
    }
}
