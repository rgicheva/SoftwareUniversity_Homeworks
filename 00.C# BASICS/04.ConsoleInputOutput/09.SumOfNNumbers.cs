/*Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and 
calculates and prints their sum. Note that you may need to use a for-loop. Examples:
 */

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n=");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter n{0} numbers:", i);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of the {0} numbers is: {1} ",n, sum);
    }
}

