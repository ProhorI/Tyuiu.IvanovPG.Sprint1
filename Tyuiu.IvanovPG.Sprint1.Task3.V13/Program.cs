using Tyuiu.IvanovPG.Sprint1.Task3.V13.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчеты и печатает результат на экране
// Расчеты: объявите исходные переменные и напишите программу которая вычисляет,
// сколько квадратов со стороной C можно разместить внутри прямоугольника с размерами A x B без наложений

namespace Tyuiu.IvanovPG.Sprint1.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Иванов П.Г. | ИCТНБ - 24 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Иванов П.Г.       | ИCТНБ - 24 - 1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу , которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* выполняет указанные расчёты  и печатает результат на экране.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = 123;

            Console.WriteLine("Трёхзначное число = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Произведение цифр трёхзначного числа: " + ds.MultiplyOfDigits(x));
            Console.ReadKey();

        }
    }
}