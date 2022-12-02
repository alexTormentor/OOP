using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_D
{
    public class Servitor : IAdutante
    {
        public void Response(string raport)
        {
            Console.WriteLine("Передача данных о тестировании в центр");
        }
    }
}
