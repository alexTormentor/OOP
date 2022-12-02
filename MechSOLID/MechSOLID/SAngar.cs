using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public class Angar
    {
        List<Mech> mechas = new List<Mech>();

        public IMech Mech { get; set; }
        public SSystem MechSystem { get; set; }
        public MechCreator Creator { get; set; }
        public IMechBuilder Builder { get; set; }

        public Angar(IMech mech, SSystem system, MechCreator creator, IMechBuilder builder)
        {
            this.Mech = mech;
            this.MechSystem = system;
            this.Creator = creator;
            this.Builder = builder;
        }

        public void Process()
        {
            string?[] data = Mech.GetInputData();
            Mech mech = MechSystem.CreateMech(data);
            if (Creator.IsValid(mech))
            {
                mechas.Add(mech);
                Builder.Build(mech, "angar.txt");
                Console.WriteLine("ID меха добавлен");
            }
            else
            {
                Console.WriteLine("Некорректные данные");
            }
        }
    }
}
