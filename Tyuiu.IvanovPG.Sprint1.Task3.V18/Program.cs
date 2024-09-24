using Tyuiu.IvanovPG.Sprint1.Task3.V18.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчеты и печатает результат на экране
// Расчеты: объявите исходные переменные и напишите программу вычисления площади треугольника

namespace Tyuiu.IvanovPG.Sprint1.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("**************************************************************************************");

            double a = 12;
            double b = 17;
            double c = 4;
            Console.WriteLine("Сторона А прямоугольника = " + a);
            Console.WriteLine("Сторона В прямоугольника = " + b);
            Console.WriteLine("Сторона C квадрата = " + c);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine(" = " + ds.HowManySquares(a, b, c));

            Console.ReadKey();

        }
    }
}