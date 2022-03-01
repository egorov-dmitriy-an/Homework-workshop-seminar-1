// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел, например:
//  2, 3,  7 ->  7
// 44, 5, 78 -> 78 
// 22, 3,  9 -> 22 

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int maxnumber;                     
            
            if(number1 >= number2) maxnumber = number1;
            else maxnumber  = number2;

            if(maxnumber <= number3) maxnumber = number3;

            Console.WriteLine("Максимальным числом из: " + number1 + ", " + number2 + ", " + number3 + " является " + maxnumber); 
        }
    }
}