using Tyuiu.IvanovPG.Sprint1.Task2.V9.Lib;

// ЗАДАНИЕ:
// Написать программу, которая запрашивает у пользователя исходные данные
// Выполняет указанные расчеты и печатает реузльтат на экране
// Рсчеты: Известно число.Найти его квадрат
// Число (целое число)
// Квадрат числа (целое число)


namespace Tyuiu.IvanovPG.Sprint1.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double result;


            int a = 6, b = 4;

            int x = 30 / 6 + 4;

            a++;

            x += b += a;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

