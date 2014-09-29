/*
 * Using loops write a program that converts an integer number to its binary representation. The input is entered as long. 
 * The output should be a variable of type string. Do not use the built-in .NET functionality.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinaryNumber
{
    static void Main()
    {
        //input
        int n;
        do
        {
            Console.Write("Please enter a valid integer:");
        } while (!int.TryParse(Console.ReadLine(), out n));
        //logic and output
        string[] result = new string[32];
        for (int i = 31; i >= 0; i--)
        {
            if(n != 0  )
            {
                result[i] = Convert.ToString(n % 2);
                n = n / 2;
            }
            else
            {
                result[i] = "0";
            }
        }
        foreach (string res in result)
        {
            Console.Write(res);
        }
        Console.WriteLine();
    }
}
