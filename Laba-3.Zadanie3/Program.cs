using System;

//пространство имен
namespace ConsoleSettings;

//Класс программы
class Program
{
    // метод Main - точка начала выполнения команды
    static void Main(string[] args)
    {
        // вывод на консоль
        Console.WriteLine("Введите цифру от 1 до 4, соответсвующую времени года");
        // считать с консоли введенную цифру
        string x = Console.ReadLine();
        //начало выполнения блока условных конструкций(условие выполнения команды)
        switch (x)
        {
            case "1":
                Console.WriteLine("Зима");
                break;
            case "2":
                Console.WriteLine("Весна");
                break;
            case "3":
                Console.WriteLine("Лето");
                break;
            case "4":
                Console.WriteLine("Осень");
                break;
                // в других случаях
            default:
                Console.WriteLine("Вы нажали неизвестную цифру");
                break;
        }
    }
}    