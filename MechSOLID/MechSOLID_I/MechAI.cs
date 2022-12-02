using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MechSOLID_I
{
    public class MechAI : IStatus
    {
        public void GetStatus()
        {
            Console.WriteLine("обновление статуса...");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                Console.Write('#');
            }
            Console.WriteLine("\n");
            Console.WriteLine("Система перезагружена");
        }
    }
}
