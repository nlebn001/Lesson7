using System;

namespace Lesson7taks4
{

    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Напишите метод, который будет определять:
    //1) является ли введенное число положительным или отрицательным.
    //2) Является ли оно простым(используйте технику перебора значений).(Простое число – это натуральное число, которое делится на 1 и само на себя.Чтобы определить
    //простое число или нет, следует найти все его целые делители. Если делителей больше 2-х, значит оно не
    //простое.)
    //3) Делится ли на 2, 5, 3, 6, 9 без остатка.


    class Program
    {

        static int number;
        static bool isNumber = true;
        static bool isPrimeNumber = true;
        static bool flag = true;

        static void Method(int number)
        {
            PosOrNeg(number);

            if (number > 0)
            {
                IsPrimeNumber(number);
            }

            DivWithoutRem(number);

        }

        static void PosOrNeg(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"{number} is not a positive or negative number.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"{number} is positive number.");
            }
            else
            {
                Console.WriteLine($"{number} is negative number.");
            }
        }

        static void DivWithoutRem(int num)
        {
            if (num % 2 == 0 || num % 5 == 0 || num % 3 == 0 || num % 6 == 0 || num % 9 == 0)
            {
                Console.WriteLine("This number is divided without remainder with numbers 2, 5, 3, 6, 9\n\n");
            }
            else
            {
                Console.WriteLine("This number is not divided without remainder with numbers 2, 5, 3, 6, 9\n\n");
            }
        }


        static void IsPrimeNumber(int number)
        {
            for (int i = number; i > 0; i--)
            {
                if (number%i==0)
                {
                    isPrimeNumber = true;
                }
                else
                {
                    isPrimeNumber = false;
                }
            }

            if (isPrimeNumber == true)
            {
                Console.WriteLine("Is a prime number.");
            }
            else
            {
                Console.WriteLine("Is not a prime number.");
            }

        }


        static void Main(string[] args)
        {

            while (flag)
            {

                while (isNumber)
                {
                    Console.WriteLine("Input some number. Application will describe it.");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                    if (!isNumber)
                    {
                        Console.WriteLine("It's not a number, try again.");
                        isNumber = true;
                        continue;
                    }
                    else
                    {
                        Method(number);
                    }
                    break;
                }
                Console.WriteLine("Press any key to continue or Esc to exit the program.");
                ConsoleKey key = Console.ReadKey(true).Key;
                Console.Clear();
                if (key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Goodbye");
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
