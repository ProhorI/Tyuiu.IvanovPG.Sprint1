// ЗАДАНИЕ:
// Написать программу которая запрашивает у пользователя исходные данныеъ,
// вычисляет результат по формуле и печатает его на экран
// ФОРМУЛА:
//
// —-------—
// (x + y ^ 2) / e ^ 2 - 4 * y

using Tyuiu.IvanovPG.Sprint1.Task4.V15.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("**************************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("(x + y ^ 2) / e ^ 2 - 4 * y) = " + ds.Calculate(x, y));



            Console.ReadKey();

        }
    }
}