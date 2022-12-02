using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MechSOLID_O
{
    public class Corpus : Engine
    {
        protected override void Construct()
        {
            Console.WriteLine("Создание корпуса ядра");
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(100);
                Console.Write('▱');
            }
            Console.Write("\n\n\n");
        }

        protected override void Service()
        {
            Console.WriteLine("Размещение необходимых модулей");
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(100);
                Console.Write('▱');
            }
            Console.Write("\n\n\n");
        }

        protected override void Production()
        {
            Console.WriteLine("Создание документации");
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(30);
                Console.Write('▱');
            }
            Console.Write("\n\n\n");
        }
    }
}
