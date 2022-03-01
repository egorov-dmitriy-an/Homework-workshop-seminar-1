// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N, например:
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8 

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int n;
        if(N >= 2) 
        {
            n = 2;
            while (n <= N)
            {
                Console.WriteLine(n + ", ");
                n = n + 2;
            }
        }
            else if (N <= 0)
            {
                n = 0;
                while (n >= N)
                {
                    Console.WriteLine(n + ", ");
                    n = n - 2;
                } 
            }
                else  Console.WriteLine("Чисел нет");
        }
    }
}