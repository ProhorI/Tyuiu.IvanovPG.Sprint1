﻿using Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib;

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
            Console.Title = "Спринт #1 | Выполнил: ИВАНОВ П.Г.   | ИСТНБ - 24 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: ИВАНОВ П.Г.   | ИСТНБ - 24 - 1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, есть ли в строке слово Hello.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку: ");
            string x = Console.ReadLine();
            var res = ds.CheckHello(x);





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res == true)
            {
                Console.WriteLine("В вашей строке содержится слово 'Hello' ");
            }
            else
            {
                Console.WriteLine("В вашей строке не содержится слово 'Hello' ");
            }


            int a = 0, b = 0;

            b = Convert.ToInt32(Console.ReadLine());

            a = b + 1;

            Console.WriteLine(b * b);
            return;

            Console.WriteLine(a);



            Console.ReadKey();

        }
    }
}
