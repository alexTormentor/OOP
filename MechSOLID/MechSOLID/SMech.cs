using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public class Mech
    {
        public string Model { get; }
        public int Serial { get; }
        public Mech(string model, int serial)
        {
            Model = model;
            Serial = serial;
        }
    }
}
