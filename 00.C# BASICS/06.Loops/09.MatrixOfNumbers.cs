/*
 * Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
 * and prints a matrix like in the examples below. Use two nested loops.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfNumbers
{
    static void Main()
    {
        //input 
        int n;
        do
        {
            Console.Write("Please enter a valid positiv number between 1 and 20:");
        } while (!int.TryParse(Console.ReadLine(), out n) || !(n>=1 && n<=20));
        //logic and output
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i+j+" ");
            }
            Console.WriteLine();
        }
    }
}

