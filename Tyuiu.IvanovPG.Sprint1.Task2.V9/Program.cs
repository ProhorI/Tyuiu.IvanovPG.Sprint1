﻿using Tyuiu.IvanovPG.Sprint1.Task2.V0.Lib;

// ЗАДАНИЕ:
// Написать программу, которая запрашивает у пользователя исходные данные
// Выполняет указанные расчеты и печатает реузльтат на экране
// Рсчеты: Известно число.Найти его квадрат
// Число (целое число)
// Квадрат числа (целое число)


namespace Tyuiu.IvanovPG.Sprint1.Task2.V0
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
            Console.WriteLine("* задание #2                                                                         *");
            Console.WriteLine("* вариант #9                                                                         *");
            Console.WriteLine("* выполнил: Иванов Прохор Геннадьевич | ИСТНБ-24-1                                   *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,            *");
            Console.WriteLine("* вычисляет результат по формуле (4/3) * 3.14 * r * r * r и печатает его на экран    *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");


            int r;
            Console.WriteLine("Введите значение r:");
            r = Convert.ToInt32(Console.ReadLine());

            Math.Round(25.132741228718345, 3);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Обьем шара = " + ds.CalculateVolumeCircle(r));

            Console.WriteLine(string.Format("{0:F3}", 25.132741228718345));

            Console.ReadLine();
        }
    }
}