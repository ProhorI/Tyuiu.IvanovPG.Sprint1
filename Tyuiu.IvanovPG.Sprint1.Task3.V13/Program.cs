using Tyuiu.IvanovPG.Sprint1.Task3.V13.Lib;

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

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("**************************************************************************************");

            double a = 1;
            double b = 2;
            double c = 3;
            Console.WriteLine("первое число = " + a);
            Console.WriteLine("второе число = " + b);
            Console.WriteLine("третье число = " + c);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine(" = " + ds.MultiplyOfDigits(a * b * c));

            Console.ReadKey();

        }
    }
}