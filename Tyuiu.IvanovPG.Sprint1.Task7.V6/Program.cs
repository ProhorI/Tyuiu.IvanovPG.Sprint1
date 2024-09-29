
using Tyuiu.IvanovPG.Sprint1.Task7.V6.Lib;

// ЗАДАНИЕ:
// Написать программу, которая вычисляет математическое выражене
// по исходным значениям данных, вводных пользователем
// 
//                  x
//     (      1   )           2
// z = ( 1 + ---  )  - 12 * x  * y
//     (        2 )
//     (      x   )




namespace Tyuiu.IvanovPG.Sprint1.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("                  x                                                                   ");
            Console.WriteLine("     (      1   )          2                                                          ");
            Console.WriteLine(" z = ( 1 + ---  )  - 12 * x  * y                                                      ");
            Console.WriteLine("     (        2 )                                                                     ");
            Console.WriteLine("     (      x   )                                                                     ");



            double x, y;


            Console.WriteLine("Введите значение х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
