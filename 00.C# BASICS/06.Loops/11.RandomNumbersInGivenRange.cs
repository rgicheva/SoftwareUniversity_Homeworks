/*
 * Write a program that enters 3 integers n, min and max (min ≤ max)
 * and prints n random numbers in the range [min...max].
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        //input
        int n;
        int min;
        int max;
        do
        {
            Console.Write("Please enter how many random numbers you need:");
        } while (!int.TryParse(Console.ReadLine(), out n));
        do
        {
            Console.Write("Please enter a min:");
        } while (!int.TryParse(Console.ReadLine(), out min));
        do
        {
            Console.Write("Please enter max ( max > min):");
        } while (!int.TryParse(Console.ReadLine(), out max) || !(max > min));
        //logic and output
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(rand.Next(min, max)+" ");
        }
        Console.WriteLine();
    }
}

