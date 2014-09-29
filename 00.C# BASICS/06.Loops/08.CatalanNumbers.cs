/*
 * In combinatorics, the Catalan numbers are calculated by the following formula: 
 * Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CatalanNumbers
{
    static void Main()
    {
        //input
        int n = 0;
        do
        {
            Console.Write("Please enter a valid integer value for N:");
        } while (!int.TryParse(Console.ReadLine(), out n));

        //logic and output
        double sum = 0;

        double nFacturiel = 1;
        for (int i = n; i > 0; i--)
        {
            nFacturiel *= i;
        }

        double n2Facturiel = 1;
        for (int i = n*2; i > 0; i--)
        {
            n2Facturiel *= i;
        }

        sum = n2Facturiel/((n+1)*nFacturiel*nFacturiel); 
        Console.WriteLine(sum);
    }
}

