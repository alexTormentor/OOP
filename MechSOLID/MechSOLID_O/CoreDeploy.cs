using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_O
{
    public class CoreDeploy
    {
        public string Model { get; set; }

        public CoreDeploy(string model)
        {
            this.Model = model;
        }

        public void CreateCore(Engine[] core)
        {
            foreach (Engine engine in core)
                engine.Create();
        }
    }
}
