using System;
// пространство имен
namespace ConsoleApplication
{
    //класс прграммы
    class Program
    {
        // метод Main - точка начала выполнения команды
        static void Main(string[] args)
        {
            // объявляем локальную переменную ехр, значение которой будет правда или ложь(условные выражения)
            bool exp = true || false;
            bool x, y, z, t;
            // начинаем блок, в котором устанавливаем условия выполнения команды
            if (exp) ;
            {
                x = true;
                y = true;
                z = true;
                t = !z & !x | x & !y; //false
                // вывод на консоль 
                Console.WriteLine(t);
            }
            if (exp) ;
            {
                x = false;
                y = false;
                z = false;
                t = !z & !x | x & !y; //true
                Console.WriteLine(t + " удовлетворяет");
            }
            if (exp) ;
            {
                x = false;
                y = true;
                z = true;
                t = !z & !x | x & !y; //false
                Console.WriteLine(t);
            }
            if (exp) ;
            {
                x = false;
                y = false;
                z = true;
                t = !z & !x | x & !y; //false
                Console.WriteLine(t);
            }
            if (exp) ;
            {
                x = true;
                y = false;
                z = false;
                t = !z & !x | x & !y; //true
                Console.WriteLine(t + " удовлетворяет");
            }
            if (exp) ;
            {
                x = false;
                y = true;
                z = false;
                t = !z & !x | x & !y; //true
                Console.WriteLine(t + " удовлетворяет");
            }
            if (exp) ;
            {
                x = true;
                y = true;
                z = false;
                t = !z & !x | x & !y; //false
                Console.WriteLine(t);
            }
            if (exp) ;
            {
                x = true;
                y = false;
                z = true;
                t = !z & !x | x & !y; //true
                Console.WriteLine(t + " удовлетворяет");
            }
        }
            
    }
}


    