//Problem 1: Odd or Even Integers
//Write an expression that checks if given integer is odd or even. Examples:
using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int[] numbersArray = new int[] { 3, 2, -2, -1, 0 };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Math.Abs(numbersArray[i] % 2) ==1);
        }
    }
}

