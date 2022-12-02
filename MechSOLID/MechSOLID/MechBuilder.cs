using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MechSOLID
{
    public class MechBuilder : IMechBuilder
    {
        public void Build(Mech mech, string file)
        {
            using StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(mech.Model);
            writer.WriteLine(mech.Serial);
        }
    }
}
