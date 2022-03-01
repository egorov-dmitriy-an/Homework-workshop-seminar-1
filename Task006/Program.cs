// Задача 6: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка), например:
//  4 -> да
// -3 -> нет 
//  7 -> нет 

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int ostatok = number%2;
        if(ostatok == 0) Console.WriteLine("Число " + number + " - четное");
        else Console.WriteLine("Число " + number + " - нечетное");
        }
    }
}