/* Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them. 
Try to implement this without if statements. Examples:
*/

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number from {0} and {1} is {2}", firstNumber, secondNumber, greaterNumber);
    }
}

