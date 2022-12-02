using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_O
{
    public abstract class Engine
    {
        public void Create()
        {
            Construct();
            Service();
            Production();
        }
        protected abstract void Construct();
        protected abstract void Service();
        protected abstract void Production();
    }
}
