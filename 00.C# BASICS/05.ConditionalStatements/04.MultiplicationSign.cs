/* Problem 04. Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers,
without calculating it. Use a sequence of if operators. Examples:
*/

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers:");
        float numberA = float.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
        bool isPositive = true;
        if ((numberA == 0) || (numberB == 0) || (numberC == 0))
        {
            Console.WriteLine("0");
        }
        else
        {
            if (numberA < 0)
            {
                isPositive = !isPositive;
            }
            if (numberB < 0)
            {
                isPositive = !isPositive;
            }
            if (numberC < 0)
            {
                isPositive = !isPositive;
            }
            if (isPositive)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
    

