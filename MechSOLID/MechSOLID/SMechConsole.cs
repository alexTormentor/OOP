using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID
{
    public class MechConsole : IMech
    {
        public string[] GetInputData()
        {
            Console.WriteLine("Введите модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Введите серию:");
            string serial = Console.ReadLine();
            return new string[] { model, serial };
        }
    }
}
