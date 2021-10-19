using System;
//пространство имен
namespace ConsoleApp
{
    //класс программы
    class Program
    {
        // метод Main - точка начала выполнения команды
        static void Main(string[] args)
        {
            Console.WriteLine("Работа светофора каждый час одинакова. Введите минуты часа (от 0 до 59),чтоб узнать цвет светофора: ");
            //вводим переменную целочисленного типа
            int Yellow = 1, Red = 2, Green = 3;
            //тут создается целочисленная переменная t, в которую заносится число, введенное с консоли. Все, что вводится с консоли, по умолчанию имеет тип string
            int t = int.Parse(Console.ReadLine());
            //% - остаток от целочисленного деления
            t = t % (Yellow + Red + Green);
            //Представляет текст как последовательность из частей кода
            String color;

            if (t < Green)
            {
                color = "Зеленый";
            }
            else if (t < Green + Yellow)
            {
                color = "Желтый";
            }
            else
                color = "Красный";
            Console.WriteLine(color);
        }
    }
}

        


        












