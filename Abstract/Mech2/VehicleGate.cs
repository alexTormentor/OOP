using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    public class VehicleGate : GateDB
    {
        protected int n; // число мехов в ангаре
        protected Vehicle[] V; // имена членов всех семей
        public VehicleGate()
        {
            Console.Write("Задайте количество ед. техники: ");
            n = Convert.ToInt32(Console.ReadLine());
            V = new Vehicle[n];
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
                V[i] = new Vehicle(t, a, w, d, e, m, c, _capacity, _specification);
                Machine vehicle = new AVehicle(m);
                vehicle.Tex();
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
                        V[i].Output();
                }
                else
                {
                    bool b = false;
                    for (int i = 0; i < n; i++)
                        if (V[i].getModel().Equals(name))
                        {
                            b = true;
                            V[i].Output();
                        }
                    if (!b)
                        Console.WriteLine("Меха с названием '" + name + "' нет в базе данных");
                }
            }
        }
    }
}
