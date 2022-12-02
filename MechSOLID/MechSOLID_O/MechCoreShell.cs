using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MechSOLID_O
{
    public class MechCoreShell : Engine
    {
        protected override void Construct()
        {
            Console.WriteLine("Создание корпуса реактора");
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(100);
                Console.Write('▱');
            }
            Console.Write("\n\n\n");
        }

        protected override void Service()
        {
            Console.WriteLine("Установка ядра");
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(100);
                Console.Write('▱');
            }
            Console.Write("\n\n\n");
        }

        protected override void Production()
        {
            Console.WriteLine("Синхронизация ядра с системой");
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(10);
                Console.Write('▱');
            }
            Console.Write("\n\n\n");
        }
    }
}
