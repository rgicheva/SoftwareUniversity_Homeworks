/*
 * Write a program that calculates with how many zeroes the factorial of a given number n has 
 * at its end. Your program should work well for very big numbers, e.g. n=100000. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class TrailingZeroesInN
{
    static void Main()
    {
        //input
        Console.Write("Please enter n:");
        int number = int.Parse(Console.ReadLine());
        //logic
        int zeroCounter = 0;
        int temp;
        for (int i = 5; i <= number; i += 5)
        {
            temp = i;
            while (temp % 5 == 0)
            {
                temp /= 5;
                zeroCounter++;
            }
        }
        //output
        Console.Write("Trailing zeros: {0}", zeroCounter);
        Console.WriteLine();
    }
}

