using Tyuiu.IvanovPG.Sprint1.Task1.V0.Lib;

// Написать программу, которая запрашивает у пользователя исходные данные,
// вычисляет результат по формуле x / ( y - 1 ) и печатает его на экран

namespace Tyuiu.IvanovPG.Sprint1.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Иванов П.Г. | ИСТНБ-24-1";
            // Длина строки 75 символом
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* спринт #1 *");
            Console.WriteLine("* Тема: Базовые навыки работы с C# *");
            Console.WriteLine("* задание #0 *");
            Console.WriteLine("* вариант #0 *");
            Console.WriteLine("* выполнил: Иванов Прохор Геннадьевич | ИСТНБ-24-1 *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле x / (1 - y) и печатает его на экран *");
            Console.WriteLine("* *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("**************************************************************************************");



            double x, y, a;
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            //метод Calculate находится в библиотеке Tyuiu.IvanovPG.Sprint1.Task1.V0.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate(x, y, a));

            Console.ReadLine();

        }
    }
}