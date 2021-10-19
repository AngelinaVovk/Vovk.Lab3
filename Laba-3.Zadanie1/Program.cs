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
        Console.WriteLine("Ниже введите значение х");
        //определим простейшую переменную и считаем введенную переменную с консоли
        string xstr = Console.ReadLine();
        //преобразуем переменную в тип дабл для математических расчетов
        double x = Convert.ToDouble(xstr);
        // начинаем блок, в котором устанавливаем условия выполнения команды
        if (x > 15)
        {
            double y = x + 2;
            Console.WriteLine("При введенном вами значении х, у= " + y);
        }
        else if (x > -10 && x <= 15)
        {
            double y = 3 + x;
            Console.WriteLine("При введенном вами значении х, у= " + y);
        }
        else 
        {
            double y = 3 * x;
            Console.WriteLine("При введенном вами значении х, у= " + y);
        }
    }
}
         
       