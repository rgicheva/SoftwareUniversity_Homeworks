using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        //input
        int x = 0;
        int n = 0;
        do
        {
            Console.Write("Please enter a valid integer value for N:");
        } while (!int.TryParse(Console.ReadLine(), out n));
        do
        {
            Console.Write("Please enter a valid integer value for X:"); 
        } while (!int.TryParse(Console.ReadLine(), out x));
        //logic and output
        double sum = 1;
        for (int i = 1; i <=n; i++)
        {
            double nFacturiel = 1;
            for (int j = i; j > 0; j--)
            {
                nFacturiel *= j;
            }
            sum += nFacturiel /  Math.Pow(x, i);
        }
        Console.WriteLine(sum);
    }
}

