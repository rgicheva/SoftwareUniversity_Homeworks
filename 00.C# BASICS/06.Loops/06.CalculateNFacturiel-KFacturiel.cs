/*
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateNFacturielKFacturiel
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
        sum = nFacturiel / kFacturiel;
        Console.WriteLine(sum);
    }
}

