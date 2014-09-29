//Problem 1. Sum of 3 Integers
//Write a program that reads 3 integer numbers from the console and prints their sum. Examples:

using System;

class SumOf3Integers
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the secind number:");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the third number:");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The sum of {0}+{1}+{2} is {3}", a, b, c, a + b + c);
    }

}


