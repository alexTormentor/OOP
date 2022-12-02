// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Liskov substitution Principle - принцип подстановки Барбары Лисков. Должна быть возможность вместо базового 
 (родительского) типа (класса) подставить любой его подтип (класс-наследник), при этом работа программы не должна измениться.

Интерфейс IShopService имеет 2 метода: GetNameShop и GetLocationShop. В реализации AsosShopService по логике нельзя реализовать метод
GetLocationShop, т к не существует точного расположения магазина, что собственно противоречит третьему приципу SOLID.
Необходимо создать дополнительный класс OfflineShopService и расширить методом GetLocationShop.
 */
