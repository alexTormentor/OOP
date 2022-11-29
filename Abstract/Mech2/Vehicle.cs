using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech2
{
    // Наследование класса MFC (3 + 1)
    // О - класс расширяет меха, но не изменяет, код не меняется - поведение - да

    // наследование - класс наследует от меха поведение и меняет его поведение, добавляя свои функции и задачи и методы
    public class Vehicle : Mech
    {
        protected String capacity;
        protected String specification;
        public Vehicle(String t, String a, String w, String d, String e, String m, String c, String _capacity, String _specification) : base(t, a, w, d, e, m, c) 
        {
            capacity = _capacity;
            specification = _specification;
        }
        public override string getType() { return type_model; }
        public override string getArmore() { return armore_type; }
        public override string getWeapon() { return weapon_type; }
        public override string getDesign() { return design_type; }
        public override string getEngine() { return engine_type; }
        public override string getModel() { return model; }
        public override string getCorp() { return corp; }
        public virtual string getCapacity() { return capacity; }
        public virtual string getSpecification() { return specification; }
        public override void Output()
        {
            Console.WriteLine("\n\nСоздан прототип боевой единицы\nПараметры:\n" + "Разработчик " + getCorp() + "\n\nХарактеристики единицы - \nНазвание:\t\t" + getModel() + "\nСемейство единицы:\t" + getDesign() +
                "\nКласс:\t\t\t" + getType() + "\nСпецификация:\t\t" + getCapacity() + "\nКласс брони:\t\t" + getArmore() + "\nВооружение:\t\t" + getWeapon() + "\nОснащение:\t\t" + getEngine() +
                "\nФункция:\t\t" + getSpecification());
        }
    }
}
