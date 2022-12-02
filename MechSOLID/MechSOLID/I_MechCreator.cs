using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public interface MechCreator
    {
        bool IsValid(Mech mech);
    }
}
