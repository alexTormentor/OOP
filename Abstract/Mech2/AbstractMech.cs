﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mech2
{
    class AMech : Machine
    {
        public AMech(string model) : base(model) { }
        ~AMech() { }
    }
}