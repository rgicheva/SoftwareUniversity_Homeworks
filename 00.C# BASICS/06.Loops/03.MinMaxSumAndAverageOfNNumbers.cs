/* Problem 03. Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
The output is like in the examples below. Examples:
*/

using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number for count of sequence, n = ");
            int nNumber;
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;
            while (!int.TryParse(Console.ReadLine(), out nNumber)|| nNumber < 0)
            {
                Console.Write("Invalid number!!! Please enter a valid positive integer: "); 
            }
            for (int i = 0; i < nNumber; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                min = Math.Min(min, numbers);
                max = Math.Max(max, numbers);
                sum += numbers;
                avg = sum / nNumber;
            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Avg = {0:F2}", avg);
        }
    }

