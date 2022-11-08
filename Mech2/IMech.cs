using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    // И - здесь нет этого принципа т.к. интерфейс и без того достаточно не сложен, разделять нет смысла

    // абстракция - реализация класса будет выполняться отдельно в другом классе. Там же уже от реализации будет выполняться наследование и полиморфизм
    public interface IMech
    {
        String type_model { get; set; }
        String armore_type { get; set; }
        String weapon_type { get; set; }
        String design_type { get; set; }
        String engine_type { get; set; }
        String model { get; set; }
        String corp { get; set; }
    }
}
