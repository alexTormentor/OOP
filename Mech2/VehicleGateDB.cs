using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    public class VehicleGateDB : GateDB
    {
        protected int n; // число мехов в ангаре
        protected Vehicle[] V; // имена членов всех семей
        int k;

        public VehicleGateDB(string file_name)
        {
            Console.Write("Задайте имя текстового файла данных без расширения: ");
            file_name = Console.ReadLine() + ".txt";
            StreamReader sr; // поток для чтения
            try
            {
                // Чтение из файла
                // связывание с файлом, кодировка символов Юникода
                sr = new StreamReader(file_name, UTF8Encoding.Default);
                string text = sr.ReadLine(); // чтение 0-й строки
                n = Convert.ToInt32(text);
                V = new Vehicle[n];
                String t, a, w, d, e, m, c, _capacity, _specification;
                k = -1;
                int i = 0; // счетчик строк
                while ((text != null) && (i < n)) // Чтение из файла
                {
                    text = sr.ReadLine(); // чтение строк
                                          // разбор строки
                    k = text.IndexOf(" ");
                    t = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    a = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    w = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    d = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    e = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    m = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    c = text.Substring(0, k);
                    text = text.Remove(0, k + 1);
                    k = text.IndexOf(" ");
                    _capacity = text.Substring(0, k);
                    text = text.Remove(0, k+1);
                    _specification = text.Substring(0, k);
                    V[i] = new Vehicle(t, a, w, d, e, m, c, _capacity, _specification);
                    i++;
                }
                sr.Close(); // закрытие файла "info.txt" для чтения
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА: " + ex.Message);
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
                        Console.WriteLine("Машины с названием '" + name + "' нет в базе данных");
                }
            }
        }
    }
}
