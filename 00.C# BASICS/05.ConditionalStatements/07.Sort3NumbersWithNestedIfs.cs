/*Problem 07. Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements.
Don’t use arrays and the built-in sorting functionality. Examples:
 */

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers:");
        float numberA = float.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
            
        if ((numberA > numberB) && (numberA > numberC))
        {
            if (numberB > numberC)
            {
                Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
            }
        }
        else if ((numberB > numberA) && (numberB > numberC))
        {
            if (numberA > numberC)
            {
                Console.WriteLine("{0} {1} {2}", numberB, numberA, numberC);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
            }
        }
        else if ((numberC > numberA) && (numberC > numberB))
        {
            if (numberA > numberB)
            {
                Console.WriteLine("{0} {1} {2}", numberC, numberA, numberB);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
            }
        }
    }
}
 

