using System;

namespace Lesson7task3
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Напишите программу, которая будет выполнять конвертирование валют.
    //Пользователь вводит:
    //сумму денег в определенной валюте.
    //курс для конвертации в другую валюту.
    //Организуйте вывод результата операции конвертирования валюты на экран.

    class Program
    {
        const double usdToCZK = 21.98;
        static double czk;
        static double usd;
        static bool isNum = true;
        static bool flag = true;

        static double USDtoCZK(double usd)
        {
            return usd * usdToCZK;
        }

        static void Main(string[] args)
        {

            while (flag)
            {
                while (isNum)
                {
                    Console.WriteLine("Input the amount in USD for convertation to CZK.");
                    isNum = double.TryParse(Console.ReadLine(), out usd);
                    if (!isNum)
                    {
                        Console.WriteLine("Its not a number, try again.");
                        isNum = true;
                        continue;
                    }
                    else
                    {
                        czk = USDtoCZK(usd);
                    }
                    break;
                }
                Console.WriteLine($"{czk} CZK");
                Console.WriteLine("Use some key for continue, or use Esc key for exit.");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    flag = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
