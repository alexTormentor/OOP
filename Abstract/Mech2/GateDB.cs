using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    public class GateDB
        // полиморфизм - методы будут переопределены наследниками для выполнения своих функций
    {
        public virtual void Model(String name)
        {
            
        }
        public virtual void Model(int name)
        {

        }
    }
}
