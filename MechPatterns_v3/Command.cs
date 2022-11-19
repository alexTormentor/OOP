using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    abstract class Command                  // класс для хранения исполняющей команды
    {
        protected MachineFactory mech;      // объект класса команд 
        protected decimal component;        // параметр, изменяющий поля объекта
        public abstract void Execute();     // исполняющая команда
        public abstract void Undo();        // завершение работы команды
    }
}
