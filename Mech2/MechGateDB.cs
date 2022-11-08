using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    public class MechGateDB : GateDB
    {

        // полиморфизм - переопределение методов родителя
        protected int n; // число мехов в ангаре
        protected Mech[] M; // имена членов всех семей
        int k;
        // Это конструктор с параметром int N.
        // Ввод данных: 1 - с клавиатуры, 2 - из файла.
        public MechGateDB(string file_name)
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
                M = new Mech[n];
                String t, a, w, d, e, m, c;
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
                    text = text.Remove(0, k);
                    c = text.Substring(0, k);
                    M[i] = new Mech(t, a, w, d, e, m, c);
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
