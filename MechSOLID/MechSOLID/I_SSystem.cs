using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public interface SSystem
    {
        Mech CreateMech(string[] data);
    }
}
