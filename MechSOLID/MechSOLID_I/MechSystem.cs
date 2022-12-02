using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MechSOLID_I
{
    public class MechSystem : IMessage, IStatus, IAnalyze, IConnect
    {
        public void Message() => Console.WriteLine("Добро пожаловать в систему БТ-17");

        public void GetStatus()
        {
            Console.WriteLine("Получение статуса...");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(45);
                Console.Write('#');
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(5);
                Console.Write('░');
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(5);
                Console.Write('░');
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(5);
                Console.Write('░');
            }
            Console.WriteLine("\n");
            Console.WriteLine("Система активна");
        }

        public void LandscapeAnalyze()
        {
            Console.WriteLine("Получение данных о местности...");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(200);
                Console.Write('#');
            }
            Console.WriteLine("\n");
        }

        public void ConnectToOrbiter() => Console.WriteLine("Система успешно подключена к орбитальной станции");
    }
}
