using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_I
{
    public class AI
    {
        public void UpdateStatus(IStatus update)
        {
            update.GetStatus();
        }
    }
}
