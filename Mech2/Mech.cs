using System;
namespace Mech2
{
    // Инкапсуляция в классе MFC
    // С - этот класс нигде больше не юзается, т.е. вып. свою функцию
    // Л - базовый класс наследуется потомками  и меняется
    // Д - абстракция не зав. от класса а вот класс - да

    // наследование классом интерфейса
    public class Mech : IMech
    {
        // инкапсуляция - сокрытие реализации присвоения и прочих процедур от внешних модулей
        public String type_model { get; set; }
        public String armore_type { get; set; }
        public String weapon_type { get; set; }
        public String design_type { get; set; }
        public String engine_type { get; set; }
        public String model { get; set; }
        public String corp { get; set; }
        public Mech(String t, String a, String w, String d, String e, String m, String c)
        {
            type_model = t;
            armore_type = a;
            weapon_type = w;
            design_type = d;
            engine_type = e;
            model = m;
            corp = c;
        }
        public virtual string getType() { return type_model; }
        public virtual string getArmore() { return armore_type; }
        public virtual string getWeapon() { return weapon_type; }
        public virtual string getDesign() { return design_type; }
        public virtual string getEngine() { return engine_type; }
        public virtual string getModel() { return model; }
        public virtual string getCorp() { return corp; }
        public virtual void Output()
        {
            Console.WriteLine("\n\nСоздан прототип меха\nПараметры:\nРазработчик:\t\t" + getCorp() + "\nМодель:\t\t\t" + getModel() + "\nКласс:\t\t\t" + getType() + "\nИнвариант:\t\t" + getDesign()
                + "\nДвигатель:\t\t" + getEngine() + "\nКласс брони:\t\t" + getArmore() + "\nКласс вооружения:\t" + getWeapon());
        }
        public virtual void Tir()
        {
            Console.WriteLine("_____________________________");
        }
    }
}