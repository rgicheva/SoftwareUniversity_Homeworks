/*Problem 5. The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers. Examples:
 */

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers:");
        float numberA = float.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
        float highest = numberA;
        if (highest < numberB)
        {
            highest = numberB;
        }
        if (highest < numberC)
        {
            highest = numberC;
        }
        Console.WriteLine(highest);
    }
}

