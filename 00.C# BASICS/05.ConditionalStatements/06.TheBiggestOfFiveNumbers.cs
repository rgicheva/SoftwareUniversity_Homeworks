/* Problem 06. The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements. Examples:
 */
using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers:");
        float numberA = float.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
        float numberD = float.Parse(Console.ReadLine());
        float numberE = float.Parse(Console.ReadLine());
        float highest = numberA;
        if (highest < numberB)
        {
            highest = numberB;
        }
        if (highest < numberC)
        {
            highest = numberC;
        }
        if (highest < numberD)
        {
            highest = numberD;
        }
        if (highest < numberE)
        {
            highest = numberE;
        }
        Console.WriteLine(highest);
    }
}

