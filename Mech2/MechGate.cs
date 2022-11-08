using System;
using System.IO;
using System.Text;
namespace Mech2
{
    // Класс Популяция

    public class MechGate : GateDB
    {
        protected int n; // число мехов в ангаре
        protected Mech[] M; // имена членов всех семей
        // Это конструктор с параметром int N.
        // Ввод данных: 1 - с клавиатуры, 2 - из файла.
        public MechGate()
        {
            Console.Write("Задайте количество мехов: ");
            n = Convert.ToInt32(Console.ReadLine());
            M = new Mech[n];
            String t, a, w, d, e, m, c;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Концепт меха № {0}:", i + 1);
                Console.Write("Тип: ");
                t = Console.ReadLine();
                Console.Write("Броня: ");
                a = Console.ReadLine();
                Console.Write("Вооружение: ");
                w = Console.ReadLine();
                Console.Write("Паттерн: ");
                d = Console.ReadLine();
                Console.Write("Двигатель: ");
                e = Console.ReadLine();
                Console.Write("Название: ");
                m = Console.ReadLine();
                Console.Write("Разработчик: ");
                c = Console.ReadLine();
                M[i] = new Mech(t, a, w, d, e, m, c);
            }
        }
        public override void Model(String name)
        {
            if (n == 0)
                Console.WriteLine("База данных пуста!");
            else
            {
                if (name == "все")
                {
                    for (int i = 0; i < n; i++)
                        M[i].Output();
                }
                else
                {
                    bool b = false;
                    for (int i = 0; i < n; i++)
                        if (M[i].getModel().Equals(name))
                        {
                            b = true;
                            M[i].Output();
                        }
                    if (!b)
                        Console.WriteLine("Меха с названием '" + name + "' нет в базе данных");
                }
            }
        }
        public override void Model(int name)
        {
            if (n == 0)
                Console.WriteLine("База данных пуста!");
            else
            {
                if (name == 1)
                {
                    for (int i = 0; i < n; i++)
                        M[i].Output();
                }
                else
                {
                    bool b = false;
                    for (int i = 0; i < n; i++)
                        if (M[i].getModel().Equals(name))
                        {
                            b = true;
                            M[i].Output();
                        }
                    if (!b)
                        Console.WriteLine("Меха с названием '" + name + "' нет в базе данных");
                }
            }
        }
    }
}