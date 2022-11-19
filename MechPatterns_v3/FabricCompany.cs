using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    abstract class Company                  // класс компании
    {
        public string Name { get; set; }

        public Company(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public Gun Create(String n);       // абстрактный класс для метода
    }
}
