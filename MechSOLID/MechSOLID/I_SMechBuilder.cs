using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public interface IMechBuilder
    {
        void Build(Mech mech, string file);
    }
}
