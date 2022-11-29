using System;
namespace Mech2
{
    class Program
    {
        static void Main()
        {
            // R - объект родительского класса
            /*Mech standart = new Mech("тяжёлый", "титан", "ПД-4.17/2А", "страйдер", "кластерная", "Центурион-1", "Кластор Текнолоджи") ;
            standart.Output();
            standart.Tir();    // разделитель информации
                        // D - объект дочернего класса
            Vehicle vehicle = new Vehicle("тяжёлый", "листовая броня", "фугас, ракеты", "танк", "гусеничная платформа", "Хармс-2", "Кластор Текнолоджи", "4 человека", "боевая единица");
            vehicle.Output();
            vehicle.Tir();

            Exoframe exo = new Exoframe("грузовой", "кевларные пластины", "ракеты ЗЗ-2П", "экзоскелет", "сервопривод", "Гридус", "Кластор Текнолоджи", "120 кг", "поддержка", 3);
            exo.Output();
            exo.Tir();

            Console.WriteLine("Мех:\t\t" + standart.getModel());
            Console.WriteLine("техника:\t" + vehicle.getModel());
            Console.WriteLine("экзофрейм:\t" + exo.getModel());
            Console.WriteLine("серия:\t\t" + exo.getSerial());
            exo.Tir();*/
            
           
            

            //OLD OOP WORKING
            MechGate M = new MechGate();
            Console.Write("Задайте имя меха для поиска или укажите 'все': ");
            String name = Console.ReadLine();            
            M.Model(name);

            VehicleGate V = new VehicleGate();
            Console.Write("Задайте имя техники для поиска или укажите 'все': ");
            String name3 = Console.ReadLine();            
            V.Model(name3);

            ExoframeGate E = new ExoframeGate();
            Console.Write("Задайте имя техники для поиска или укажите 'все': ");
            String name5 = Console.ReadLine();
            E.Model(name5);
            Console.ReadLine();

            //инкапсуляция - сокрытие методов реализации от изменения; элементы кода могут тестироваться и использоваться независимо
            //наследование - общий класс определяет хар-ки и поведение связанных объектов и может быть унаследован другими классами, кот. будут изменять поведение базового класса
            //полиморфизм - переопределение метода или класса через родителя получает поведение кот. соотв. классу-потомку на кот. ссылается объект
            //абстракция - создание класса который определяет поведение сущности независимо от реализации - реализация будет выполнена в классе-наследнике и выполнит реализацию абстрактного класа
           
        }
    }
}