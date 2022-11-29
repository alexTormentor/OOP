using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    public class ExoframeGate : GateDB
    {
        protected int n; // число мехов в ангаре
        protected Exoframe[] E; // имена членов всех семей
        public ExoframeGate()
        {
            Console.Write("Задайте количество фреймов: ");
            n = Convert.ToInt32(Console.ReadLine());
            E = new Exoframe[n];
            String t, a, w, d, e, m, c, _capacity, _specification;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Концепт ед. техники № {0}:", i + 1);
                Console.Write("Класс: ");
                t = Console.ReadLine();
                Console.Write("Броня: ");
                a = Console.ReadLine();
                Console.Write("Вооружение: ");
                w = Console.ReadLine();
                Console.Write("Ветка: ");
                d = Console.ReadLine();
                Console.Write("Оснащение: ");
                e = Console.ReadLine();
                Console.Write("Название: ");
                m = Console.ReadLine();
                Console.Write("Разработчик: ");
                c = Console.ReadLine();
                Console.Write("Спецификация: ");
                _capacity = Console.ReadLine();
                Console.Write("Функция: ");
                _specification = Console.ReadLine();
                E[i] = new Exoframe(t, a, w, d, e, m, c, _capacity, _specification);
                Machine exoframe = new AExoframe(m);
                exoframe.Tex();
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
                        E[i].Output();
                }
                else
                {
                    bool b = false;
                    for (int i = 0; i < n; i++)
                        if (E[i].getModel().Equals(name))
                        {
                            b = true;
                            E[i].Output();
                        }
                    if (!b)
                        Console.WriteLine("Меха с названием '" + name + "' нет в базе данных");
                }
            }
        }
    }
}
