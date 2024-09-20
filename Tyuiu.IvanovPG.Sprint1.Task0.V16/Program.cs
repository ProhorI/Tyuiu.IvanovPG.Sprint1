using Tyuiu.IvanovPG.Sprint1.Task0.V16.Lib;

// ЗАДАНИЕ
//написать программу, которая вычисляет выражение 6 / 2 / 3 + 1 - 6 / 2 * 3 и печатает результат на экран

namespace Tyuiu.IvanovPG.Sprint1.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Иванов П.Г. | ИСТНБ-24-1";
            // Длина строки 75 символом
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* спринт #1                                                                          *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                   *");
            Console.WriteLine("* задание #0                                                                         *");
            Console.WriteLine("* вариант #16                                                                        *");
            Console.WriteLine("* выполнил: Иванов Прохор Геннадьевич | ИСТНБ-24-1                                   *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 6 / 2 / 3 + 1 - 6 / 2 * 3          *");
            Console.WriteLine("* и печает результат на экране.                                                      *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* 6 / 2 / 3 + 1 - 6 / 2 * 3                                                          *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}