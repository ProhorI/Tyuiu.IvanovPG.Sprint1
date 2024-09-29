using Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib;

// ЗАДАНИЕ:
// Написать программу: пользователь вводит строку.
// Удалить из строки все символы пробела и символ *

namespace Tyuiu.IvanovPG.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");



            Console.WriteLine("Введите строку:                                                                      ");
            string str = Console.ReadLine();



            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine(ds.CheckHello(str));


            Console.ReadKey();

        }
    }
}
