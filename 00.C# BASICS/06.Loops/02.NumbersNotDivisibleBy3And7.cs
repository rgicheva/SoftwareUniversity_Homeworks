/* Problem 02.Numbers from 1 to N
Write a program that enters from the console a positive integer n and prints all the numbers 
from 1 to n, on a single line, separated by a space. Examples:
 */

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Please enter a number:" );
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

