using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mech2
{
    abstract class Machine
    {
        public string Model { get; }
        public Machine(string model)
        {
            Model = model;
        }
        public void Tex()
        {
            Console.WriteLine($"Начало техосмотра {Model}\n");
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(80);
                Console.Write('#');
            }
            Console.Write("\n\n\n");
            Console.Write("\n\n\n");
        }

        ~Machine() { }
    }
}
