using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public class SMechCreator : MechCreator
    {
        public bool IsValid(Mech mech) => !string.IsNullOrEmpty(mech.Model) && mech.Serial > 0;
    }
}
