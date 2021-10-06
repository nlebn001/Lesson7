using System;

namespace Lesson7Task2
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub –
    //вычитание, Mul – умножение, Div – деление.Каждый метод должен принимать два целочисленных
    //аргумента и выводить на экран результат выполнения арифметической операции соответствующей
    //имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль.
    //Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак
    //арифметической операции, для выполнения вычислений.


    class Program
    {
        //Variables
        static int num1;
        static int num2;
        static char sign;
        static bool isNum1 = true;
        static bool isNum2 = true;
        static bool flag = true;
        static string str;

        //Methods
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        static double Div(int num1, int num2)
        {
            if (num2 == 0)
                return 0;
            else
                return (double)num1 / num2;
        }


        static void Main(string[] args)
        {


            while (flag)
            {

                while (isNum1)
                {
                    Console.WriteLine("Input 1st number");
                    str = Console.ReadLine();
                    isNum1 = int.TryParse(str, out num1);

                    if (!isNum1)
                    {
                        Console.WriteLine("It's not a number. Try again\n");
                        isNum1 = true;
                        continue;
                    }
                    break;
                }

                while (isNum2)
                {
                    Console.WriteLine("Input 2nd number");
                    str = Console.ReadLine();
                    isNum2 = int.TryParse(str, out num2);
                    if (!isNum2)
                    {
                        Console.WriteLine("It's not a number. Try again\n");
                        isNum2 = true;
                        continue;
                    }
                    break;
                }


                while (true)
                {
                    Console.WriteLine("Input operation sign (+, -, *, /)");
                    str = Console.ReadLine();

                    switch (str)
                    {
                        case "+":
                            Console.WriteLine($"Answer is " + Add(num1, num2));
                            break;

                        case "-":
                            Console.WriteLine($"Answer is " + Sub(num1, num2));
                            break;

                        case "*":
                            Console.WriteLine($"Answer is " + Mul(num1, num2));
                            break;

                        case "/":
                            Console.WriteLine($"Answer is " + Div(num1, num2));
                            break;

                        default:
                            Console.WriteLine("It is not a sign. Try again.\n");
                            continue;
                    }
                    Console.WriteLine("Push some key for continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
