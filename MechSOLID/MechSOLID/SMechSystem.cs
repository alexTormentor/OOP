using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public class SMechSystem : SSystem
    {
        public Mech CreateMech(string[] data)
        {
            if (data is { Length: 2 } && data[0] is string model &&
                model.Length > 0 && int.TryParse(data[1], out var serial))
            {
                return new Mech(model, serial);

            }
            throw new Exception("Ошибка установки системы - сборка некорректна.");
        }
    }
}
