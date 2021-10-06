using System;

namespace Lesson7
{

//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных
//аргумента и выводит на экран среднее арифметическое значений аргументов.

    class Program
    {

        static int Calculate(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3;
        }


        static void Main(string[] args)
        {
            int x = Calculate(20, 40, 50);

            Console.WriteLine(x);
        }
    }
}
