/*
 *In combinatorics, the number of ways to choose k different members out of a group of n different 
 *elements (also known as the number of combinations) is calculated by the following formula:
 *For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
 * Try to use only two loops.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSequence2
{
    static void Main()
    {
        //input
        int k = 0;
        int n = 0;
        do
        {
            Console.Write("Please enter a valid integer value for N:");
        } while (!int.TryParse(Console.ReadLine(), out n));
        do
        {
            Console.Write("Please enter a valid integer value for K:");
        } while (!int.TryParse(Console.ReadLine(), out k));
        //logic and output
        double sum = 0;

            double nFacturiel = 1;
            for (int i = n; i > 0; i--)
            {
                nFacturiel *= i;
            }
            double kFacturiel = 1;
            for (int i = k; i > 0; i--)
            {
                kFacturiel *= i;
            }
            double knFacturiel = 1;
            for (int i = n-k; i > 0; i--)
            {
                knFacturiel *= i;
            }
            sum = nFacturiel / (kFacturiel * knFacturiel);
        Console.WriteLine(sum);
    }
}

